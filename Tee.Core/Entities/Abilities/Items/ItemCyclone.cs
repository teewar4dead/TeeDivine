using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_cyclone)]
    public class ItemCyclone : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/cyclone.vpcf";
        public override string TargetDebuff => "modifier_eul_cyclone";
        public override string TargetBuff => "modifier_eul_cyclone";
        public ItemCyclone(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}