using System.Windows;
using System.Windows.Controls;
using Practice2.Models;
using Practice2.ViewModels;

namespace Practice2.Views
{
    /// <summary>
    /// Interaction logic for SignUpView.xaml
    /// </summary>
    public partial class SignUpView : UserControl
    {

        private SignUpViewModel _signUpViewModel;

        public SignUpView(Storage storage)
        {
            InitializeComponent();
            _signUpViewModel = new SignUpViewModel(storage);
            DataContext = _signUpViewModel;
        }
    }
}
