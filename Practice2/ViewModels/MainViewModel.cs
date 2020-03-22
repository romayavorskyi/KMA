using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
    class MainViewModel: INotifyPropertyChanged
    {

        private ICommand _addCommand;
        private ICommand _deleteCommand;
        private ICommand _modifyCommand;

        private ObservableCollection<UserModel> _users;

        public MainModel Model { get; private set; }

        public ObservableCollection<UserModel> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }
        }

        public ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new RelayCommand<object>(AddExecute);
                }

                return _addCommand;
            }
            set
            {
                _addCommand = value;
                OnPropertyChanged(nameof(AddCommand));
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                {
                    _deleteCommand = new RelayCommand<object>(DeleteExecute);
                }

                return _deleteCommand;
            }
            set
            {
                _addCommand = value;
                OnPropertyChanged(nameof(DeleteCommand));
            }
        }

        public ICommand ModifyCommand
        {
            get
            {
                if (_modifyCommand == null)
                {
                    _modifyCommand = new RelayCommand<object>(ModifyExecute);
                }

                return _modifyCommand;
            }
            set
            {
                _modifyCommand = value;
                OnPropertyChanged(nameof(ModifyCommand));
            }
        }

        private void ModifyExecute(object obj)
        {
            if (Users.Any())
            {
                Users[0].Login = "Modify";
            }
        }

        private void AddExecute(object obj)
        {
            Users.Add(new UserModel("Add", "Add"));
        }

        private void DeleteExecute(object obj)
        {
            if (Users.Any())
            {
                Users.RemoveAt(0);
            }
        }

        public MainViewModel(Storage storage)
        {
            Users = new ObservableCollection<UserModel>();
            Model = new MainModel(storage);
            Model.UIUserAdded += UIOnUserAdded;
        }

        private void UIOnUserAdded(UserModel user)
        {
            Users.Add(user);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
