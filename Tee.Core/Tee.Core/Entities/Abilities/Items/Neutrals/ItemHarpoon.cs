using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Neutrals
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_harpoon)]
    public class ItemHarpoon : TeeItem
    {
        public ItemHarpoon(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}