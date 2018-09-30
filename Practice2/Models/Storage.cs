using System;
using System.Collections.Generic;

namespace Practice2.Models
{
    public class Storage
    {

        public event Action<UserModel> UserAdded;

        public Dictionary<string, UserModel> Users { get; private set; }
        public UserModel CurrentUser { get; set; }

        public Storage()
        {
            Users = new Dictionary<string, UserModel>();
        }

        public void AddUser(string login, string password)
        {
            UserModel createdUser = new UserModel(login, password);
            Users.Add(createdUser.Login, createdUser);
            UserAdded?.Invoke(createdUser);
        }
    }
}
