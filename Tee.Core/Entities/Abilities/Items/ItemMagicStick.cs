using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_magic_stick)]
    public class ItemMagicStick : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/magic_stick.vpcf";
        public ItemMagicStick(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}