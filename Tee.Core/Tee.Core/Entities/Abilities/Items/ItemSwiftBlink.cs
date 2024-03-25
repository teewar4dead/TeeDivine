using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_swift_blink)]
    public class ItemSwiftBlink : TeeItem
    {
        public override string ParticlePatch => "particles/items3_fx/blink_swift_start.vpcf";
        //public override string SelfBuff => "modifier_item_swift_blink_buff";
        public ItemSwiftBlink(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}