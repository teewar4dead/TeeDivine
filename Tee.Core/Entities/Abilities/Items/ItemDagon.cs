using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_dagon)]
    public class ItemDagon : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/dagon.vpcf";
        public ItemDagon(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}