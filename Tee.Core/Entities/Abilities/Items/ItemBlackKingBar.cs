using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_black_king_bar)]
    public class ItemBlackKingBar : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/black_king_bar_avatar.vpcf";
        public override string SelfBuff => "modifier_black_king_bar_immune";
        public ItemBlackKingBar(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}