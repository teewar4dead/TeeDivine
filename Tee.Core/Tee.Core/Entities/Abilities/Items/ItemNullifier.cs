using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_nullifier)]
    public class ItemNullifier : TeeItem
    {
        public override string ParticlePatch => "particles/items4_fx/nullifier_proj.vpcf";
        public override string TargetDebuff => "modifier_item_nullifier_mute";
        public ItemNullifier(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}