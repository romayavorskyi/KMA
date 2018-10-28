using System.Windows.Controls;
using Practice3.Models;
using Practice3.ViewModels;

namespace Practice3.Views
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
