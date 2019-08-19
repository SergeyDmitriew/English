using Core.Screen;

public class MainInfrastructure
{
    private readonly ScreenController _screenController;

    public MainInfrastructure(MonoBehaviourStorage monoStorage)
    {
        _screenController = new ScreenController(monoStorage.ScreenView);
    }
}