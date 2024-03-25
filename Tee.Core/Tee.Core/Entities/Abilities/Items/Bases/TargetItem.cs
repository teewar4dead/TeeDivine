using Divine.Entity.Entities.Abilities.Items;
using Divine.Helpers;
using Tee.Core.Entities.Abilities.Items.Bases.Interface;
using Tee.Core.Entities.Abilities;
using Tee.Core.Entities.Units;
using Tee.Core.Utilities;
using Divine.Extensions;

public class TargetItem : TeeItem, ITargetItem
{
    private string Key => $"TeeSleep_{this.Handle}";

    public TargetItem(Item baseEntity) : base(baseEntity)
    {
    }

    public bool CanBeCasted(TeeUnit target)
    {
        if (MultiSleeper<string>.IsSleeping(Key))
            return false;
        if (target == null)
            return false;
        if (target.IsInvulnerable)
            return false;
        if (target.IsMagicImmune)
            return false;
        if (!this.IsEnabled)
            return false;
        if (this.isValid)
            return false;
        if (!this.IsManaAvailableForCast)
            return false;
        if (this.IsOnCooldown)
            return false;

        MultiSleeper<string>.Sleep(Key, RandomManager.Next(50, 100));
        return true;
    }

    public bool UseItem(TeeUnit target)
    {
        if (!CanBeCasted(target))
            return false;

        return this.UseAbility(target);
    }
}
