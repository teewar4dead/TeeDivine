using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_meteor_hammer)]
    public class ItemMeteorHammer : TeeItem
    {
        public override string ParticlePatch => "particles/items4_fx/meteor_hammer_spell.vpcf";
        public override string TargetPointDebuff => "modifier_item_meteor_hammer_burn";
        public ItemMeteorHammer(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}