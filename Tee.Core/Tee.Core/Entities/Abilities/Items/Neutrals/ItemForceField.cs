using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Neutrals
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_force_field)]
    public class ItemForceField : TeeItem
    {
        public ItemForceField(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}