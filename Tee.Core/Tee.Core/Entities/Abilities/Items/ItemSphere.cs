using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_sphere)]
    public class ItemSphere : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/immunity_sphere_buff.vpcf";
        public override string TargetBuff => "modifier_item_sphere_target";
        public ItemSphere(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}