﻿using System;
using System.Windows;
using LoginWindow.Manager;

namespace LoginWindow.Models
{
    public class SignUpModel
    {
        private readonly Storage _storage;

        public SignUpModel(Storage storage)
        {
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
            NavigationManager.Instance.Navigate(ModesEnum.Login);
        }

    }
}
