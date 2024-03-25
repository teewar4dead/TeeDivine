using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_orb_of_venom)]
    public class ItemOrbOfVenom : TeeItem
    {
        public override string AttackTargetDebuff => "modifier_item_orb_of_venom_slow";
        public ItemOrbOfVenom(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}