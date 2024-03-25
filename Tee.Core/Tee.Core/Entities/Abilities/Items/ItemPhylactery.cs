using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_phylactery)]
    public class ItemPhylactery : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/phylactery.vpcf";
        //mod = modifier_item_phylactery_slow
        public ItemPhylactery(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}