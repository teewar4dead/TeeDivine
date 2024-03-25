using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_silver_edge)]
    public class ItemSilverEdge : TeeItem
    {
        public override string ParticlePatch => "particles/generic_hero_status/status_invisibility_start.vpcf";
        public override string SelfBuff => "modifier_item_silver_edge_windwalk";
        public ItemSilverEdge(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}