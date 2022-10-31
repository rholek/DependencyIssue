using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace MainApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var assembly = Assembly.LoadFrom("MyPlugin.dll");
            foreach (var pluginType in assembly.GetTypes().Where(x => x.IsAssignableTo(typeof(IPlugin))))
            {
                var plugin = (IPlugin)Activator.CreateInstance(pluginType);
                plugin.Start();
            }
        }
    }
}
