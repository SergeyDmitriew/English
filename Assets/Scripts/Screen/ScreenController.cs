namespace Core.Screen
{
    public class ScreenController : IScreenListener
    {
        private readonly ScreenView _screenView;

        public ScreenController(ScreenView screenView)
        {
            _screenView = screenView;
        }
    }
}