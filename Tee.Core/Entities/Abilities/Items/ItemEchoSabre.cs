using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_echo_sabre)]
    public class ItemEchoSabre : TeeItem
    {
        public override string AttackTargetDebuff => "modifier_echo_sabre_debuff";
        public ItemEchoSabre(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}