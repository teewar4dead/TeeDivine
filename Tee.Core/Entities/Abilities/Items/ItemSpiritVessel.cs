using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_spirit_vessel)]
    public class ItemSpiritVessel : TeeItem
    {
        public override string ParticlePatch => "particles/items4_fx/spirit_vessel_cast.vpcf";
        public override string TargetBuff => "modifier_item_spirit_vessel_heal";
        public override string TargetDebuff => "modifier_item_spirit_vessel_damage";
        public ItemSpiritVessel(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}