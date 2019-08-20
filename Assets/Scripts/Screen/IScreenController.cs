using Core.Task;
using System;

namespace Core.Screen
{
    public interface IScreenController
    {
        event Action<ETaskResult> OnAnswer;
        void ShowTask(ITask task);
    }
}