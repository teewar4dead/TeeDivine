using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Spells.Alchemist
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.alchemist_goblins_greed)]
    public class SpellGreevilsGreed : TeeSpell
    {
        public SpellGreevilsGreed(Divine.Entity.Entities.Abilities.Ability baseAbility) : base(baseAbility)
        {
        }
    }
}
