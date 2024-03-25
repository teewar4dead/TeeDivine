using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Spells.Bristleback
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.bristleback_warpath)]
    public class SpellWarpath : TeeSpell
    {
        public SpellWarpath(Divine.Entity.Entities.Abilities.Ability baseAbility) : base(baseAbility)
        {
        }
    }
}
 