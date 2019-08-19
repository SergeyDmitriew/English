using System;

namespace Engine.TemplateFSM
{
    public interface IControllerFsm<TStateType>
    {
        event Action<TStateType, TStateType> OnChangeState;

        TStateType CurrentState { get; }

        void Start (TStateType stateType);
        void Switch (TStateType stateType);
    }
}