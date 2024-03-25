using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_stout_shield)]
    public class ItemStoutShield : TeeItem
    {
        public ItemStoutShield(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}