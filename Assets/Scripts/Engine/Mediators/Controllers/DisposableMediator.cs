using System;
using System.Collections.Generic;

namespace Engine.Mediators
{
    public class DisposableMediator : IDisposableMediator
    {
        private readonly List<IDisposable> _disposables;

        public DisposableMediator (List<IDisposable> disposables)
        {
            _disposables = disposables;
        }

        public void Dispose ()
        {
            foreach (var item in _disposables)
                item.Dispose ();
        }
    }
}