using Divine.Entity.Entities.Abilities;
using Divine.Entity.Entities.Abilities.Items;
using Divine.Entity.Entities.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Tee.Core.Attributes;
using Tee.Core.Entities.Abilities;
using Tee.Core.Entities.Units;
using Tee.Core.Utilities;

namespace Tee.Core
{
    public class ActionManager : IDisposable
    {
        private static readonly Dictionary<Type, AbilityAttribute> _abilityAttributesCache = new();
        private static readonly Dictionary<uint, (List<TeeAbility>, Action<object>)> _actionIds = new();

        private TeeUnit _myUnit;

        static ActionManager()
        {
            AbilityManager.ItemAdded += AddAbility;
            AbilityManager.ItemRemoved += RemoveAbility;

            AbilityManager.SpellAdded += AddAbility;
            AbilityManager.SpellRemoved += RemoveAbility;

        }
        public ActionManager(TeeUnit myUnit)
        {
            _myUnit = myUnit ?? throw new ArgumentNullException(nameof(myUnit));

        }
        private static void AddAbility(uint ownerHandle, TeeAbility ability)
        {
            var key = ownerHandle ^ (uint)ability.Id;
            if (_actionIds.TryGetValue(key, out var action))
            {
                action.Item1.Add(ability);
                action.Item2?.Invoke(ability);
            }
        }

        private static void RemoveAbility(uint ownerHandle, TeeAbility ability)
        {
            var key = ownerHandle ^ (uint)ability.Id;
            if (_actionIds.TryGetValue(key, out var action))
            {
                action.Item1.RemoveAll(a => a.Handle == ability.Handle);
                var lastAbility = action.Item1.LastOrDefault();
                action.Item2?.Invoke(lastAbility);
            }
        }
        public void Subscribe<T>(Action<T> action) where T : TeeAbility
        {
            if (_myUnit == null || action == null) return;

            if (!_abilityAttributesCache.TryGetValue(typeof(T), out var abilityAttribute))
            {
                abilityAttribute = typeof(T).GetCustomAttribute<AbilityAttribute>();
                if (abilityAttribute == null) return;
                _abilityAttributesCache[typeof(T)] = abilityAttribute;
            }


            var abilities = new List<TeeAbility>();

            abilities.AddRange(_myUnit.Inventory.MainItems.OfType<TeeAbility>());

            if (_myUnit.Inventory.NeutralItem is TeeAbility neutralItem)
                abilities.Add(neutralItem);

            if (_myUnit.Inventory.TownPortalScroll is TeeAbility townPortalScroll)
                abilities.Add(townPortalScroll);

            abilities.AddRange(_myUnit.Spellbook.Spells.OfType<TeeAbility>());

            var firstAbility = abilities.FirstOrDefault(a => a is T ability && a.Id == abilityAttribute.AbilityId);

            if (firstAbility is T typedAbility)
            {
                action.Invoke(typedAbility);
            }


            var key = _myUnit.Handle ^ (uint)abilityAttribute.AbilityId;
            _actionIds[key] = (abilities, obj => action?.Invoke(obj as T));
        }


        public void Unsubscribe<T>() where T : TeeItem
        {
            var itemAttribute = typeof(T).GetCustomAttributes(typeof(AbilityAttribute), false).FirstOrDefault() as AbilityAttribute;
            var id = itemAttribute?.AbilityId;

            if (id.HasValue)
            {
                _actionIds.Remove(_myUnit.Handle ^ (uint)itemAttribute.AbilityId);
            }
        }
        public void Dispose()
        {
            // Отписываемся от событий
            AbilityManager.ItemAdded -= AddAbility;
            AbilityManager.ItemRemoved -= RemoveAbility;
            AbilityManager.SpellAdded -= AddAbility;
            AbilityManager.SpellRemoved -= RemoveAbility;

            // Уведомляем всех подписчиков и очищаем все подписки
            foreach (var action in _actionIds.Values)
            {
                action.Item2?.Invoke(null);
            }
            _actionIds.Clear();

            // Обнуляем ссылку на _myUnit для предотвращения дальнейшего использования объекта
            _myUnit = null;
        }

    }
}
