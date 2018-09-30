using System.Windows;
using Practice2.Manager;

namespace Practice2.Models
{
    public class LoginModel
    {

        private Storage _storage;

        public LoginModel(Storage storage)
        {
            _storage = storage;
        }

        public void ShowSignUpWindow()
        {
            NavigationManager.Instance.Navigate(ModesEnum.SingUp);
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
                    NavigationManager.Instance.Navigate(ModesEnum.Main);
                }
            }
        }

    }
}
