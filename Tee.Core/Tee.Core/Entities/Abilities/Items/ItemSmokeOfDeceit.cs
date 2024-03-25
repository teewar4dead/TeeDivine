using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_smoke_of_deceit)]
    public class ItemSmokeOfDeceit : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/smoke_of_deceit.vpcf";
        public override string SelfBuff => "modifier_smoke_of_deceit";
        public ItemSmokeOfDeceit(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}