using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_bloodstone)]
    public class ItemBloodstone : TeeItem
    {
        public override string SelfBuff => "modifier_item_bloodstone_drained";
        public override string ParticlePatch => "particles/items_fx/bloodstone_heal.vpcf";
        public ItemBloodstone(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}