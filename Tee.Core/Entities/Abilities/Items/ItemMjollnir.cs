using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_mjollnir)]
    public class ItemMjollnir : TeeItem
    {
        public override string ParticlePatch => "particles/status_fx/status_effect_mjollnir_shield.vpcf";
        public override string TargetBuff => "modifier_item_mjollnir_static";
        public ItemMjollnir(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}