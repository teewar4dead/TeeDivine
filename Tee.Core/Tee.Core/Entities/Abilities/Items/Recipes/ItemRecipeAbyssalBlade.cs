using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Recipes
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_recipe_abyssal_blade)]
    public class ItemRecipeAbyssalBlade : TeeItem
    {
        public ItemRecipeAbyssalBlade(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}