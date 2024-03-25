using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_sheepstick)]
    public class ItemSheepstick : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/item_sheepstick.vpcf";
        public override string TargetDebuff => "modifier_sheepstick_debuff";
        public ItemSheepstick(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}