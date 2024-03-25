using Divine.Entity;
using Divine.Entity.Entities;
using Divine.Entity.Entities.Components;
using Divine.Entity.Entities.PhysicalItems;
using Divine.Entity.Entities.Players;
using Divine.Entity.Entities.Runes;
using Divine.Entity.Entities.Units;
using Divine.Entity.Entities.Units.Components;
using Divine.Extensions;
using Divine.Game;
using Divine.Modifier.Modifiers;
using Divine.Numerics;
using System.Reflection;
using Tee.Core.Entities.Abilities;
using Tee.Core.Entities.Components;
using Tee.Core.Utilities;
using Tee.Entities;

namespace Tee.Core.Entities.Units
{
    public class TeeUnit : TeeEntity
    {
        public Unit BaseUnit;
        private Lazy<Components.Inventory> _lazyInventory;
        private Lazy<Components.Spellbook> _lazySpellbook;
        public TeeUnit(Unit baseEntity) : base(baseEntity)
        {
            _lazyInventory = new Lazy<Components.Inventory>(() => new Components.Inventory(BaseUnit.Inventory));
            _lazySpellbook = new Lazy<Components.Spellbook>(() => new Components.Spellbook(BaseUnit.Spellbook));

            BaseUnit = baseEntity;
        }
        //Extensions
        public bool IsAlly
        {
            get
            {
                return BaseUnit.Team == EntityManager.LocalPlayer.Team;
            }
        }
        public bool IsEnemy
        {
            get
            {
                return BaseUnit.Team != EntityManager.LocalPlayer.Team;
            }
        }
        public bool IsStunned
        {
            get
            {
                return (BaseUnit.UnitState & UnitState.Stunned) == UnitState.Stunned;
            }
        }
        public bool IsMuted
        {
            get
            {
                return (BaseUnit.UnitState & UnitState.Muted) == UnitState.Muted;
            }
        }
        public bool IsHexed
        {
            get
            {
                return (BaseUnit.UnitState & UnitState.Hexed) == UnitState.Hexed;
            }
        }
        public bool IsInvulnerable
        {
            get
            {
                return (BaseUnit.UnitState & UnitState.Invulnerable) == UnitState.Invulnerable;
            }
        }
        public bool IsSilenced
        {
            get
            {
                return (BaseUnit.UnitState & UnitState.Silenced) == UnitState.Silenced;
            }
        }
        public bool IsAttackImmune
        {
            get
            {
                return (BaseUnit.UnitState & UnitState.AttackImmune) == UnitState.AttackImmune;
            }
        }
        public bool IsMagicImmune
        {
            get
            {
                return (BaseUnit.UnitState & UnitState.MagicImmune) == UnitState.MagicImmune;
            }
        }

        public bool IsDisarmed
        {
            get
            {
                return (BaseUnit.UnitState & UnitState.Disarmed) == UnitState.Disarmed;
            }
        }
        public bool IsInvisible
        {
            get
            {
                return (BaseUnit.UnitState & UnitState.Invisible) == UnitState.Invisible;
            }
        }
        public bool IsRooted
        {
            get
            {
                return (BaseUnit.UnitState & UnitState.Rooted) == UnitState.Rooted;
            }
        }
        public bool HasModifier(string modifierName)
        {
            foreach (var modifier in BaseUnit.Modifiers)
            {
                if (modifier.Name == modifierName)
                {
                    return true;
                }
            }
            return false;
        }

        public Vector2 GetVector2FromPolarAngle(float delta = 0f, float radial = 1f)
        {
            float num = MathUtil.DegreesToRadians(this.RotationDifference);
            float num2 = this.NetworkRotationRad + num;
            return GetFromPolarCoordinates(radial, num2 + delta);
        }

        public Vector3 GetVector3FromPolarAngle(float delta = 0f, float radial = 1f)
        {
            return GetVector2FromPolarAngle(delta, radial).ToVector3();
        }

        public Vector2 GetFromPolarCoordinates(float radial, float polar)
        {
            return new Vector2((float)Math.Cos(polar) * radial, (float)Math.Sin(polar) * radial);
        }
        public Vector3 Direction(float length = 1f)
        {
            float networkRotationRad = this.NetworkRotationRad;
            return new Vector3((float)Math.Cos(networkRotationRad) * length, (float)Math.Sin(networkRotationRad) * length, this.Position.Z);
        }

