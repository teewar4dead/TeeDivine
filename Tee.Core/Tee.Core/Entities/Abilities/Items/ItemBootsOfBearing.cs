using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_boots_of_bearing)]
    public class ItemBootsOfBearing : TeeItem
    {
        public override string AuraBuff => "modifier_item_boots_of_bearing_aura";
        public override string SelfBuff => "modifier_item_boots_of_bearing_active";
        public override string ParticlePatch => "particles/items_fx/drum_of_endurance_buff.vpcf";
        public ItemBootsOfBearing(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}