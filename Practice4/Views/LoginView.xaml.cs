using System.Windows.Controls;
using Practice4.Models;
using Practice4.ViewModels;

namespace Practice4.Views
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
