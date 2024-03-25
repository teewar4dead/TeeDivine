using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_aegis)]
    public class ItemAegis : TeeItem
    {
        public override string ParticlePatch => "particles/generic_hero_status/death_tombstone.vpcf";
        public ItemAegis(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}