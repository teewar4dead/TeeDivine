using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_radiance)]
    public class ItemRadiance : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/radiance.vpcf";
        public override string AuraDebuff => "modifier_item_radiance_debuff";
        public ItemRadiance(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}