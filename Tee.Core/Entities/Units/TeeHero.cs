using Divine.Entity.Entities.Players;
using Divine.Entity.Entities.Units;
using Divine.Entity.Entities.Units.Heroes;
using Divine.Entity.Entities.Units.Heroes.Components;
using Divine.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tee.Core.Entities.Abilities;
using Tee.Core.Utilities;

namespace Tee.Core.Entities.Units
{
    public class TeeHero : TeeUnit
    {

        public Hero BaseHero;
        public TeeHero(Hero baseEntity) : base(baseEntity)
        {
            BaseHero = baseEntity;
        }

        public uint CurrentXP
        {
            get
            {
                return BaseHero.CurrentXP;
            }
        }
        public uint AbilityPoints
        {
            get
            {
                return BaseHero.AbilityPoints;
            }
        }
        public float RespawnTime
        {
            get
            {
                return BaseHero.RespawnTime;
            }
        }
        public float RespawnTimePenalty
        {
            get
            {
                return BaseHero.RespawnTimePenalty;
            }
        }
        public float Strength
        {
            get
            {
                return BaseHero.Strength;
            }
        }
        public float Agility
        {
            get
            {
                return BaseHero.Agility;
            }
        }
        public float Intelligence
        {
            get
            {
                return BaseHero.Intelligence;
            }
        }
        public float TotalStrength
        {
            get
            {
                return BaseHero.TotalStrength;
            }
        }
        public float TotalAgility
        {
            get
            {
                return BaseHero.TotalAgility;
            }
        }
        public float TotalIntelligence
        {
            get
            {
                return BaseHero.TotalIntelligence;
            }
        }
        public override float PhysicalDamageResistance
        {
            get
            {
                return BaseHero.PhysicalDamageResistance;
            }
        }
        public override float Armor
        {
            get
            {
                return BaseHero.Armor;
            }
        }
        public override float BaseArmor
        {
            get
            {
                return BaseHero.BaseArmor;
            }
        }
        public override float BonusArmor
        {
            get
            {
                return BaseHero.BonusArmor;
            }
        }
        public int RecentDamage
        {
            get
            {
                return BaseHero.RecentDamage;
            }
        }
        public Player? Player
        {
            get
            {
                return BaseHero.Player;
            }
        }
        public TeeHero? ReplicateFrom
        {
            get
            {
                return BaseHero.ReplicateFrom == null ? null : new TeeHero(BaseHero.ReplicateFrom);
            }
        }
        public bool IsReincarnating
        {
            get
            {
                return BaseHero.IsReincarnating;
            }
        }
        public float SpawnedAt
        {
            get
            {
                return BaseHero.SpawnedAt;
            }
        }
        public Divine.Entity.Entities.Units.Heroes.Components.Attribute PrimaryAttribute
        {
            get
            {
                return BaseHero.PrimaryAttribute;
            }
        }
        public bool IsBuybackDisabled
        {
            get
            {
                return BaseHero.IsBuybackDisabled;
            }
        }
        public override bool IsIllusion
        {
            get
            {
                return BaseHero.IsIllusion;
            }
        }
        public HeroId HeroId
        {
            get
            {
                return BaseHero.HeroId;
            }
        }
        public float LastHurtTime
        {
            get
            {
                return BaseHero.LastHurtTime;
            }
        }
    }
}
