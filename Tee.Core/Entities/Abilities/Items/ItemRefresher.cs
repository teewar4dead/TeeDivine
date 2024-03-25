using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_refresher)]
    public class ItemRefresher : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/refresher.vpcf";
        public ItemRefresher(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}