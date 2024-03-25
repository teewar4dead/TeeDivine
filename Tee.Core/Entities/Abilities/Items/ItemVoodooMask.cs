using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_voodoo_mask)]
    public class ItemVoodooMask : TeeItem
    {
        public override string ParticlePatch => "particles/items3_fx/octarine_core_lifesteal.vpcf";
        public ItemVoodooMask(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}