using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_wind_waker)]
    public class ItemWindWaker : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/cyclone.vpcf";
        public override string TargetBuff => "modifier_wind_waker";
        public override string TargetDebuff => "modifier_wind_waker";
        public ItemWindWaker(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}