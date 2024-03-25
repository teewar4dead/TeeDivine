using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_rod_of_atos)]
    public class ItemRodOfAtos : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/rod_of_atos.vpcf";
        public override string TargetDebuff => "modifier_rod_of_atos_debuff";
        public ItemRodOfAtos(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}