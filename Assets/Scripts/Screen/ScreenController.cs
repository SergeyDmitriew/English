using Core.Task;
using Engine.Mediators;
using System;

namespace Core.Screen
{
    public class ScreenController : IScreenController, IScreenListener, IInitializable
    {
        public event Action<ETaskResult> OnAnswer;

        private readonly ScreenView _screenView;
        private ITask _currentTask;

        public ScreenController(ScreenView screenView)
        {
            _screenView = screenView;
        }

        public void ShowTask(ITask task)
        {
            _currentTask = task;
            _screenView.ShowQuestion(_currentTask.Question);
        }

        public void OnClickTrue()
        {
            OnAnswer?.Invoke(ETaskResult.True);
        }

        public void OnClickFalse()
        {
            OnAnswer?.Invoke(ETaskResult.False);
        }

        public void OnClickAnswer()
        {
            _screenView.ShowAnswer(_currentTask.Answer);
        }

        public void Initialize()
        {
            _screenView.Initialize(this);
        }
    }
}