using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_headdress)]
    public class ItemHeaddress : TeeItem
    {
        public override string AuraBuff => "modifier_item_headdress_aura";
        public ItemHeaddress(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}