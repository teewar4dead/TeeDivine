using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_pavise)]
    public class ItemPavise : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/pavise_friend.vpcf";
        public override string SelfBuff => "modifier_item_pavise_shield";
        public ItemPavise(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}