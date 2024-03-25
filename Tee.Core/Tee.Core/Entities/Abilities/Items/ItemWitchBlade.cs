using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_witch_blade)]
    public class ItemWitchBlade : TeeItem
    {
        public override string ParticlePatch => "particles/items3_fx/witch_blade_debuff.vpcf";
        public override string AttackTargetDebuff => "modifier_item_witch_blade_slow";
        public ItemWitchBlade(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}