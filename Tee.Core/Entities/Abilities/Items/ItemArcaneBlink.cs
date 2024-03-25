using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_arcane_blink)]
    public class ItemArcaneBlink : TeeItem
    {
        public override string ParticlePatch => "particles/items3_fx/blink_arcane_start.vpcf";
        public ItemArcaneBlink(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}