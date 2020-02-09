using byb.Database;
using byb.Modell;
using byb.Modell.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Repository
{
    partial class Repo
    {
        //Ételek Lista
        List<Felhasznalo> users;
        //Get metódus ami visszaadja a lista tartalmát
        public List<Felhasznalo> getFelhasznalok()
        {
            return users;
        }
        //Set metódus
        public void setFelhasznalok(List<Felhasznalo> users)
        {
            this.users = users;
        }
        /// <summary>
        /// Az ételek listához hozzáadja a rekordokat az adatbázisból
        /// </summary>
        /// <returns>etelek lista</returns>
        public List<Felhasznalo> getFelhasznalokAdatbazisbol()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                string query = Sql.getUsersAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["f_id"]);
                    string fname = dr["fname"].ToString();
                    string pw = dr["jelszo"].ToString();
                    string teljesnev = dr["teljesnev"].ToString();
                    string email = dr["email"].ToString();
                    int tsuly = Convert.ToInt32(dr["tsuly"]);
                    int tmagassag = Convert.ToInt32(dr["tmagassag"]);
                    Felhasznalo f = new Felhasznalo(id, fname, pw, teljesnev, email, tsuly, tmagassag);
                    users.Add(f);
                    
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("A felhasználók adatainak kiolvasása sikertelen");
            }
            return users;

        }
    }
}
