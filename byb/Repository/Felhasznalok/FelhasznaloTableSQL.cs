using byb.Modell;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using byb.Database;
using System.Diagnostics;
using byb.Modell.Database;

namespace byb.Repository.Felhasznalok
{
    class FelhasznaloTableSQL
    {
        private readonly string constring;
        public FelhasznaloTableSQL()
        {
            ConnectionString cs = new ConnectionString();
            constring = cs.getConnectionString();
        }
        public List<Felhasznalo> getFelhasznalokFromFelhasznaloTable()
        {
            List<Felhasznalo> felhasznalok = new List<Felhasznalo>();
            MySqlConnection con = new MySqlConnection(constring);
            try
            {
                con.Open();
                string query = FelhasznaloDatabase.FelhasznaloAdatokAdatbazisbol();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["f_id"]);
                    string fname = dr["fname"].ToString();
                    string jelszo = dr["jelszo"].ToString();
                    string teljesnev = dr["teljesnev"].ToString();
                    string email = dr["email"].ToString();
                    int tsuly = Convert.ToInt32(dr["tsuly"]);
                    int tmagassag = Convert.ToInt32(dr["tmagassag"]);

                    Felhasznalo f = new Felhasznalo(id,fname,jelszo,teljesnev,email,tsuly,tmagassag);
                    felhasznalok.Add(f);
                }
                return felhasznalok;
            }
            catch (Exception e)
            {
                con.Close();
                Debug.WriteLine(e.Message);
                throw new FelhasznalokException("A felhasználók adatainak beolvasása sikertelen!");
            }
        } 
    }
}
