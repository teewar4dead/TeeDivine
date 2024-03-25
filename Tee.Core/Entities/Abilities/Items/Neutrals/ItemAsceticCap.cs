using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Neutrals
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_ascetic_cap)]
    public class ItemAsceticCap : TeeItem
    {
        public override string ParticlePatch => "particles/items4_fx/ascetic_cap.vpcf";
        //mod modifier_item_ascetic_cap_buff
        public ItemAsceticCap(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}