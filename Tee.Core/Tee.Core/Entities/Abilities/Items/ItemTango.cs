using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_tango)]
    public class ItemTango : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/healing_tango.vpcf";
        //public override string SelfBuff => "modifier_tango_heal";
        public ItemTango(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}