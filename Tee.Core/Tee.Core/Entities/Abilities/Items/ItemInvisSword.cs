using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_invis_sword)]
    public class ItemInvisSword : TeeItem
    {
        public override string ParticlePatch => "particles/generic_hero_status/status_invisibility_start.vpcf";
        public override string SelfBuff => "modifier_item_invisibility_edge_windwalk";
        public ItemInvisSword(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}