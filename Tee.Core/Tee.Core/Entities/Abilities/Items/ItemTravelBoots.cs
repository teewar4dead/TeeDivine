using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_travel_boots)]
    public class ItemTravelBoots : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/urn_of_shadows.vpcf";
        public override string TargetBuff => "modifier_item_urn_heal";
        public override string TargetDebuff => "modifier_item_urn_damage";
        public ItemTravelBoots(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}