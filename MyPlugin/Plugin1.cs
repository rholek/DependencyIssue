using MainApp;

namespace MyPlugin
{
    public class Plugin1 : IPlugin
    {
        public void Start()
        {
            var window = new TestWindow();
            window.ShowDialog();
        }
    }
}