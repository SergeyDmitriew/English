using System.Collections.Generic;

namespace Engine.Mediators
{
    public class InitializeMediator : IInitializeMediator
    {
        private readonly List<IInitializable> _initializables;

        public InitializeMediator (List<IInitializable> initializables)
        {
            _initializables = initializables;
        }

        public void Initialize ()
        {
            foreach (var item in _initializables)
                item.Initialize ();
        }
    }
}