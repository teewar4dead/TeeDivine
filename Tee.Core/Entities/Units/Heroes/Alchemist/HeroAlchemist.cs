using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tee.Core.Entities.Abilities.Spells.Alchemist;

namespace Tee.Core.Entities.Units.Heroes.Alchemist
{
    [Hero(Divine.Entity.Entities.Units.Heroes.Components.HeroId.npc_dota_hero_alchemist)]
    public class HeroAlchemist : TeeHero
    {


        public HeroAlchemist(Divine.Entity.Entities.Units.Heroes.Hero baseHero) : base(baseHero)
        {

        }
    }
}
