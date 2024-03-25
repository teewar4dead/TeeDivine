using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tee.Core.Entities.Abilities.Spells.Bristleback;
using Tee.Core.Utilities;
using BaseSpellbook = Tee.Core.Entities.Components.Spellbook;

namespace Tee.Core.Entities.Units.Heroes.Bristleback
{
    public class Spellbook : BaseSpellbook
    {

        public SpellViscousNasalGoo? SpellViscousNasalGoo { get; private set; }
        public SpellQuillSpray? SpellQuillSpray { get; private set; }
        public SpellBristleback? SpellBristleback { get; private set; }
        public SpellHairball? SpellHairball { get; private set; }
        public SpellWarpath? SpellWarpath { get; private set; }

        public Spellbook(Divine.Entity.Entities.Units.Components.Spellbook baseSpellbook) : base(baseSpellbook)
        {
        }

        public void Subscribe()
        {
            //var ActionManager = new SpellActionManager((TeeUnit)baseSpellbook.Owner);

            //ActionManager.Subscribe<SpellBristleback>(spell => SpellBristleback = spell);
            //ActionManager.Subscribe<SpellHairball>(spell => SpellHairball = spell);
            //ActionManager.Subscribe<SpellQuillSpray>(spell => SpellQuillSpray = spell);
            //ActionManager.Subscribe<SpellViscousNasalGoo>(spell => SpellViscousNasalGoo = spell);
            //ActionManager.Subscribe<SpellWarpath>(spell => SpellWarpath = spell);
        }
    }
}
