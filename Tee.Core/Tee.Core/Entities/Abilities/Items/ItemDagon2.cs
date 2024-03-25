using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_dagon_2)]
    public class ItemDagon2 : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/dagon.vpcf";
        public ItemDagon2(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}