using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_flask)]
    public class ItemFlask : TeeItem
    {
        public override string ParticlePatch => "particles/items_fx/healing_flask.vpcf";
        public override string TargetBuff => "modifier_flask_healing";
        public ItemFlask(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}