using Divine.Entity.Entities.Abilities;
using Divine.Entity.Entities.Abilities.Components;
using Divine.Entity.Entities.Components;
using Divine.Entity.Entities.Runes;
using Divine.Entity.Entities.Trees;
using Divine.Entity.Entities.Units;
using Divine.Game;
using Divine.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tee.Core.Entities.Units;
using Tee.Entities;

namespace Tee.Core.Entities.Abilities
{
    public class TeeAbility : TeeEntity
    {
        public Ability BaseAbility { get; }
        public bool IsOnCooldown
        {
            get
            {
                return this.Cooldown > 0;
            }
        }
        public TeeAbility(Ability baseEntity) : base(baseEntity)
        {
            BaseAbility = baseEntity;
        }
        /// <summary>
        /// Проверяет, имеет ли способность альтернативное состояние применения.
        /// </summary>
        public bool HasAltCastState
        {
            get
            {
                return BaseAbility.HasAltCastState;
            }
        }
        /// <summary>
        /// Возвращает уровень врага, нацеленного этой способностью.
        /// </summary>
        public int EnemyLevel
        {
            get
            {
                return BaseAbility.EnemyLevel;
            }
        }
        /// <summary>
        /// Определяет, синхронизируется ли информация о способности между сервером и клиентами.
        /// </summary>
        public bool IsReplicated
        {
            get
            {
                return BaseAbility.IsReplicated;
            }
        }

        /// <summary>
        /// Проверяет, активирована ли способность.
        /// </summary>
        public bool IsActivated
        {
            get
            {
                return BaseAbility.IsActivated;
            }
        }

        /// <summary>
        /// Возвращает текущее время восстановления способности.
        /// </summary>
        public float Cooldown
        {
            get
            {
                return BaseAbility.Cooldown;
            }
        }
        /// <summary>
        /// Возвращает время восстановления способности, когда она в тумане войны.
        /// </summary>
        public float CooldownInFog
        {
            get
            {
                return BaseAbility.CooldownInFog;
            }
        }

        /// <summary>
        /// Возвращает полную длительность времени восстановления способности.
        /// </summary>
        public float CooldownLength
        {
            get
            {
                return BaseAbility.CooldownLength;
            }
        }

        /// <summary>
        /// Возвращает стоимость маны для использования способности.
        /// </summary>
        public int ManaCost
        {
            get
            {
                return BaseAbility.ManaCost;
            }
        }

        /// <summary>
        /// Возвращает продолжительность времени, необходимого для полного "заряда" или активации способности.
        /// </summary>
        public float ChannelTime
        {
            get
            {
                return BaseAbility.ChannelTime;
            }
        }

        /// <summary>
        /// Проверяет, находится ли способность в неопределенном состоянии восстановления.
        /// </summary>
        public bool IsInIndefiniteCooldown
        {
            get
            {
                return BaseAbility.IsInIndefiniteCooldown;
            }
        }

        /// <summary>
        /// Не знаю что это, но оно нужно.
        /// </summary>
        public float OverrideCastPoint
        {
            get
            {
                return BaseAbility.OverrideCastPoint;
            }
        }

        /// <summary>
        /// Возвращает время последнего клика для применения способности.
        /// </summary>
        public float LastCastClickTime
        {
            get
            {
                return BaseAbility.LastCastClickTime;
            }
        }

        /// <summary>
        /// Возвращает время начала канализации способности.
        /// </summary>
        public float ChannelStartTime
        {
            get
            {
                return BaseAbility.ChannelStartTime;
            }
        }

        /// <summary>
        /// Возвращает оставшееся время восстановления зарядов для этой способности.
        /// </summary>
        public float ChargeRestoreTimeRemaining
        {
            get
            {
                return BaseAbility.ChargeRestoreTimeRemaining;
            }
        }
        /// <summary>
        /// Возвращает текущее количество зарядов способности.
        /// </summary>
        public virtual uint CurrentCharges
        {
            get
            {
                return BaseAbility.CurrentCharges;
            }
        }

        /// <summary>
        /// Возвращает время начала применения способности.
        /// </summary>
        public float CastStartTime
        {
            get
            {
                return BaseAbility.CastStartTime;
            }
        }

        /// <summary>
        /// Возвращает имя текстуры для способности.
        /// </summary>
        public string TextureName
        {
            get
            {
                return BaseAbility.TextureName;
            }
        }

