using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_mask_of_madness)]
    public class ItemMaskOfMadness : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/mask_of_madness.vpcf";
        public override string SelfBuff => "modifier_item_mask_of_madness_berserk";
        public ItemMaskOfMadness(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}