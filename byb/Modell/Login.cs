using byb.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Login
    {
        ConnectionString cs = new ConnectionString();
        private string connectionString;
        private string username;
        private string password;

        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        /// <summary>
        /// Belépés ellenőrzése
        /// </summary>
        /// <returns>true ha sikeres a belépés, false ha sikertelen</returns>
        public bool loginCheck()
        {
            
            connectionString = cs.getConnectionString();
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM felhasznalok WHERE fname = '" + username + "' AND jelszo = '" + password + "'; ";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                 return true;
            }
            else
            {
                return false;
            }
        }
    }
}
