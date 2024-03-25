using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Spells.Alchemist
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.alchemist_corrosive_weaponry)]
    public class SpellCorrosiveWeaponry : TeeSpell
    {
        public SpellCorrosiveWeaponry(Divine.Entity.Entities.Abilities.Ability baseAbility) : base(baseAbility)
        {
        }
    }
}
