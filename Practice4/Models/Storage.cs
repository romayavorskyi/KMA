using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Practice4.Models
{
    [Serializable]
    public class Storage
    {

        [field: NonSerialized]
        public event Action<UserModel> UserAdded;

        [JsonProperty("Users")]
        public Dictionary<string, UserModel> Users { get; private set; }
        [JsonProperty("CurrentUser")]
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
