using System.Windows;
using System.Windows.Controls;
using Practice2.Models;
using Practice2.ViewModels;

namespace Practice2.Views
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
