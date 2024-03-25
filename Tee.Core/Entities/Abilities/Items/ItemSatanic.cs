using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_satanic)]
    public class ItemSatanic : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/satanic_buff.vpcf";
        public override string SelfBuff => "modifier_item_satanic_unholy";
        public ItemSatanic(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}