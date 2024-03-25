using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Neutrals
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_cloak_of_flames)]
    public class ItemCloakOfFlames : TeeItem
    {
        public override string AuraDebuff => "modifier_item_cloak_of_flames_debuff";
        public ItemCloakOfFlames(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}