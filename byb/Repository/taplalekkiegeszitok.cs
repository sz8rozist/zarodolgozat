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
        List<Taplalekkiegeszito> kiegek;
        public void setKiegek(List<Taplalekkiegeszito> kiegek)
        {
            this.kiegek = kiegek;
        }
        public List<Taplalekkiegeszito> getKiegek()
        {
            return kiegek;
        }
        public List<Taplalekkiegeszito> getKiegekAdatbazisbol()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                string query = Sql.getKiegAdatok();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["k_id"]);
                    string knev = dr["knev"].ToString();
                    string tipus = dr["tipus"].ToString();
                    string gyarto = dr["gyarto"].ToString();
                    int kiszereles = Convert.ToInt32(dr["kiszereles"]);
                    string mertekegyseg = dr["ks_mertekegyseg"].ToString();
                    int f_id = Convert.ToInt32(dr["f_id"]);
                    Taplalekkiegeszito kieg = new Taplalekkiegeszito(id,knev,tipus,gyarto,kiszereles,mertekegyseg,f_id);
                    kiegek.Add(kieg);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Az étkezések adatainak kiolvasása sikertelen");
            }
            return kiegek;

        }
        /// <summary>
        /// Listából készít dataTable-t
        /// </summary>
        /// <returns>Data Table</returns>
        public DataTable getKiegDT()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("k_id", typeof(int));
            dt.Columns.Add("knev", typeof(string));
            dt.Columns.Add("tipus", typeof(string));
            dt.Columns.Add("gyarto", typeof(string));
            dt.Columns.Add("kiszereles", typeof(int));
            dt.Columns.Add("ks_mertekegyseg", typeof(string));
            foreach (Taplalekkiegeszito t in kiegek)
            {
                dt.Rows.Add(t.Kid,t.Knev,t.Tipus,t.Gyarto,t.Kiszereles,t.KsMertekE);
            }
            return dt;
        }
    }
}
