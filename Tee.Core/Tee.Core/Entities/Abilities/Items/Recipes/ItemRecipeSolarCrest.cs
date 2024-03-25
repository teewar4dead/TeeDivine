using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Recipes
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_recipe_solar_crest)]
    public class ItemRecipeSolarCrest : TeeItem
    {
        public ItemRecipeSolarCrest(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}