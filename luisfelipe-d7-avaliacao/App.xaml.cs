using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace luisfelipe_d7_avaliacao
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;

        public App()
        {
           
        }

        private void OnStartup(object s, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();

            mainWindow.Show();
        }
    }
}

