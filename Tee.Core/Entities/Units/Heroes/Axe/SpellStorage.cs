using System;
using Tee.Core.Entities.Abilities.Spells.Axe;
using Tee.Core.Utilities;
using BaseSpellbook = Tee.Core.Entities.Components.Spellbook;

namespace Tee.Core.Entities.Units.Heroes.Axe
{
    public class SpellStorage
    {
        public SpellStorage(ActionManager actionManager)
        {
            actionManager.Subscribe<SpellBerserkersCall>(spell => SpellBerserkersCall = spell);
            actionManager.Subscribe<SpellCounterHelix>(spell => SpellCounterHelix = spell);
            actionManager.Subscribe<SpellBattleHunger>(spell => SpellBattleHunger = spell);
            actionManager.Subscribe<SpellCullingBlade>(spell => SpellCullingBlade = spell);
        }

        public SpellBerserkersCall? SpellBerserkersCall { get; private set; }
        public SpellCounterHelix? SpellCounterHelix { get; private set; }
        public SpellBattleHunger? SpellBattleHunger { get; private set; }
        public SpellCullingBlade? SpellCullingBlade { get; private set; }

    }
}
