using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_phase_boots)]
    public class ItemPhaseBoots : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/phase_boots.vpcf";
        public override string SelfBuff => "modifier_item_phase_boots_active";
        public ItemPhaseBoots(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}