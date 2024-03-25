using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_skadi)]
    public class ItemSkadi : TeeItem
    {
        public override string ParticlePatch => "particles/status_fx/status_effect_frost.vpcf";
        public override string AttackTargetDebuff => "modifier_item_skadi_slow";
        public ItemSkadi(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}