using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_dagon_5)]
    public class ItemDagon5 : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/dagon.vpcf";
        public ItemDagon5(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}