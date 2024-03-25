using Divine.Entity.Entities.Abilities;
using Divine.Entity.Entities.Abilities.Items;
using Divine.Entity.Entities.Abilities.Spells;
using Tee.Core.Utilities;

namespace Tee.Core.Entities.Abilities
{
    public class TeeSpell : TeeAbility
    {
        public TeeSpell(Ability baseEntity) : base(baseEntity)
        {
        }
        /// <summary>
        /// Проверяет, скрыта ли способность.
        /// </summary>
        public bool IsHidden
        {
            get
            {
                return BaseAbility.IsHidden;
            }
        }
        /// <summary>
        /// Проверяет, была ли способность украдена.
        /// </summary>
        public bool IsStolen
        {
            get
            {
                return BaseAbility.IsStolen;
            }
        }
        /// <summary>
        /// Возвращает текущий уровень способности.
        /// </summary>
        public uint Level
        {
            get
            {
                return BaseAbility.Level;
            }
        }
        /// <summary>
        /// Проверяет, переключена ли способность.
        /// </summary>
        public bool IsToggled
        {
            get
            {
                return BaseAbility.IsToggled;
            }
        }
        /// <summary>
        /// Проверяет, заморожено ли время восстановления способности.
        /// </summary>
        public bool IsCooldownFrozen
        {
            get
            {
                return BaseAbility.IsCooldownFrozen;
            }
        }
        /// <summary>
        /// Проверяет, находится ли способность в фазе применения.
        /// </summary>
        public bool IsInAbilityPhase
        {
            get
            {
                return BaseAbility.IsInAbilityPhase;
            }
        }
        /// <summary>
        /// Проверяет, включен ли автокаст для этой способности.
        /// </summary>
        public bool IsAutoCastEnabled
        {
            get
            {
                return BaseAbility.IsAutoCastEnabled;
            }
        }
        /// <summary>
        /// Возвращает максимальный уровень способности.
        /// </summary>
        public int MaximumLevel
        {
            get
            {
                return BaseAbility.MaximumLevel;
            }
        }
        /// <summary>
        /// Возвращает, предоставляет ли способность Scepter.
        /// </summary>
        public bool IsGrantedByScepter
        {
            get
            {
                return BaseAbility.IsGrantedByScepter;
            }
        }
        /// <summary>
        /// Возвращает требуемый уровень для способности.
        /// </summary>
        public int RequiredLevel
        {
            get
            {
                return BaseAbility.RequiredLevel;
            }
        }
        /// <summary>
        /// Возвращает количество уровней между апгрейдами.
        /// </summary>
        public int LevelsBeetweenUpgrades
        {
            get
            {
                return BaseAbility.LevelsBeetweenUpgrades;
            }
        }

        public bool UseSpell()
        {
            return BaseAbility.Cast();
        }

    }
}
