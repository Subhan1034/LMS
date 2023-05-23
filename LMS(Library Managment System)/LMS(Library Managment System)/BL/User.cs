using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Library_Managment_System_.Bissuness_Logic
{
    public class User
    {
        protected string role;
        protected string name;
        protected string userName;
        protected string password;
        
        public User(string userName, string name, string password, string role)
        {
            this.userName = userName;
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public User(User user)
        {
            this.userName = user.userName;
            this.name = user.name;
            this.password = user.password;
            this.role = user.role;
        }
        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }

        public User(string userName, string password, string role)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
        }

        public string Role { get => role; set => role = value; }
        public string Name { get => name; set => name = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}
