using System;
using Newtonsoft.Json;

namespace Practice3.Models
{
    [Serializable]
    public class UserModel
    {

        [JsonProperty("Login")]
        public string Login { get; set; }
        [JsonProperty("Password")]
        public string Password { get; set; }

        public UserModel()
        {
        }

        public UserModel(string login, string password)
        {
            Login = login;
            Password = password;
        }

    }
}
