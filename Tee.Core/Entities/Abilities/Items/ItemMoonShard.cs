using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_moon_shard)]
    public class ItemMoonShard : TeeItem
    {
        public override string TargetBuff => "modifier_item_moon_shard_consumed";
        public ItemMoonShard(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}