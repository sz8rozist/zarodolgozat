using byb.Database;
using byb.Modell;
using byb.Modell.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Repository
{
    partial class Repo
    {
        List<Taplalekkiegeszito> tkiegek;
       public List<Taplalekkiegeszito> getTkiegek()
        {
            return tkiegek;
        }
        public void setTkiegek(List<Taplalekkiegeszito> tkiegek)
        {
            this.tkiegek = tkiegek;
        }
        public List<Taplalekkiegeszito> getTaplalekkiegeszitokAdatbazisbol()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                string query = Sql.getAllTkiegRecord();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["k_id"]);
                    string nev = dr["knev"].ToString();
                    string tipus = dr["tipus"].ToString();
                    string gyarto = dr["gyarto"].ToString();
                    int kiszereles = Convert.ToInt32(dr["kiszereles"]);
                    string kme = dr["ks_mertekegyseg"].ToString();
                    Taplalekkiegeszito t = new Taplalekkiegeszito(id, nev, tipus, gyarto, kiszereles, kme);
                    tkiegek.Add(t);
                }
                con.Close();
            }catch(Exception e)
            {
                con.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("A kiegészítők adatainak kiolvasása sikertelen");
            }
            return tkiegek;

        }
    }
}
