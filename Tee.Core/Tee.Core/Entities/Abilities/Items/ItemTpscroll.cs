using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_tpscroll)]
    public class ItemTpscroll : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/teleport_start.vpcf";
        //public override string SelfBuff => "modifier_teleporting";
        public ItemTpscroll(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}