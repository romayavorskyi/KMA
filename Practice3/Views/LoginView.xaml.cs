using System.Windows.Controls;
using Practice3.Models;
using Practice3.ViewModels;

namespace Practice3.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {

        private LoginViewModel _loginViewModel;

        public LoginView(Storage storage)
        {
            InitializeComponent();
            _loginViewModel = new LoginViewModel(storage);
            DataContext = _loginViewModel;
        }
    }
}
