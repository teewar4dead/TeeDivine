using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_quelling_blade)]
    public class ItemQuellingBlade : TeeItem
    {
        public ItemQuellingBlade(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}