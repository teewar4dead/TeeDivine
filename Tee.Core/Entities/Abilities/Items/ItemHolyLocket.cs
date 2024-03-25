using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_holy_locket)]
    public class ItemHolyLocket : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/holy_locket_cast.vpcf";
        public override string AuraBuff => "modifier_item_holy_locket_aura";
        public ItemHolyLocket(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}