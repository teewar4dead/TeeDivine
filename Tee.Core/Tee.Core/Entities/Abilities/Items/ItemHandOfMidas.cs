using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_hand_of_midas)]
    public class ItemHandOfMidas : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/hand_of_midas.vpcf";
        public ItemHandOfMidas(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}