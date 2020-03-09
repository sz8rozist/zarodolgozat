using byb.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    /// <summary>
    /// Bejelentkezés osztály
    /// </summary>
    public class Login
    {
        /// <summary>
        /// Connection string az adatbázishoz való csatlakozáshoz
        /// </summary>
        ConnectionString cs = new ConnectionString();
        private string connectionString;
        /// <summary>
        /// A bejelentkezés adatai plusz a felhasználó azonosítója(id) ami mentésre kerül a bejelentkezés során
        /// </summary>
        private string username;
        private string password;
        private int id;
        private int tsuly;
        private int tmagassag;

        public int Tsuly { get => tsuly; set => tsuly = value; }
        public int Tmagassag { get => tmagassag; set => tmagassag = value; }

        /// <summary>
        /// Get metódusok
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Paraméteres konstruktor a bejelentkezéshez
        /// </summary>
        /// <param name="username">Felhasználónév</param>
        /// <param name="password">Jelszó</param>
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
                tsuly = Convert.ToInt32(dr["tsuly"]);
                tmagassag = Convert.ToInt32(dr["tmagassag"]);
                 return true;
            }
            else
            {
                return false;
            }
        }
    }
}
