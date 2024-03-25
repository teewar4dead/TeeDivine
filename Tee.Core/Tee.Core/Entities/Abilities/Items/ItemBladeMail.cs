using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_blade_mail)]
    public class ItemBladeMail : TeeItem
    {
        public override string SelfBuff => "modifier_item_blade_mail_reflect";
        public override string ParticlePatch => "particles/items_fx/blademail.vpcf";
        public ItemBladeMail(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}