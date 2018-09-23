using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWindow.Models
{
    public class UserModel
    {

        public string Login { get; private set; }
        public string Password { get; private set; }

        public UserModel(string login, string password)
        {
            Login = login;
            Password = password;
        }

    }
}
