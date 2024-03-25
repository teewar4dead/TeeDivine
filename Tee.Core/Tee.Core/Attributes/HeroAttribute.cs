using Divine.Entity.Entities.Units.Heroes.Components;
using System;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class HeroAttribute : System.Attribute
{
    public HeroId HeroId { get; }

    public HeroAttribute(HeroId heroId)
    {
        HeroId = heroId;
    }
}
