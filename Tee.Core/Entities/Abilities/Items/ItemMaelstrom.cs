using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_maelstrom)]
    public class ItemMaelstrom : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/chain_lightning.vpcf";
        public ItemMaelstrom(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}