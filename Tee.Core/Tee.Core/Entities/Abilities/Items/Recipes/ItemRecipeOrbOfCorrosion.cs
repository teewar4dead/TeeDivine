using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Recipes
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_recipe_orb_of_corrosion)]
    public class ItemRecipeOrbOfCorrosion : TeeItem
    {
        public ItemRecipeOrbOfCorrosion(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}