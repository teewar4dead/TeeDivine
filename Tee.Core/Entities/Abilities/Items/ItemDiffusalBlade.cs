using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_diffusal_blade)]
    public class ItemDiffusalBlade : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/diffusal_slow.vpcf";
        public override string TargetDebuff => "modifier_item_diffusal_blade_slow";
        public ItemDiffusalBlade(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}