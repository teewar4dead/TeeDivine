using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_medallion_of_courage)]
    public class ItemMedallionOfCourage : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/medallion_of_courage.vpcf";
        public override string TargetBuff => "modifier_item_medallion_of_courage_armor_addition";
        public override string TargetDebuff => "modifier_item_medallion_of_courage_armor_reduction";
        public ItemMedallionOfCourage(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}