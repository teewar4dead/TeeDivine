using Tee.Core.Attributes;

namespace Tee.Core.Entities.Abilities.Items
{
    [Ability(Divine.Entity.Entities.Abilities.Components.AbilityId.item_veil_of_discord)]
    public class ItemVeilOfDiscord : TeeItem
    {
        public override string ParticlePatch => "particles/items2_fx/veil_of_discord.vpcf";
        public override string AuraBuff => "modifier_item_veil_of_discord_mana";
        public override string TargetPointDebuff => "modifier_item_veil_of_discord_debuff";

        public ItemVeilOfDiscord(Divine.Entity.Entities.Abilities.Items.Item baseItem) : base(baseItem)
        {
        }
    }
}