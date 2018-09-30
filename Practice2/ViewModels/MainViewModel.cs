using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice2.Models;
using Practice2.Tools;

namespace Practice2.ViewModels
{
    class MainViewModel: ObservableItem
    {
        private ObservableCollection<UserModel> _users;

        public MainModel Model { get; private set; }

        public ObservableCollection<UserModel> Users
        {
            get { return _users; }
            set { ChangeAndNotify(ref _users, value, () => Users); }
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
    }
}
