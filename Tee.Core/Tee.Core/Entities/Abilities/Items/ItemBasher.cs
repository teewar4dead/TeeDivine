using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_basher)]
    public class ItemBasher : TeeItem
    {
        public override string ParticlePatch => "particles/generic_gameplay/generic_bashed.vpcf";
        public override string AttackTargetDebuff => "modifier_bashed";

        public ItemBasher(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}