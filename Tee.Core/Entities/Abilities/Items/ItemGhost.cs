using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_ghost)]
    public class ItemGhost : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/ghost.vpcf";
        public override string SelfBuff => "modifier_ghost_state";
        public ItemGhost(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}