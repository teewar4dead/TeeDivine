using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_mage_slayer)]
    public class ItemMageSlayer : TeeItem
    {
        public override string AttackTargetDebuff => "modifier_item_mage_slayer_debuff";
        public ItemMageSlayer(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}