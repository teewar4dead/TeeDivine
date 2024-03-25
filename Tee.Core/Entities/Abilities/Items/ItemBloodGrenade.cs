using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_blood_grenade)]
    public class ItemBloodGrenade : TeeItem
    {
        public override string TargetPointDebuff => "modifier_item_blood_grenade_debuff";
        public override string ParticlePatch => "particles/items2_fx/blood_grenade_projectile.vpcf";
        public ItemBloodGrenade(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}