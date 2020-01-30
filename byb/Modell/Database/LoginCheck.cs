using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace byb.Database
{
    class LoginCheck
    {
        ConnectionString cs = new ConnectionString();
        private readonly string connectionString;
        public string uname;
        public string pwd;
        public LoginCheck()
        {
            connectionString = cs.getConnectionString();
        }
        /// <summary>
        /// Belépés ellenőrzése
        /// </summary>
        /// <returns>true ha sikeres a belépés, false ha sikertelen</returns>
        public bool loginCheck()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM felhasznalok WHERE fname = '" + uname + "' AND jelszo = '" + pwd + "'; ";
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
