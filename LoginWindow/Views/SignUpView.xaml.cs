using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LoginWindow.Models;

namespace LoginWindow.Views
{
    /// <summary>
    /// Interaction logic for SignUpView.xaml
    /// </summary>
    public partial class SignUpView : UserControl
    {

        private SignUpModel _signUpModel;

        public SignUpView(Storage storage)
        {
            InitializeComponent();
            _signUpModel = new SignUpModel(storage);
        }

        private void OnSignUpClicked(object sender, RoutedEventArgs e)
        {
            _signUpModel.SignUp(LoginTextBox.Text, PasswordTextBox.Text);
        }
    }
}
