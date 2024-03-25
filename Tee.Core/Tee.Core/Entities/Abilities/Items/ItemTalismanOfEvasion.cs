using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_talisman_of_evasion)]
    public class ItemTalismanOfEvasion : TeeItem
    {
        public ItemTalismanOfEvasion(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}