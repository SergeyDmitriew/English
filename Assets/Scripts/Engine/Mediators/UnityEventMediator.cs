using System;
using System.Collections.Generic;
using System.Reflection;

namespace Engine.Mediators
{
    public class UnityEventMediator : IUnityEventMediator
    {
        private const BindingFlags BindingAttr = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

        private readonly InitializeMediator _initializeMediator;
        private readonly UpdatableMediator _updatableMediator;
        private readonly DisposableMediator _disposableMediator;

        public UnityEventMediator (MainInfrastructure infrastructure)
        {
            var fields = infrastructure.GetType ().GetFields (BindingAttr);

            _initializeMediator = new InitializeMediator (GetListTypeOfInstance<IInitializable> (fields, infrastructure));
            _disposableMediator = new DisposableMediator (GetListTypeOfInstance<IDisposable> (fields, infrastructure));
            _updatableMediator = new UpdatableMediator (GetListTypeOfInstance<IUpdatable> (fields, infrastructure));
        }

        public void Initialize ()
        {
            _initializeMediator.Initialize ();
        }

        public void Dispose ()
        {
            _disposableMediator.Dispose ();
        }

        public void Update (float deltaTime)
        {
            _updatableMediator.Update (deltaTime);
        }

        private List<T> GetListTypeOfInstance<T> (FieldInfo[] fields, object instance) where T : class
        {
            var listTypes = new List<T> ();
            if (fields == null || fields.Length == 0)
                return listTypes;

            foreach (var item in fields)
            {
                if (item.GetValue (instance) is T type)
                    listTypes.Add (type);
            }

            return listTypes;
        }
    }
}