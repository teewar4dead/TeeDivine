using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_lotus_orb)]
    public class ItemLotusOrb : TeeItem
    {
        public override string ParticlePatch => "particles/items3_fx/lotus_orb_shield.vpcf";
        public override string TargetBuff => "modifier_item_lotus_orb_active";
        public ItemLotusOrb(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}