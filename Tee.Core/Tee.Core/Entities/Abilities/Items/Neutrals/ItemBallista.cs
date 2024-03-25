using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Neutrals
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_ballista)]
    public class ItemBallista : TeeItem
    {
        public ItemBallista(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}