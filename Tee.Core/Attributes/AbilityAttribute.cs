using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tee.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public sealed class AbilityAttribute : System.Attribute
    {
        public Divine.Entity.Entities.Abilities.Components.AbilityId AbilityId { get; private set; }
        public AbilityAttribute(Divine.Entity.Entities.Abilities.Components.AbilityId abilityId)
        {
            AbilityId = abilityId;
        }
    }
}
