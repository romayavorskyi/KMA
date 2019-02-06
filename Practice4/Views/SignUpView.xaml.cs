using System.Windows.Controls;
using Practice4.Models;
using Practice4.ViewModels;

namespace Practice4.Views
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
