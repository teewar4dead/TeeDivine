using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_mekansm)]
    public class ItemMekansm : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/mekanism.vpcf";
        public override string AuraBuff => "modifier_item_mekansm_aura";
        public override string SelfBuff => "modifier_item_mekansm_noheal";
        public ItemMekansm(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}