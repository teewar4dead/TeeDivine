using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_helm_of_the_dominator)]
    public class ItemHelmOfTheDominator : TeeItem
    {
        public ItemHelmOfTheDominator(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}