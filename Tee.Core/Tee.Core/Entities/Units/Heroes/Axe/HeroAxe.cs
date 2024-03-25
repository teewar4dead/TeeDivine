using Divine.Entity.Entities.Units.Heroes;
using Tee.Core.Entities.Components;

namespace Tee.Core.Entities.Units.Heroes.Axe
{
    [Hero(Divine.Entity.Entities.Units.Heroes.Components.HeroId.npc_dota_hero_axe)]
    public class HeroAxe : TeeHero, IDisposable
    {
        private bool _disposed = false;
        private readonly ActionManager _actionManager;
        private Lazy<ItemsStorage> _itemsStorage;
        private Lazy<SpellStorage> _spellStorage;
        public ItemsStorage ItemsStorage => _itemsStorage.Value;
        public SpellStorage SpellStorage => _spellStorage.Value;

        public HeroAxe(Hero baseHero) : base(baseHero)
        {
            _actionManager = new ActionManager(this);

            _itemsStorage = new Lazy<ItemsStorage>(() => new ItemsStorage(_actionManager));
            _spellStorage = new Lazy<SpellStorage>(() => new SpellStorage(_actionManager));
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _actionManager.Dispose();
                _disposed = true;
            }
        }
    }
}
