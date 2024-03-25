using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Neutrals
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_bullwhip)]
    public class ItemBullwhip : TeeItem
    {
        public override string ParticlePatch => "particles/items4_fx/bull_whip_self.vpcf";
        public override string TargetBuff => "modifier_item_bullwhip_buff";
        public override string TargetDebuff => "modifier_item_bullwhip_buff";
        public ItemBullwhip(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}