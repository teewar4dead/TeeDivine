using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_faerie_fire)]
    public class ItemFaerieFire : TeeItem
    {
        public override string ParticlePatch => "particles/items3_fx/fish_bones_active.vpcf";
        public ItemFaerieFire(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}