using Tee.Core.Entities.Abilities.Spells.Alchemist;
using Tee.Core.Utilities;
using BaseSpellbook = Tee.Core.Entities.Components.Spellbook;

namespace Tee.Core.Entities.Units.Heroes.Alchemist
{
    public class Spellbook : BaseSpellbook
    {
        public SpellAcidSpray? SpellAcidSpray { get; private set; }
        public SpellBerserkPotion? SpellBerserkPotion { get; private set; }
        public SpellChemicalRage? SpellChemicalRage { get;  private set; }
        public SpellCorrosiveWeaponry? SpellCorrosiveWeaponry { get; private set; }
        public SpellGreevilsGreed? SpellGreevilsGreed { get; private set; }
        public SpellUnstableConcoction? SpellUnstableConcoction { get; private set; }
        public SpellUnstableConcoctionThrow? SpellUnstableConcoctionThrow { get; private set; }
        public Spellbook(Divine.Entity.Entities.Units.Components.Spellbook baseSpellbook) : base(baseSpellbook)
        {
        }
        public void Subscribe()
        {
            //var ActionManager = new SpellActionManager(Owner);

            //ActionManager.Subscribe<SpellAcidSpray>(spell => SpellAcidSpray = spell);
            //ActionManager.Subscribe<SpellBerserkPotion>(spell => SpellBerserkPotion = spell);
            //ActionManager.Subscribe<SpellChemicalRage>(spell => SpellChemicalRage = spell);
            //ActionManager.Subscribe<SpellCorrosiveWeaponry>(spell => SpellCorrosiveWeaponry = spell);
            //ActionManager.Subscribe<SpellGreevilsGreed>(spell => SpellGreevilsGreed = spell);
            //ActionManager.Subscribe<SpellUnstableConcoction>(spell => SpellUnstableConcoction = spell);
            //ActionManager.Subscribe<SpellUnstableConcoctionThrow>(spell => SpellUnstableConcoctionThrow = spell);
        }
    }
}
