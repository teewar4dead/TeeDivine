using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_hurricane_pike)]
    public class ItemHurricanePike : TeeItem
    {
        public override string ParticlePatch => "particles/status_fx/status_effect_forcestaff.vpcf";
        public override string TargetBuff => "modifier_item_hurricane_pike_active";
        public ItemHurricanePike(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}