        public Vector2 Direction2D(float length = 1f)
        {
            float networkRotationRad = this.NetworkRotationRad;
            return new Vector2((float)Math.Cos(networkRotationRad) * length, (float)Math.Sin(networkRotationRad) * length);
        }








        public Components.Spellbook Spellbook => _lazySpellbook.Value;
        public Components.Inventory Inventory => _lazyInventory.Value;
        public ModifierStatus ModifierStatus => BaseUnit.ModifierStatus;
        public IEnumerable<Modifier> Modifiers => BaseUnit.Modifiers;
        public TeeUnit? Target => (TeeUnit)BaseUnit.Target;
        public float LastVisibleTime => BaseUnit.LastVisibleTime;
        public bool IsDeniable => BaseUnit.IsDeniable;
        public string SoundSet => BaseUnit.SoundSet;
        public string Label => BaseUnit.Label;
        public bool IsPhantom => BaseUnit.IsPhantom;
        public int UnitType => BaseUnit.UnitType;
        public uint Level => BaseUnit.Level;
        public bool IsAncient => BaseUnit.IsAncient;
        public bool HasStolenScepter => BaseUnit.HasStolenScepter;
        public bool IsNeutral => BaseUnit.IsNeutral;
        public bool HasSharedAbilities => BaseUnit.HasSharedAbilities;
        public bool IsSummoned => BaseUnit.IsSummoned;
        public bool IsDominatable => BaseUnit.IsDominatable;
        public bool HasUpgradeableAbilities => BaseUnit.HasUpgradeableAbilities;
        public float HealthRegeneration => BaseUnit.HealthRegeneration;
        public float BaseHealthRegeneration => BaseUnit.BaseHealthRegeneration;
        public bool IsControllable => BaseUnit.IsControllable;
        public uint AttackRange => BaseUnit.AttackRange;
        public float MovementSpeed => BaseUnit.MovementSpeed;
        public float BaseMovementSpeed => BaseUnit.BaseMovementSpeed;
        public float BaseAttackTime => BaseUnit.BaseAttackTime;
        public int HealthBarOffset => BaseUnit.HealthBarOffset;
        public float Mana => BaseUnit.Mana;
        public float MaximumMana => BaseUnit.MaximumMana;
        public float ManaRegeneration => BaseUnit.ManaRegeneration;
        public float BaseManaRegeneration => BaseUnit.BaseManaRegeneration;
        public uint BKBChargesUsed => BaseUnit.BKBChargesUsed;
        public virtual bool IsIllusion => BaseUnit.IsIllusion;
        public float InvisiblityLevel => BaseUnit.InvisiblityLevel;
        public float HullRadius => BaseUnit.HullRadius;
        public float CollisionPadding => BaseUnit.CollisionPadding;
        public float RingRadius => BaseUnit.RingRadius;
        public float ProjectileCollisionSize => BaseUnit.ProjectileCollisionSize;
        public float TauntCooldown => BaseUnit.TauntCooldown;
        public ShopType ActiveShop => BaseUnit.ActiveShop;
        public uint DayVision => BaseUnit.DayVision;
        public uint NightVision => BaseUnit.NightVision;
        public uint Vision => BaseUnit.Vision;
        public int MinimumDamage => BaseUnit.MinimumDamage;
        public int MaximumDamage => BaseUnit.MaximumDamage;
        public int BonusDamage => BaseUnit.BonusDamage;
        public float BonusCastRange => BaseUnit.BonusCastRange;
        public UnitState UnitState => BaseUnit.UnitState;
        public UnitState DebuffState => BaseUnit.DebuffState;
        public bool HasInventory => BaseUnit.HasInventory;
        public AttackCapability AttackCapability => BaseUnit.AttackCapability;
        public MoveCapability MoveCapability => BaseUnit.MoveCapability;
        public string MinimapIcon => BaseUnit.MinimapIcon;
        public float MinimapIconSize => BaseUnit.MinimapIconSize;
        public float DeathTime => BaseUnit.DeathTime;
        public bool HasBaseStatsChanged => BaseUnit.HasBaseStatsChanged;
        public float MagicalDamageResistance => BaseUnit.MagicalDamageResistance;
        public bool IsWaitingToSpawn => BaseUnit.IsWaitingToSpawn;
        public ulong TotalDamageTaken => BaseUnit.TotalDamageTaken;
        public bool HasArcana => BaseUnit.HasArcana;
        public NetworkActivity NetworkActivity => BaseUnit.NetworkActivity;
        public bool IsMoving => BaseUnit.IsMoving;
        public ShopFlags AvailableShops => BaseUnit.AvailableShops;
        public float RotationDifference => BaseUnit.RotationDifference;
        public int DamageAverage => BaseUnit.DamageAverage;
        public virtual float PhysicalDamageResistance => BaseUnit.PhysicalDamageResistance;
        public float StatusResistance => BaseUnit.StatusResistance;
        public bool IsMelee => BaseUnit.IsMelee;
        public bool IsRanged => BaseUnit.IsRanged;
        public bool IsSpawned => BaseUnit.IsSpawned;
        public bool IsVisibleToEnemies => BaseUnit.IsVisibleToEnemies;
        public bool PredictionIsVisibleToEnemies => BaseUnit.PredictionIsVisibleToEnemies;
        public float AttackSpeed => BaseUnit.AttackSpeed;
        public float AttacksPerSecond => BaseUnit.AttacksPerSecond;
        public float SecondsPerAttack => BaseUnit.SecondsPerAttack;
        public virtual float Armor => BaseUnit.Armor;
        public virtual float BaseArmor => BaseUnit.BaseArmor;
        public virtual float BonusArmor => BaseUnit.BonusArmor;
        public static KeyValue? GetKeyValueByName(string name) => Unit.GetKeyValueByName(name);
        public bool IsControllableByPlayer(Player player) => BaseUnit.IsControllableByPlayer(player);
        public bool Move(Vector3 position) => BaseUnit.Move(position);
        public bool Move(Vector3 position, bool queued) => BaseUnit.Move(position, queued);
        public bool Move(Vector3 position, bool queued, bool bypassOrderAdding) => BaseUnit.Move(position, queued, bypassOrderAdding);
        public bool MoveToDirection(Vector3 position) => BaseUnit.MoveToDirection(position);
        public bool MoveToDirection(Vector3 position, bool queued) => BaseUnit.MoveToDirection(position, queued);
        public bool Patrol(Vector3 position) => BaseUnit.Patrol(position);
        public bool Patrol(Vector3 position, bool queued) => BaseUnit.Patrol(position, queued);
        public bool Attack(Vector3 position) => BaseUnit.Attack(position);
        public bool Attack(Vector3 position, bool queued) => BaseUnit.Attack(position, queued);
        public bool Attack(TeeUnit target) => BaseUnit.Attack(target.BaseUnit);
        public bool Attack(TeeUnit target, bool queued) => BaseUnit.Attack(target.BaseUnit, queued);
        public bool Attack(PhysicalItem target) => BaseUnit.Attack(target);
        public bool Attack(PhysicalItem target, bool queued) => BaseUnit.Attack(target, queued);
        public bool Hold() => BaseUnit.Hold();
        public bool Hold(bool queued) => BaseUnit.Hold(queued);
        public bool Stop() => BaseUnit.Stop();
        public bool Stop(bool queued) => BaseUnit.Stop(queued);
        public bool Stop(bool queued, bool bypassOrderAdding) => BaseUnit.Stop(queued, bypassOrderAdding);
        public bool Follow(TeeUnit target) => BaseUnit.Follow(target.BaseUnit);
        public bool Follow(TeeUnit target, bool queued) => BaseUnit.Follow(target.BaseUnit, queued);
        public bool PickUp(PhysicalItem target) => BaseUnit.PickUp(target);
        public bool PickUp(PhysicalItem target, bool queued) => BaseUnit.PickUp(target, queued);
        public bool PickUp(Rune target) => BaseUnit.PickUp(target);
        public bool PickUp(Rune target, bool queued) => BaseUnit.PickUp(target, queued);
        public bool Drop(TeeItem item, Vector3 position) => BaseUnit.Drop(item.BaseItem, position);
        public bool Drop(TeeItem item, Vector3 position, bool queued) => BaseUnit.Drop(item.BaseItem, position, queued);
        public bool Give(TeeItem item, TeeUnit target) => BaseUnit.Give(item.BaseItem, target.BaseUnit);
        public bool Give(TeeItem item, TeeUnit target, bool queued) => BaseUnit.Give(item.BaseItem, target.BaseUnit, queued);

    }
}
