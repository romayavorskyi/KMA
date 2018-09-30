using System;
using System.Windows;
using System.Windows.Controls;
using LoginWindow.Models;

namespace LoginWindow.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {

        private LoginModel _loginModel;

        public LoginView(Storage storage)
        {
            InitializeComponent();
            _loginModel = new LoginModel(storage);
        }

        private void SignUpClicked(object sender, RoutedEventArgs e)
        {
            _loginModel.ShowSignUpWindow();
        }

        private void LogInClicked(object sender, RoutedEventArgs e)
        {
            _loginModel.Login(LoginTextBox.Text, PasswordTextBox.Text);
        }
    }
}
