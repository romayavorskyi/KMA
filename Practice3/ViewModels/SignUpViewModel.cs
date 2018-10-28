using System.Windows.Input;
using Practice3.Models;
using Practice3.Tools;

namespace Practice3.ViewModels
{
    class SignUpViewModel: ObservableItem
    {

        private string _name;
        private string _password;

        private ICommand _signUpCommand;

        public SignUpModel Model { get; private set; }

        public SignUpViewModel(Storage storage)
        {
            Model = new SignUpModel(storage);
        }

        public string Name
        {
            get { return _name; }
            set { ChangeAndNotify(ref _name, value, () => Name); }
        }

        public string Password
        {
            get { return _password; }
            set { ChangeAndNotify(ref _password, value, () => Password); }
        }

        public ICommand SignUpCommand
        {
            get
            {
                if (_signUpCommand == null)
                {
                    _signUpCommand = new RelayCommand<object>(SignUpExecute, SignUpCanExecute);
                }

                return _signUpCommand;
            }
            set { ChangeAndNotify(ref _signUpCommand, value, () => SignUpCommand); }
        }

        private void SignUpExecute(object obj)
        {
            Model.SignUp(Name, Password);
        }

        private bool SignUpCanExecute(object obj)
        {
            return true;
        }

    }
}
