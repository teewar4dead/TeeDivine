using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Recipes
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_recipe_witch_blade)]
    public class ItemRecipeWitchBlade : TeeItem
    {
        public ItemRecipeWitchBlade(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}