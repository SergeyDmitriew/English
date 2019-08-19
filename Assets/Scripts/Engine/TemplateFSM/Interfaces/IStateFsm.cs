namespace Engine.TemplateFSM
{
    public interface IStateFsm<TStateType>
    {
        TStateType StateType { get; }

        void Initialize (IControllerFsm<TStateType> controllerFsm);
        void OnEnter (TStateType pastState);
        void OnExit (TStateType nextState);
    }
}