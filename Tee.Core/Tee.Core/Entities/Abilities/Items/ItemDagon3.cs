using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_dagon_3)]
    public class ItemDagon3 : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/dagon.vpcf";
        public ItemDagon3(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}