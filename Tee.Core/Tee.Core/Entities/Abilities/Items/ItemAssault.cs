using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_assault)]
    public class ItemAssault : TeeItem
    {
        public override string AuraBuff => "modifier_item_assault_positive";
        public override string AuraDebuff => "modifier_item_assault_negative_armor";
        public ItemAssault(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}