using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_crimson_guard)]
    public class ItemCrimsonGuard : TeeItem
    {
        public override string SelfBuff => "modifier_item_crimson_guard_nostack";
        public override string ParticlePatch => "particles/items2_fx/vanguard_active.vpcf";
        public ItemCrimsonGuard(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}