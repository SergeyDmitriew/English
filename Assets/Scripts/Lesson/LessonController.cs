using Core.Screen;
using Core.Task;
using Engine.Mediators;

namespace Core.Lesson
{
    public class LessonController : ILessonController, IInitializable
    {
        private readonly IScreenController _screenController;
        private readonly ITaskController _taskController;

        public LessonController(IScreenController screenController, ITaskController taskController)
        {
            _screenController = screenController;
            _taskController = taskController;
        }

        public void Initialize()
        {
            _screenController.OnAnswer += OnAnswer;
            Begin();
        }

        private void OnAnswer(ETaskResult result)
        {
            _taskController.Mark(result);
            Next();
        }

        public void Begin()
        {
            Next();
        }

        public void End()
        {
        }

        private void Next()
        {
            _taskController.Next();
            _screenController.ShowTask(_taskController.Task);
        }
    }
}