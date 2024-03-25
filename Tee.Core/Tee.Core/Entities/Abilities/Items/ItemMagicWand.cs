using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_magic_wand)]
    public class ItemMagicWand : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/magic_wand.vpcf";
        public ItemMagicWand(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}