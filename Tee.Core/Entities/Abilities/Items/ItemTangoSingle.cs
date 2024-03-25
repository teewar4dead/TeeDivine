using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_tango_single)]
    public class ItemTangoSingle : TeeItem
    {
        public override string ParticlePatch => "particles/generic_gameplay/item_received.vpcf";
        //public override string SelfBuff => "modifier_tango_heal";
        public ItemTangoSingle(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}