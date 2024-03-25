using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_overwhelming_blink)]
    public class ItemOverwhelmingBlink : TeeItem
    {
        public override string ParticlePatch => "particles/items3_fx/blink_overwhelming_burst.vpcf";
        //public override string TargetPointDebuff => "modifier_item_overwhelming_blink_debuff";
        public ItemOverwhelmingBlink(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}