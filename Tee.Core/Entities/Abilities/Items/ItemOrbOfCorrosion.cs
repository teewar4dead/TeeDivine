using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_orb_of_corrosion)]
    public class ItemOrbOfCorrosion : TeeItem
    {
        public override string AttackTargetDebuff => "modifier_orb_of_corrosion_debuff";
        public ItemOrbOfCorrosion(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}