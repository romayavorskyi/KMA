using System.Windows.Input;
using Practice3.Models;
using Practice3.Tools;

namespace Practice3.ViewModels
{
    class LoginViewModel : ObservableItem
    {
        private string _name;
        private string _password;

        private ICommand _loginCommand;
        private ICommand _signUpCommand;

        public LoginModel Model { get; private set; }

        public LoginViewModel(Storage storage)
        {
            Model = new LoginModel(storage);
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

        public ICommand LoginCommand
        {
            get
            {
                if (_loginCommand == null)
                {
                    _loginCommand = new RelayCommand<object>(LoginExecute, LoginCanExecute);
                }

                return _loginCommand;
            }
            set { ChangeAndNotify(ref _loginCommand, value, () => LoginCommand); }
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
            Model.ShowSignUpWindow();
        }

        private bool SignUpCanExecute(object obj)
        {
            return true;
        }

        private void LoginExecute(object obj)
        {
            Model.Login(Name, Password);
        }

        private bool LoginCanExecute(object obj)
        {
            return true;
        }
    }
}
