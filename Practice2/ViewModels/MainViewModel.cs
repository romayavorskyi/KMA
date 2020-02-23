using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Practice2.Annotations;
using Practice2.Models;
using Practice2.Tools;

namespace Practice2.ViewModels
{
    class MainViewModel: INotifyPropertyChanged
    {
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
