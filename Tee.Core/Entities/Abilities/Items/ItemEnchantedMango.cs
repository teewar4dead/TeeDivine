using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_enchanted_mango)]
    public class ItemEnchantedMango : TeeItem
    {
        public override string ParticlePatch => "particles/items3_fx/mango_active.vpcf";
        public ItemEnchantedMango(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}