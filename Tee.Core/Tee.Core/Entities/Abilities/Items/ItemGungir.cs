using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_gungir)]
    public class ItemGungir : TeeItem
    {
        public override string ParticlePatch => "particles/items3_fx/gleipnir_root.vpcf";
        public override string TargetPointDebuff => "modifier_gungnir_debuff";
        public ItemGungir(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}