using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Neutrals
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_arcane_ring)]
    public class ItemArcaneRing : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/arcane_boots_recipient.vpcf";
        public ItemArcaneRing(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}