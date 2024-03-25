using Divine.Entity.Entities.Abilities.Spells;
using Tee.Core.Entities.Abilities;
using Tee.Core.Entities.Units;

namespace Tee.Core.Entities.Components
{
    public class Spellbook
    {
        protected readonly Divine.Entity.Entities.Units.Components.Spellbook baseSpellbook;
        protected readonly TeeUnit Owner;

        public Spellbook(Divine.Entity.Entities.Units.Components.Spellbook baseSpellbook)
        {
            this.baseSpellbook = baseSpellbook;
            Owner = (TeeUnit)baseSpellbook.Owner;
        }

        public bool IsValid => baseSpellbook.IsValid;

        public IEnumerable<TeeSpell> Spells => baseSpellbook.Spells.Select(x => (TeeSpell)x);
        public IEnumerable<TeeSpell> MainSpells => baseSpellbook.MainSpells.Select(x => (TeeSpell)x);
        public IEnumerable<TeeSpell> Talents => baseSpellbook.Talents.Select(x => (TeeSpell)x);
        public IEnumerable<TeeSpell> ConsumableItems => baseSpellbook.ConsumableItems.Select(x => (TeeSpell)x);

        public TeeSpell? Spell1 => (TeeSpell?)baseSpellbook.Spell1;
        public TeeSpell? Spell2 => (TeeSpell?)baseSpellbook.Spell2;
        public TeeSpell? Spell3 => (TeeSpell?)baseSpellbook.Spell3;
        public TeeSpell? Spell4 => (TeeSpell?)baseSpellbook.Spell4;
        public TeeSpell? Spell5 => (TeeSpell?)baseSpellbook.Spell5;
        public TeeSpell? Spell6 => (TeeSpell?)baseSpellbook.Spell6;
        public TeeSpell? HighFive => (TeeSpell?)baseSpellbook.HighFive;
    }
}
