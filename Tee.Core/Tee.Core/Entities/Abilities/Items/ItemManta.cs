using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_manta)]
    public class ItemManta : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/manta_phase.vpcf";
        public ItemManta(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}