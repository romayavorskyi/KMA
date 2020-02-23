using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Practice2.Annotations;
using Practice2.Models;
using Practice2.Tools;

namespace Practice2.ViewModels
{
    class SignUpViewModel: INotifyPropertyChanged
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
            Model.SignUp(Name, Password);
        }

        private bool SignUpCanExecute(object obj)
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
