using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Spells.Axe
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.axe_battle_hunger)]
    public class SpellBattleHunger : TeeSpell
    {
        public SpellBattleHunger(Divine.Entity.Entities.Abilities.Ability baseAbility) : base(baseAbility)
        {
        }
    }
}
