using System;
using System.Collections.Generic;
using System.Text;

namespace Brivia.Device.Models
{
    public class UserModel
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public UserModel(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
    }
}
