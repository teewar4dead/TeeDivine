using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Recipes
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_recipe_basher)]
    public class ItemRecipeBasher : TeeItem
    {
        public ItemRecipeBasher(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}