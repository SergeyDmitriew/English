namespace Core.Task
{
    public interface ITaskController
    {
        ITask Task { get; }

        void Next();
        void Mark(ETaskResult result);
    }
}