using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Neutrals
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_ceremonial_robe)]
    public class ItemCeremonialRobe : TeeItem
    {
        public override string AuraDebuff => "modifier_ceremonial_robe_aura";
        public ItemCeremonialRobe(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}