using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_vladmir)]
    public class ItemVladmir : TeeItem
    {
        public override string AuraBuff => "modifier_item_vladmir_aura";
        public ItemVladmir(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}