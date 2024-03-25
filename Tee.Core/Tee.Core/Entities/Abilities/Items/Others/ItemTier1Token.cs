using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Others
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_tier1_token)]
    public class ItemTier1Token : TeeItem
    {
        public ItemTier1Token(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}