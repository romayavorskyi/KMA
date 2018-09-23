using System.Windows;

namespace LoginWindow.Models
{
    public class LoginModel
    {

        private Storage _storage;
        private NavigationModel _navigationModel;

        public LoginModel(NavigationModel navigationModel, Storage storage)
        {
            _storage = storage;
            _navigationModel = navigationModel;
        }

        public void ShowSignUpWindow()
        {
            _navigationModel.Navigate(ModesEnum.SingUp);
        }

        public void Login(string login, string password)
        {
            if (!_storage.Users.ContainsKey(login))
            {
                MessageBox.Show("Login or password is wrong");
            }
            else
            {
                if (_storage.Users[login].Password != password)
                {
                    MessageBox.Show("Login or password is wrong");
                }
                else
                {
                    _navigationModel.Navigate(ModesEnum.Main);
                }
            }
        }

    }
}
