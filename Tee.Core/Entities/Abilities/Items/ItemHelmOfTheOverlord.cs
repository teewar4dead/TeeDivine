using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_helm_of_the_overlord)]
    public class ItemHelmOfTheOverlord : TeeItem
    {
        public override string AuraBuff => "modifier_item_vladmir_aura";
        public ItemHelmOfTheOverlord(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}