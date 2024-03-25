using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_disperser)]
    public class ItemDisperser : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/disperser_buff.vpcf";
        public override string TargetDebuff => "modifier_item_diffusal_blade_slow";
        public override string TargetBuff => "modifier_disperser_movespeed_buff";
        public ItemDisperser(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}