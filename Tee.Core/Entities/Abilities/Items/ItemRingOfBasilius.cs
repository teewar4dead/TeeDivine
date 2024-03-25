using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_ring_of_basilius)]
    public class ItemRingOfBasilius : TeeItem
    {
        public override string AuraBuff => "modifier_item_ring_of_basilius_effect";
        public ItemRingOfBasilius(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}