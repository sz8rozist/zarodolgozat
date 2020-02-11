using byb.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    public class Login
    {
        //Connection string az adatbázishoz való csatlakozáshoz
        ConnectionString cs = new ConnectionString();
        private string connectionString;
        //Bejelentkezés adatai username - password és egy id
        private string username;
        private string password;
        private int id;
        //get metódusok
        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        public int getLoginId()
        {
            return id;
        }
        //konstruktor a view-n való bejelentkezéshez username és password paraméterekkel
        public Login(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        /// <summary>
        /// Belépés ellenőrzése
        /// </summary>
        /// <returns>true ha sikeres a belépés és az id-be elmentjük az adatbázisból az f_id-t, false ha sikertelen</returns>
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
                id = Convert.ToInt32(dr["f_id"]);
                 return true;
            }
            else
            {
                return false;
            }
        }
    }
}
