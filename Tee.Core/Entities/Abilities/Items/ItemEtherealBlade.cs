using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_ethereal_blade)]
    public class ItemEtherealBlade : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/ghost.vpcf";
        public override string TargetBuff => "modifier_item_ethereal_blade_ethereal";
        public override string TargetDebuff => "modifier_item_ethereal_blade_slow";
        public ItemEtherealBlade(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}