using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_bottle)]
    public class ItemBottle : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/bottle.vpcf";
        public override string SelfBuff => "modifier_bottle_regeneration";
        public ItemBottle(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}