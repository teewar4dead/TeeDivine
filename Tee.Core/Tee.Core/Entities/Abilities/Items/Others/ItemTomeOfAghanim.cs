using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Others
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_tome_of_aghanim)]
    public class ItemTomeOfAghanim : TeeItem
    {
        public ItemTomeOfAghanim(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}