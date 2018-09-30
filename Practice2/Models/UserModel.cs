namespace Practice2.Models
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
