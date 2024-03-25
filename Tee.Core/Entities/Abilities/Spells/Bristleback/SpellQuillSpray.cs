using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Spells.Bristleback
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.bristleback_quill_spray)]
    public class SpellQuillSpray : TeeSpell
    {
        public SpellQuillSpray(Divine.Entity.Entities.Abilities.Ability baseAbility) : base(baseAbility)
        {
        }
    }
}
