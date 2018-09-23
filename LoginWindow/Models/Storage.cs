using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWindow.Models
{
    public class Storage
    {
        public Dictionary<string, UserModel> Users { get; private set; }
        public UserModel CurrentUser { get; set; }

        public Storage()
        {
            Users = new Dictionary<string, UserModel>();
        }

    }
}
