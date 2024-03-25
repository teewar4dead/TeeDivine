using Divine.Entity;
using Divine.Entity.Entities;
using Divine.Entity.Entities.Abilities.Components;
using Divine.Entity.Entities.Abilities.Items;
using Divine.Entity.Entities.Abilities.Spells;
using Divine.Entity.Entities.PhysicalItems;
using Divine.Entity.Entities.Units;
using Divine.Entity.Entities.Units.Heroes;
using Divine.Entity.Entities.Units.Heroes.Components;
using System.Collections.Concurrent;
using System.Reflection;
using Tee.Core.Attributes;
using Tee.Core.Entities.Abilities;
using Tee.Core.Entities.Units;
using Tee.Entities;

namespace Tee.Core.Utilities
{
    public class TeeEntityManager
    {
        private static readonly Dictionary<uint, TeeEntity> EntitiesDict = new();
        private static readonly ConcurrentDictionary<HeroId, Type> HeroCache = new();
        private static readonly ConcurrentDictionary<AbilityId, Type> SpellOrItemCache = new();

        private static event Action<TeeEntity> _entityAdded;
        private static event Action<TeeEntity> _entityRemoved;


        public static event Action<TeeEntity> EntityAdded
        {
            add => AddEvent(EntitiesDict.Values.OfType<TeeEntity>(), value, ref _entityAdded);
            remove => _entityRemoved -= value;
        }
        public static event Action<TeeEntity> EntityRemoved
        {
            add => _entityRemoved += value;
            remove => _entityRemoved -= value;
        }

        static TeeEntityManager()
        {
            InitializeCaches();
            EntityManager.EntityAdded += DivineEntityAdded;
            EntityManager.EntityRemoved += DivineEntityRemoved;
        }


        private static void InitializeCaches()
        {
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
            {
                switch (type.GetCustomAttributes(false).FirstOrDefault(attr => attr is HeroAttribute or AbilityAttribute))
                {
                    case HeroAttribute heroAttribute:
                        HeroCache[heroAttribute.HeroId] = type;
                        break;
                    case AbilityAttribute itemAttribute:
                        SpellOrItemCache[itemAttribute.AbilityId] = type;
                        break;
                }
            }
        }


        private static void AddEvent<T>(IEnumerable<T> entities, Action<T> handler, ref Action<T> eventAction) where T : class
        {
            foreach (var entity in entities)
            {
                handler(entity);
            }
            eventAction += handler;
        }

        private static void DivineEntityAdded(Divine.Entity.EventArgs.EntityAddedEventArgs e)
        {
            var entity = Create(e.Entity);
            if (entity == null)
                return;
            _entityAdded?.Invoke(entity);
            EntitiesDict[e.Entity.Handle] = entity;
        }

        private static void DivineEntityRemoved(Divine.Entity.EventArgs.EntityRemovedEventArgs e)
        {
            if (!EntitiesDict.TryGetValue(e.Entity.Handle, out var removedEntity))
            {
                return;
            }
            _entityRemoved?.Invoke(removedEntity);
            EntitiesDict.Remove(e.Entity.Handle);
        }

        public static TeeEntity Create(Entity entity)
        {
            return entity switch
            {
                PhysicalItem physicalItem => CreatePhysicalItem(physicalItem),
                Item item => CreateItem(item),
                Spell spell => CreateSpell(spell),

                Hero hero => CreateHero(hero),
                Unit unit => CreateUnit(unit),
                _ => new TeeEntity(entity),
            };
        }

        private static TeePhysicalItem CreatePhysicalItem(PhysicalItem physicalItem)
        {
            var createdPhysicalItem = new TeePhysicalItem(physicalItem);
            return createdPhysicalItem;
        }
        private static TeeHero CreateHero(Hero hero)
        {
            if (!HeroCache.TryGetValue(hero.HeroId, out var heroType))
            {
                var defaultHero = new TeeHero(hero);
                return defaultHero;
            }

            var createdHero = (TeeHero)Activator.CreateInstance(heroType, hero);
            return createdHero;
        }
        private static TeeUnit CreateUnit(Unit unit)
        {
            var createdUnit = new TeeUnit(unit);
            return createdUnit;
        }
        private static TeeSpell CreateSpell(Spell spell)
        {
            if (!SpellOrItemCache.TryGetValue(spell.Id, out var spellType))
            {
                return new TeeSpell(spell);
            }

            var createdSpell = (TeeSpell)Activator.CreateInstance(spellType, spell);
            return createdSpell;
        }

        private static TeeItem CreateItem(Item item)
        {
            if (!SpellOrItemCache.TryGetValue(item.Id, out var itemType))
            {
                var defaultItem = new TeeItem(item);
                return defaultItem;
            }
            var createdItem = (TeeItem)Activator.CreateInstance(itemType, item);
            return createdItem;
        }

        public static IEnumerable<T> GetEntities<T>() where T : TeeEntity
        {
            return EntitiesDict.Values.OfType<T>();
        }

        public static TeeEntity GetTeeEntityByHandle(uint Handle)
        {
            if (EntitiesDict.TryGetValue(Handle, out var unit))
            {
                return unit;
            }

            return null;
        }
        public static TeeEntity GetTeeEntity(Entity entity)
        {
            if (EntitiesDict.TryGetValue(entity.Handle, out var Tentity))
            {
                return Tentity;
            }

            return null;
        }
    }
}
