using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Recipes
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_recipe_swift_blink)]
    public class ItemRecipeSwiftBlink : TeeItem
    {
        public ItemRecipeSwiftBlink(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}