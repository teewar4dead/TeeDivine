using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_blight_stone)]
    public class ItemBlightStone : TeeItem
    {
        public override string AttackTargetDebuff => "modifier_blight_stone_buff";
        public ItemBlightStone(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}