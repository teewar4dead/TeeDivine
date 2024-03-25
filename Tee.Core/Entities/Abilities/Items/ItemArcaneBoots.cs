using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_arcane_boots)]
    public class ItemArcaneBoots : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/arcane_boots.vpcf";
        public ItemArcaneBoots(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}