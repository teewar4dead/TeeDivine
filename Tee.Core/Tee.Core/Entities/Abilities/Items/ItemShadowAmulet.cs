using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_shadow_amulet)]
    public class ItemShadowAmulet : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/shadow_amulet.vpcf";
        public override string TargetBuff => "modifier_item_shadow_amulet_fade";
        public ItemShadowAmulet(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}