using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Practice2.Annotations;
using Practice2.Models;
using Practice2.Tools;

namespace Practice2.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
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
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
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
            set
            {
                _loginCommand = value;
                OnPropertyChanged(nameof(LoginCommand));
            }
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
            set
            {
                _signUpCommand = value;
                OnPropertyChanged(nameof(SignUpCommand));
            }
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

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
