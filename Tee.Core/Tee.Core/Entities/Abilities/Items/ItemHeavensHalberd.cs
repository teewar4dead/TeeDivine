using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_heavens_halberd)]
    public class ItemHeavensHalberd : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/heavens_halberd.vpcf";
        public override string TargetDebuff => "modifier_heavens_halberd_debuff";
        public ItemHeavensHalberd(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}