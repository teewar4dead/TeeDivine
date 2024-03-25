using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_clarity)]
    public class ItemClarity : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/healing_clarity.vpcf";
        public override string TargetBuff => "modifier_clarity_potion";

        public ItemClarity(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}