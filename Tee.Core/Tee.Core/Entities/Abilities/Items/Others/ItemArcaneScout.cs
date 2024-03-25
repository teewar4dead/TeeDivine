using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Others
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_arcane_scout)]
    public class ItemArcaneScout : TeeItem
    {
        public ItemArcaneScout(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}