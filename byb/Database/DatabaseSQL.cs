using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Database
{
    class DatabaseSQL
    {
        public string SelectUsersLogin(string username, string password)
        {
            return "SELECT * FROM vendegek WHERE nev='" + username + "' AND jelszo='" + password + "'";
        }
    }
}
