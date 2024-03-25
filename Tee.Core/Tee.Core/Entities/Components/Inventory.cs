using Divine.Entity.Entities.Abilities.Items;
using Divine.Entity.Entities.Abilities.Items.Components;
using Divine.Entity.Entities.Units.Heroes;
using Tee.Core.Entities.Abilities;
using Tee.Core.Entities.Abilities.Items;
using Tee.Core.Entities.Abilities.Items.Neutrals;
using Tee.Core.Entities.Abilities.Items.Others;
using Tee.Core.Entities.Abilities.Items.Recipes;
using Tee.Core.Entities.Abilities.Spells.Axe;
using Tee.Core.Entities.Units;
using Tee.Core.Utilities;

namespace Tee.Core.Entities.Components
{
    public class Inventory
    {
        private readonly Divine.Entity.Entities.Units.Components.Inventory baseInventory;

        public Inventory(Divine.Entity.Entities.Units.Components.Inventory baseInventory)
        {
            this.baseInventory = baseInventory;
        }

        public TeeItem Item1 => (TeeItem)baseInventory?.Item1;
        public TeeItem Item2 => (TeeItem)baseInventory?.Item2;
        public TeeItem Item3 => (TeeItem)baseInventory?.Item3;
        public TeeItem Item4 => (TeeItem)baseInventory?.Item4;
        public TeeItem Item5 => (TeeItem)baseInventory?.Item5;
        public TeeItem Item6 => (TeeItem)baseInventory?.Item6;
        public TeeItem NeutralItem => (TeeItem)baseInventory?.NeutralItem;
        public TeeItem TownPortalScroll => (TeeItem)baseInventory?.TownPortalScroll;

        public IEnumerable<TeeItem> AllItems => baseInventory.Items.Select(x=> (TeeItem)x);
        public IEnumerable<TeeItem> MainItems => baseInventory.MainItems.Select(x => (TeeItem)x);
        public IEnumerable<TeeItem> StashItems => baseInventory.StashItems.Select(x => (TeeItem)x);
        public IEnumerable<TeeItem> BackpackItems => baseInventory.BackpackItems.Select(x => (TeeItem)x);

        public IEnumerable<ItemSlot> FreeSlots => baseInventory.FreeSlots;
        public IEnumerable<ItemSlot> FreeMainSlots => baseInventory.FreeMainSlots;
        public IEnumerable<ItemSlot> FreeStashSlots => baseInventory.FreeStashSlots;
        public IEnumerable<ItemSlot> FreeBackpackSlots => baseInventory.FreeBackpackSlots;

        public bool IsStashEnabled => baseInventory.IsStashEnabled;

    
    }
}
