using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_hood_of_defiance)]
    public class ItemHoodOfDefiance : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/hood_of_defiance.vpcf";
        public override string SelfBuff => "modifier_item_hood_of_defiance_barrier";
        public ItemHoodOfDefiance(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}