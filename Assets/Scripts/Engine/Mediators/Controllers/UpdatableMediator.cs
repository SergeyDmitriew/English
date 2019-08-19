using System.Collections.Generic;

namespace Engine.Mediators
{
    public class UpdatableMediator : IUpdatableMediator
    {
        private readonly List<IUpdatable> _updatables;

        public UpdatableMediator (List<IUpdatable> updatables)
        {
            _updatables = updatables;
        }

        public void Update (float deltaTime)
        {
            foreach (var item in _updatables)
                item.Update (deltaTime);
        }
    }
}