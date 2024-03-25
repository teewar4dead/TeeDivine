using Divine.Entity.Entities.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Spells.Bristleback
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.bristleback_viscous_nasal_goo)]
    public class SpellViscousNasalGoo : TeeSpell
    {
        public SpellViscousNasalGoo(Ability baseEntity) : base(baseEntity)
        {
        }
    }
}
