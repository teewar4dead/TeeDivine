using Divine.Service;
using Divine.Update;
using Tee.Core.Entities.Abilities.Items;
using Tee.Core.Entities.Units.Heroes.Axe;
using Tee.Core.Utilities;
namespace Tee.Core
{
    public class Boot : Bootstrapper
    {
        protected override void OnActivate()
        {
            UpdateManager.Update += UpdateManager_Update;
            Console.WriteLine("Tee Core LOADED");
        }

        private void UpdateManager_Update()
        {
            var TeeUnits = TeeEntityManager.GetEntities<ItemAbyssalBlade>().LastOrDefault();

        }


    }
}
