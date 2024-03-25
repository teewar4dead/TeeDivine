using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_force_staff)]
    public class ItemForceStaff : TeeItem
    {
        //не работает на блекхол дуел и хроносферы
        public override string ParticlePatch => "particles/items_fx/force_staff.vpcf";
        public override string TargetBuff => "modifier_item_forcestaff_active";
        public override string TargetDebuff => "modifier_item_forcestaff_active";
        public ItemForceStaff(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}