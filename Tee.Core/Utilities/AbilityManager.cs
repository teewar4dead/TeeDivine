using Divine.Entity.Entities;
using Divine.Entity.Entities.Abilities;
using Divine.Entity.Entities.Abilities.Items;
using Divine.Entity.Entities.EventArgs;
using Divine.Entity.Entities.Units;
using Divine.Entity.Entities.Units.Creeps;
using Divine.Network;
using Divine.Update;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Tee.Core.Delegates;
using Tee.Core.Entities.Abilities;
using Tee.Core.Entities.Units;
using Tee.Entities;

namespace Tee.Core.Utilities
{
    public class AbilityManager
    {
        private static readonly ConcurrentDictionary<uint, ConcurrentDictionary<uint, TeeItem>> OldItems = new();
        private static readonly Dictionary<uint, TeeItem> Items = new();
        private static readonly Dictionary<uint, uint> ItemOwners = new();

        private static readonly ConcurrentDictionary<uint, ConcurrentDictionary<uint, TeeSpell>> OldSpells = new();
        private static readonly Dictionary<uint, TeeSpell> Spells = new();
        private static readonly Dictionary<uint, uint> SpellOwners = new();

        public static event SpellEventHandler SpellRemoved;
        public static event ItemEventHandler ItemRemoved;

        private static SpellEventHandler _spellAdded;
        private static ItemEventHandler _itemAdded;
        public static event SpellEventHandler SpellAdded
        {
            add
            {
                foreach (var spell in Spells.Values)
                {
                    value.Invoke(SpellOwners.GetValueOrDefault(spell.Handle), spell);
                }

                _spellAdded += value;
            }

            remove
            {
                _spellAdded -= value;
            }
        }
        public static event ItemEventHandler ItemAdded
        {
            add
            {
                foreach (var item in Items.Values)
                {
                    value.Invoke(ItemOwners.GetValueOrDefault(item.Handle), item);
                }

                _itemAdded += value;
            }

            remove
            {
                _itemAdded -= value;
            }
        }

        static AbilityManager()
        {
            TeeEntityManager.EntityAdded += OnEntityAdded;
            TeeEntityManager.EntityRemoved += OnEntityRemoved;
            Entity.NetworkPropertyChanged += OnNetworkPropertyChanged;
        }

        private static void OnNetworkPropertyChanged(Entity sender, NetworkPropertyChangedEventArgs e)
        {
            if (e.PropertyName != "m_iParity" || e.NewValue.GetInt32() == e.OldValue.GetInt32())
            {
                return;
            }

            UpdateManager.BeginInvoke(100, () =>
            {
                if (!(sender is Unit unit) || !unit.IsControllable)
                {
                    return;
                }

                var teeUnit = (TeeUnit)unit;
                if (teeUnit == null)
                {
                    return;
                }

                RefreshItems(teeUnit);
            });
        }

        private static void OnEntityAdded(TeeEntity entity)
        {
            if (entity is TeeUnit unit && entity.BaseEntity is not Creep && unit.HasInventory)
            {
                RefreshItems(unit);
            }
            if (entity is TeeItem item)
            {
                if (item.Owner is TeeUnit unitItem)
                {
                    RefreshItems(unitItem);
                }
            }
            if (entity is TeeSpell spell)
            {
                if (spell.Owner is TeeUnit unitSpell)
                {
                    RefreshSpells(unitSpell);
                }
            }
        }
        private static void RefreshSpells(TeeUnit unit)
        {

            var abilities = unit.Spellbook.MainSpells;

            var newSpells = abilities
                .Where(spell => spell != null)
                .ToDictionary(spell => spell.Handle, spell => spell);

            var oldSpells = OldSpells.GetOrAdd(unit.Handle, new ConcurrentDictionary<uint, TeeSpell>());

            foreach (var (handle, spell) in newSpells)
            {
                if (!oldSpells.ContainsKey(handle))
                {
                    Spells[handle] = spell;
                    SpellOwners[handle] = unit.Handle;
                    _spellAdded?.Invoke(unit.Handle, spell);
                }
            }

            foreach (var handle in oldSpells.Keys.ToList())
            {
                if (!newSpells.ContainsKey(handle) && oldSpells.TryRemove(handle, out var spell))
                {
                    Spells.Remove(handle);
                    SpellRemoved?.Invoke(SpellOwners[handle], spell);
                }
            }

            foreach (var handle in newSpells.Keys)
            {
                oldSpells[handle] = newSpells[handle];
            }
        }
        private static void RefreshItems(TeeUnit unit)
        {
            if (!unit.HasInventory) return;

            var inventory = unit.Inventory;

            // Получаем основные предметы, нейтральный предмет и ТП
            var newItems = new Dictionary<uint, TeeItem>(
                inventory.MainItems
                .Concat(new[] { inventory.NeutralItem, inventory.TownPortalScroll })
                .Where(item => item != null)  // Убедитесь, что убираете null значения
                .ToDictionary(item => item.Handle, item => item)
            );

            var oldItems = OldItems.GetOrAdd(unit.Handle, new ConcurrentDictionary<uint, TeeItem>());

            foreach (var (handle, item) in newItems)
            {
                if (!oldItems.ContainsKey(handle))
                {
                    Items[handle] = item;
                    ItemOwners[handle] = unit.Handle;
                    _itemAdded?.Invoke(unit.Handle, item);
                }
            }

            foreach (var handle in oldItems.Keys.ToList())
            {
                if (!newItems.ContainsKey(handle) && oldItems.TryRemove(handle, out var item))
                {
                    Items.Remove(handle);
                    ItemRemoved?.Invoke(ItemOwners[handle], item);
                }
            }

            foreach (var handle in newItems.Keys)
            {
                oldItems[handle] = newItems[handle];
            }
        }


        private static void OnEntityRemoved(TeeEntity entity)
        {
            switch (entity)
            {
                case TeeUnit unit when OldItems.ContainsKey(unit.Handle):
                    if (OldItems.TryRemove(unit.Handle, out var unitItems))
                    {
                        foreach (var item in unitItems.Values)
                        {
                            Items.Remove(item.Handle);
                            ItemRemoved?.Invoke(ItemOwners[item.Handle], item);
                            ItemOwners.Remove(item.Handle);
                        }
                    }
                    break;

                case TeeItem item:
                    var ownerHandle = ItemOwners.GetValueOrDefault(item.Handle);
                    if (ownerHandle != null && OldItems.ContainsKey(ownerHandle) && OldItems[ownerHandle].TryRemove(item.Handle, out _))
                    {
                        Items.Remove(item.Handle);
                        ItemRemoved?.Invoke(ownerHandle, item);
                        ItemOwners.Remove(item.Handle);
                    }
                    break;
            }
        }
    }
}