        /// <summary>
        /// Возвращает имя общего восстановления для способности.
        /// </summary>
        public string SharedCooldownName
        {
            get
            {
                return BaseAbility.SharedCooldownName;
            }
        }

        /// <summary>
        /// Возвращает текущую сетевую активность способности.
        /// </summary>
        public NetworkActivity NetworkActivity
        {
            get
            {
                return BaseAbility.NetworkActivity;
            }
        }

        /// <summary>
        /// Возвращает ID способности.
        /// </summary>
        public AbilityId Id
        {
            get
            {
                return BaseAbility.Id;
            }
        }

        /// <summary>
        /// Возвращает тип способности.
        /// </summary>
        public AbilityType AbilityType
        {
            get
            {
                return BaseAbility.AbilityType;
            }
        }

        /// <summary>
        /// Возвращает поведение способности.
        /// </summary>
        public AbilityBehavior AbilityBehavior
        {
            get
            {
                return BaseAbility.AbilityBehavior;
            }
        }

        /// <summary>
        /// Возвращает тип целевой команды для способности.
        /// </summary>
        public TargetTeamType TargetTeamType
        {
            get
            {
                return BaseAbility.TargetTeamType;
            }
        }

        /// <summary>
        /// Возвращает флаги цели для способности.
        /// </summary>
        public TargetFlags TargetFlags
        {
            get
            {
                return BaseAbility.TargetFlags;
            }
        }

        /// <summary>
        /// Возвращает тип цели для способности.
        /// </summary>
        public TargetType TargetType
        {
            get
            {
                return BaseAbility.TargetType;
            }
        }

        /// <summary>
        /// Возвращает тип урона, который наносит способность.
        /// </summary>
        public DamageType DamageType
        {
            get
            {
                return BaseAbility.DamageType;
            }
        }

        /// <summary>
        /// Возвращает тип проникновения иммунитета для способности.
        /// </summary>
        public SpellPierceImmunityType SpellPierceImmunityType
        {
            get
            {
                return BaseAbility.SpellPierceImmunityType;
            }
        }

        /// <summary>
        /// Возвращает тип диспелла для способности.
        /// </summary>
        public DispellableType DispellableType
        {
            get
            {
                return BaseAbility.DispellableType;
            }
        }

        /// <summary>
        /// Возвращает индекс способности.
        /// </summary>
        public ushort AbilityIndex
        {
            get
            {
                return BaseAbility.AbilityIndex;
            }
        }

        /// <summary>
        /// Возвращает индекс нейтрального уровня.
        /// </summary>
        public int NeutralTierIndex
        {
            get
            {
                return BaseAbility.NeutralTierIndex;
            }
        }

        /// <summary>
        /// Возвращает KeyValue для способности.
        /// </summary>
        public KeyValue? KeyValue
        {
            get
            {
                return BaseAbility.KeyValue;
            }
        }

        /// <summary>
        /// Возвращает текущее состояние способности.
        /// </summary>
        public AbilityState AbilityState
        {
            get
            {
                return BaseAbility.AbilityState;
            }
        }

        /// <summary>
        /// Возвращает данные способности.
        /// </summary>
        public AbilityData? AbilityData
        {
            get
            {
                return BaseAbility.AbilityData;
            }
        }

        /// <summary>
        /// Возвращает специальные данные для способности.
        /// </summary>
        public IEnumerable<AbilitySpecialData> AbilitySpecialData
        {
            get
            {
                return BaseAbility.AbilitySpecialData;
            }
        }

        /// <summary>
        /// Определяет, активируется ли способность с задержкой времени, и не может ли персонаж выполнять другие действия в это время.
        /// </summary>
        public bool IsChanneling
        {
            get
            {
                return BaseAbility.IsChanneling;
            }
        }

        /// <summary>
        /// Возвращает слот способности.
        /// </summary>
        public AbilitySlot AbilitySlot
        {
            get
            {
                return BaseAbility.AbilitySlot;
            }
        }

        /// <summary>
        /// Возвращает точку применения способности.
        /// </summary>
        public float CastPoint
        {
            get
            {
                return BaseAbility.CastPoint;
            }
        }

