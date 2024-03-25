using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_dust)]
    public class ItemDust : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/dust_of_appearance.vpcf";
        public override string AreaDebuff => "modifier_item_dustofappearance";
        public ItemDust(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}