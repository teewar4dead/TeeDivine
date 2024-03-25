using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Neutrals
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_spell_prism)]
    public class ItemSpellPrism : TeeItem
    {
        public ItemSpellPrism(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}