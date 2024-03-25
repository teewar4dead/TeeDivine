using Divine.Entity.Entities.Abilities.Items;
using Divine.Entity.Entities.PhysicalItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tee.Entities;

namespace Tee.Core.Entities.Abilities
{
    public class TeePhysicalItem : TeeEntity
    {
        public PhysicalItem BasePhysicalItem;
        public TeePhysicalItem(PhysicalItem item) : base(item)
        {
            BasePhysicalItem = item;
        }
        public TeeItem? Item
        {
            get
            {
                var item = BasePhysicalItem.Item;
                return item == null ? null : new TeeItem(item);
            }
        }
    }
}
