using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_soul_ring)]
    public class ItemSoulRing : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/soul_ring.vpcf";
        //public override string SelfBuff => "modifier_item_soul_ring_buff";
        public ItemSoulRing(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}