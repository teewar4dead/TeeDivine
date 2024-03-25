using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_gem)]
    public class ItemGem : TeeItem
    {
        public override string ParticlePatch => "particles/items4_fx/seer_stone.vpcf";
        public ItemGem(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}