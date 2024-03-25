using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Spells.Axe
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.axe_culling_blade)]
    public class SpellCullingBlade : TeeSpell
    {
        public SpellCullingBlade(Divine.Entity.Entities.Abilities.Ability baseAbility) : base(baseAbility)
        {
        }
    }
}
