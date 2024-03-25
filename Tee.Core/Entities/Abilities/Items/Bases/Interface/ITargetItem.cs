using Divine.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tee.Core.Entities.Units;

namespace Tee.Core.Entities.Abilities.Items.Bases.Interface
{
    interface ITargetItem
    {
        bool UseItem(TeeUnit target);
        bool CanBeCasted(TeeUnit target);
    }
}
