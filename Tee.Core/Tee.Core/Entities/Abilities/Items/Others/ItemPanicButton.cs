using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Others
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_panic_button)]
    public class ItemPanicButton : TeeItem
    {
        public ItemPanicButton(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}