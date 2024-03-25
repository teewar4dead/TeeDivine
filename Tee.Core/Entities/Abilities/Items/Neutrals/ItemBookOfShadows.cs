using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items.Neutrals
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_book_of_shadows)]
    public class ItemBookOfShadows : TeeItem
    {
        public override string ParticlePatch => "particles/units/heroes/hero_dark_willow/dark_willow_shadow_realm.vpcf";
        public override string SelfBuff => "modifier_item_book_of_shadows_buff";
        public ItemBookOfShadows(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}