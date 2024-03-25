using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_solar_crest)]
    public class ItemSolarCrest : TeeItem
    {
        public override string ParticlePatch => "particles/items3_fx/star_emblem_caster.vpcf";
        public override string TargetBuff => "modifier_item_solar_crest_armor_addition";
        public override string TargetDebuff => "modifier_item_solar_crest_armor_reduction";
        public ItemSolarCrest(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}