        /// <summary>
        /// Возвращает максимальное время, на протяжении которого персонаж должен активировать способность без прерываний.
        /// </summary>
        public float ChannelMaximumTime
        {
            get
            {
                return BaseAbility.ChannelMaximumTime;
            }
        }

        /// <summary>
        /// Возвращает урон от способности.
        /// </summary>
        public int Damage
        {
            get
            {
                return BaseAbility.Damage;
            }
        }

        /// <summary>
        /// Возвращает диапазон применения способности.
        /// </summary>
        public float CastRange
        {
            get
            {
                return BaseAbility.CastRange;
            }
        }

        /// <summary>
        /// Возвращает базовый диапазон применения способности.
        /// </summary>
        public float BaseCastRange
        {
            get
            {
                return BaseAbility.BaseCastRange;
            }
        }

        /// <summary>
        /// Возвращает продолжительность способности.
        /// </summary>
        public float Duration
        {
            get
            {
                return BaseAbility.Duration;
            }
        }

        /// <summary>
        /// Возвращает количество зарядов способности.
        /// </summary>
        public int Charges
        {
            get
            {
                return BaseAbility.Charges;
            }
        }

        /// <summary>
        /// Возвращает время восстановления заряда.
        /// </summary>
        public float ChargeRestoreTime
        {
            get
            {
                return BaseAbility.ChargeRestoreTime;
            }
        }

        /// <summary>
        /// Получает KeyValue по ID способности.
        /// </summary>
        /// <param name="abilityId">ID способности.</param>
        /// <returns>KeyValue способности.</returns>
        public static KeyValue? GetKeyValueById(AbilityId abilityId)
        {
            return Ability.GetKeyValueById(abilityId);
        }

        /// <summary>
        /// Получает KeyValue по имени способности.
        /// </summary>
        /// <param name="name">Имя способности.</param>
        /// <returns>KeyValue способности.</returns>
        public static KeyValue? GetKeyValueByName(string name)
        {
            return Ability.GetKeyValueByName(name);
        }

        /// <summary>
        /// Получает данные способности по индексу.
        /// </summary>
        /// <param name="abilityIndex">Индекс способности.</param>
        /// <returns>Данные способности.</returns>
        public static AbilityData? GetAbilityDataByIndex(ushort abilityIndex)
        {
            return Ability.GetAbilityDataByIndex(abilityIndex);
        }

        /// <summary>
        /// Получает данные способности по ID.
        /// </summary>
        /// <param name="abilityId">ID способности.</param>
        /// <returns>Данные способности.</returns>
        public static AbilityData? GetAbilityDataById(AbilityId abilityId)
        {
            return Ability.GetAbilityDataById(abilityId);
        }

        /// <summary>
        /// Получает данные способности по имени.
        /// </summary>
        /// <param name="name">Имя способности.</param>
        /// <returns>Данные способности.</returns>
        public static AbilityData? GetAbilityDataByName(string name)
        {
            return Ability.GetAbilityDataByName(name);
        }

        /// <summary>
        /// Получает индекс способности по ID.
        /// </summary>
        /// <param name="abilityId">ID способности.</param>
        /// <returns>Индекс способности.</returns>
        public static ushort GetAbilityIndexById(AbilityId abilityId)
        {
            return Ability.GetAbilityIndexById(abilityId);
        }

        /// <summary>
        /// Получает индекс способности по имени.
        /// </summary>
        /// <param name="name">Имя способности.</param>
        /// <returns>Индекс способности.</returns>
        public static ushort GetAbilityIndexByName(string name)
        {
            return Ability.GetAbilityIndexByName(name);
        }

        /// <summary>
        /// Получает ID способности по имени.
        /// </summary>
        /// <param name="name">Имя способности.</param>
        /// <returns>ID способности.</returns>
        public static AbilityId GetAbilityIdByName(string name)
        {
            return Ability.GetAbilityIdByName(name);
        }

        /// <summary>
        /// Получает имя способности по ID.
        /// </summary>
        /// <param name="abilityId">ID способности.</param>
        /// <returns>Имя способности.</returns>
        public static string GetAbilityNameById(AbilityId abilityId)
        {
            return Ability.GetAbilityNameById(abilityId);
        }

