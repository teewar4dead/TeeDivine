using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_shivas_guard)]
    public class ItemShivasGuard : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/shivas_guard_active.vpcf";
        public override string AuraDebuff => "modifier_item_shivas_guard_aura";
        public override string AreaDebuff => "modifier_item_shivas_guard_blast";
        public ItemShivasGuard(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}