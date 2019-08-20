using Core.Lesson;
using Core.Screen;
using Core.Task;

public class MainInfrastructure
{
    private readonly ScreenController _screenController;
    private readonly LessonController _lessonController;
    private readonly TaskController _taskController;

    public MainInfrastructure(MonoBehaviourStorage monoStorage)
    {
        _taskController = new TaskController();
        _screenController = new ScreenController(monoStorage.ScreenView);
        _lessonController = new LessonController(_screenController, _taskController);
    }
}