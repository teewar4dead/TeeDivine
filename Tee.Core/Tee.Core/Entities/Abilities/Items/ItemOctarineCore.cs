using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_octarine_core)]
    public class ItemOctarineCore : TeeItem
    {
        public override string ParticlePatch => "particles/items3_fx/octarine_core_lifesteal.vpcf";
        public ItemOctarineCore(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}