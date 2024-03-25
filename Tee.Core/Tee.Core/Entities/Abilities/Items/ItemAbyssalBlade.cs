using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_abyssal_blade)]
    public class ItemAbyssalBlade : TargetItem
    {
        public override string TargetDebuff => "modifier_bashed";
        public override string AttackTargetDebuff => "AttackTargetDebuff";
        public override string ParticlePatch => "particles/items_fx/abyssal_blade.vpcf";
        public ItemAbyssalBlade(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}