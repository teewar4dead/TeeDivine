using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_bloodthorn)]
    public class ItemBloodthorn : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/orchid.vpcf";
        public override string TargetDebuff => "modifier_bloodthorn_debuff";
        public ItemBloodthorn(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}