using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_buckler)]
    public class ItemBuckler : TeeItem
    {
        public override string AuraBuff => "modifier_item_buckler_effect";
        public ItemBuckler(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}