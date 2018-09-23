using System;
using System.Windows;

namespace LoginWindow.Models
{
    public class SignUpModel
    {
        private readonly NavigationModel _navigationModel;
        private readonly Storage _storage;

        public SignUpModel(NavigationModel navigationModel, Storage storage)
        {
            _navigationModel = navigationModel;
            _storage = storage;
        }

        public void SignUp(string login, string password)
        {
            if (String.IsNullOrEmpty(login))
            {
                MessageBox.Show("User login is empty");
                return;
            }

            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("User password is empty");
                return;
            }

            if (_storage.Users.ContainsKey(login))
            {
                MessageBox.Show("User with entered login exists");
                return;
            }

            UserModel createdUser = new UserModel(login, password);
            _storage.Users.Add(createdUser.Login, createdUser);
            _navigationModel.Navigate(ModesEnum.Login);
        }

    }
}
