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
        //tkiegek lista
        List<Taplalekkiegeszito> tkiegek;
        //lista set - get metódusok
       public List<Taplalekkiegeszito> getTkiegek()
        {
            return tkiegek;
        }
        public void setTkiegek(List<Taplalekkiegeszito> tkiegek)
        {
            this.tkiegek = tkiegek;
        }
        //Adatbázis rekordok hozzáadása listához
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
        public DataTable getTkiegekListabolDT()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("k_id", typeof(int));
            dt.Columns.Add("knev", typeof(string));
            dt.Columns.Add("tipus", typeof(string));
            dt.Columns.Add("gyarto", typeof(string));
            dt.Columns.Add("kiszereles", typeof(int));
            dt.Columns.Add("ks_mertekegyseg", typeof(string));
            foreach (Taplalekkiegeszito t in tkiegek)
            {
                dt.Rows.Add(t.Id, t.Nev, t.Tipus, t.Gyarto, t.Kiszereles, t.Kme);
            }
            return dt;
        }
        public List<String> getTipusok()
        {
            List<String> tipus = new List<string>();
            foreach(Taplalekkiegeszito t in tkiegek)
            {
                if(!tipus.Contains(t.Tipus))
                    tipus.Add(t.Tipus);
            }
            return tipus;
        }
    }
}
