using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_blink)]
    public class ItemBlink : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/blink_dagger_start.vpcf";
        public ItemBlink(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}