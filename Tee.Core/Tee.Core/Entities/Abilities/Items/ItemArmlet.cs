using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_armlet)]
    public class ItemArmlet : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/armlet.vpcf";
        public override string SelfBuff => "modifier_item_armlet_unholy_strength";
        public ItemArmlet(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}