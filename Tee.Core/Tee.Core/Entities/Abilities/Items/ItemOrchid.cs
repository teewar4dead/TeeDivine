using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_orchid)]
    public class ItemOrchid : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/orchid.vpcf";
        public override string TargetDebuff => "modifier_orchid_malevolence_debuff";
        public ItemOrchid(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}