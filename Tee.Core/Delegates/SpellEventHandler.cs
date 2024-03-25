using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tee.Core.Entities.Abilities;

namespace Tee.Core.Delegates
{
    public delegate void SpellEventHandler(uint ownerHandle, TeeSpell spell);
}