        protected virtual bool UseAbility()
        {
            return BaseAbility.Cast();
        }
        protected virtual bool UseAbility(bool queued)
        {
            return BaseAbility.Cast(queued);
        }
        protected virtual bool UseAbility(bool queued, bool bypassOrderAdding)
        {
            return BaseAbility.Cast(queued, bypassOrderAdding);
        }
        protected virtual bool UseAbility(Vector3 position)
        {
            return BaseAbility.Cast(position);
        }
        protected virtual bool UseAbility(Vector3 position, bool queued)
        {
            return BaseAbility.Cast(position, queued);
        }
        protected virtual bool UseAbility(Vector3 position, bool queued, bool bypassOrderAdding)
        {
            return BaseAbility.Cast(position, queued, bypassOrderAdding);
        }
        protected virtual bool UseAbility(Vector3 startPosition, Vector3 endPosition)
        {
            return BaseAbility.Cast(startPosition, endPosition);
        }
        protected virtual bool UseAbility(Vector3 startPosition, Vector3 endPosition, bool queued)
        {
            return BaseAbility.Cast(startPosition, endPosition, queued);
        }
        protected virtual bool UseAbility(Vector3 startPosition, Vector3 endPosition, bool queued, bool bypassOrderAdding)
        {
            return BaseAbility.Cast(startPosition, endPosition, queued, bypassOrderAdding);
        }
        protected virtual bool UseAbility(TeeUnit target)
        {
            return BaseAbility.Cast(target.BaseUnit);
        }
        protected virtual bool UseAbility(TeeUnit target, bool queued)
        {
            return BaseAbility.Cast(target.BaseUnit, queued);
        }
        protected virtual bool UseAbility(TeeUnit target, bool queued, bool bypassOrderAdding)
        {
            return BaseAbility.Cast(target.BaseUnit, queued, bypassOrderAdding);
        }
        protected virtual bool UseAbility(TeeUnit startTarget, Vector3 endPosition)
        {
            return BaseAbility.Cast(startTarget.BaseUnit, endPosition);
        }
        protected virtual bool UseAbility(TeeUnit startTarget, Vector3 endPosition, bool queued)
        {
            return BaseAbility.Cast(startTarget.BaseUnit, endPosition, queued);
        }
        protected virtual bool UseAbility(TeeUnit startTarget, Vector3 endPosition, bool queued, bool bypassOrderAdding)
        {
            return BaseAbility.Cast(startTarget.BaseUnit, endPosition, queued, bypassOrderAdding);
        }
        protected virtual bool UseAbility(Rune target)
        {
            return BaseAbility.Cast(target);
        }
        protected virtual bool UseAbility(Rune target, bool queued)
        {
            return BaseAbility.Cast(target, queued);
        }
        protected virtual bool UseAbility(Rune target, bool queued, bool bypassOrderAdding)
        {
            return BaseAbility.Cast(target, queued, bypassOrderAdding);
        }
        protected virtual bool UseAbility(Tree target)
        {
            return BaseAbility.Cast(target);
        }
        protected virtual bool UseAbility(Tree target, bool queued)
        {
            return BaseAbility.Cast(target, queued);
        }
        protected virtual bool UseAbility(Tree target, bool queued, bool bypassOrderAdding)
        {
            return BaseAbility.Cast(target, queued, bypassOrderAdding);
        }
        protected virtual bool CastToggle()
        {
            return BaseAbility.CastToggle();
        }
        protected virtual bool CastToggle(bool queued)
        {
            return BaseAbility.CastToggle(queued);
        }
        protected virtual bool CastToggle(bool queued, bool bypassOrderAdding)
        {
            return BaseAbility.CastToggle(queued, bypassOrderAdding);
        }
        protected virtual bool CastToggleAutocast()
        {
            return BaseAbility.CastToggleAutocast();
        }
        protected virtual bool Upgrade()
        {
            return BaseAbility.Upgrade();
        }
        protected virtual bool Announce()
        {
            return BaseAbility.Announce();
        }


        public virtual string ParticlePatch { get; set; }
        public virtual string TargetDebuff { get; set; }
        public virtual string TargetBuff { get; set; }
        public virtual string TargetPointDebuff { get; set; }
        public virtual string AttackTargetDebuff { get; set; }
        public virtual string SelfBuff { get; set; }
        public virtual string AuraBuff { get; set; }
        public virtual string AuraDebuff { get; set; }
        public virtual string AreaDebuff { get; set; }
    }
}
