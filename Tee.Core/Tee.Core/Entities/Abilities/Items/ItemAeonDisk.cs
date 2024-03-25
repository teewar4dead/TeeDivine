using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_aeon_disk)]
    public class ItemAeonDisk : TeeItem
    {
        public override string SelfBuff => "modifier_item_aeon_disk_buff";
        public override string ParticlePatch => "particles/items4_fx/combo_breaker_buff.vpcf";
        public ItemAeonDisk(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {

        }
    }
}