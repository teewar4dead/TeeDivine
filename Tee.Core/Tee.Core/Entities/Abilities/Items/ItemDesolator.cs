using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_desolator)]
    public class ItemDesolator : TeeItem
    {
        public override string AttackTargetDebuff => "modifier_desolator_buff";
        public ItemDesolator(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}