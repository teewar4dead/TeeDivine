using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_greater_crit)]
    public class ItemGreaterCrit : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/daedalus_crit.vpcf";
        public ItemGreaterCrit(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}