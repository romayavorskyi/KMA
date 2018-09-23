using System.Windows;
using LoginWindow.Models;
using LoginWindow.Windows;

namespace LoginWindow
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Storage storage = new Storage();
            ContentWindow contentWindow = new ContentWindow();
            NavigationModel navigationModel = new NavigationModel(contentWindow, storage);
            contentWindow.Show();
            navigationModel.Navigate(ModesEnum.Login);
        }
    }
}
