using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_blade_of_alacrity)]
    public class ItemBladeOfAlacrity : TeeItem
    {
        public ItemBladeOfAlacrity(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}