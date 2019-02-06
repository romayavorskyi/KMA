using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Practice4.Models;
using Practice4.Tools;

namespace Practice4.ViewModels
{
    class MainViewModel: ObservableItem
    {
        private ObservableCollection<UserModel> _users;
        private ICommand _magicComand;
        private bool _loaderVisible = false;

        public bool LoaderVisible
        {
            get { return _loaderVisible; }
            set
            {
                _loaderVisible = value;
                OnPropertyChanged();
            }
        }

        public ICommand MagicCommand
        {
            get
            {
                if (_magicComand == null)
                {
                    _magicComand = new RelayCommand<object>(MagicCommandExecute);
                }

                return _magicComand;
            }
            set { ChangeAndNotify(ref _magicComand, value, () => MagicCommand); }
        }

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

        private async void MagicCommandExecute(object obj)
        {
            //AddUserModelInOtherThread();
            //LoaderVisible = true;
            //await Model.DoLongOperation();
            //LoaderVisible = false;
            Model.DoMagic();
        }

        private void AddUserModelInOtherThread()
        {
            //Task.Factory.StartNew(() =>
            //{
            //        Users.Add(new UserModel("test", "test"));
            //});
            Task.Factory.StartNew(() =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    Users.Add(new UserModel("test", "test"));
                });
            });
        }

    }
}
