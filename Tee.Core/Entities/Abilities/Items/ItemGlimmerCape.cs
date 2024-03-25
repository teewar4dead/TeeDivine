using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_glimmer_cape)]
    public class ItemGlimmerCape : TeeItem
    {
        public override string ParticlePatch => "particles/items3_fx/glimmer_cape_initial_flash.vpcf";
        public override string TargetBuff => "modifier_item_glimmer_cape_fade";
        public ItemGlimmerCape(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}