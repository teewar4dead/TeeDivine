using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_guardian_greaves)]
    public class ItemGuardianGreaves : TeeItem
    {
        public override string ParticlePatch => "particles/items3_fx/warmage.vpcf";
        public override string AuraBuff => "modifier_item_guardian_greaves_aura";
        public override string SelfBuff => "modifier_item_mekansm_noheal";
        public ItemGuardianGreaves(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}