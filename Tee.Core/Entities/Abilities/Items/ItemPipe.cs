using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_pipe)]
    public class ItemPipe : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/pipe_of_insight_launch.vpcf";
        public override string AuraBuff => "modifier_item_pipe_aura";
        public override string SelfBuff => "modifier_item_pipe_barrier";
        public ItemPipe(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}