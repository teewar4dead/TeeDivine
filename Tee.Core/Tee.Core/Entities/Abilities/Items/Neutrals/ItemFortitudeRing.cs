using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Neutrals
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_fortitude_ring)]
    public class ItemFortitudeRing : TeeItem
    {
        public ItemFortitudeRing(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}