using Divine.Entity.Entities.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Spells.Axe
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.axe_counter_helix)]
    public class SpellCounterHelix : TeeSpell
    {
        public SpellCounterHelix(Ability baseAbility) : base(baseAbility)
        {

        }
    }
}
