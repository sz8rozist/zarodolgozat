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
        List<KiegAdat> kiegek;
        public void setKiegek(List<KiegAdat> kiegek)
        {
            this.kiegek = kiegek;
        }
        public List<KiegAdat> getKiegek()
        {
            return kiegek;
        }
        public List<KiegAdat> getKiegekAdatbazisbol()
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
                    KiegAdat kieg = new KiegAdat(id,knev,tipus,gyarto);
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
            foreach (KiegAdat t in kiegek)
            {
                dt.Rows.Add(t.Kid,t.Knev,t.Tipus,t.Gyarto);
            }
            return dt;
        }
        public void AddUjKiegAdatDB(KiegAdat ujkiegadat)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = ujkiegadat.insertIntoKiegAdatok();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(ujkiegadat + "kiegeszito adat hozzáadása nem sikerült.");
                throw new RepositoryException("Sikertelen hozzáadás az adatbázishoz.");
            }
        }
        public void addUjKiegAdatListahoz(KiegAdat ujkiegadat)
        {
            try
            {
                kiegek.Add(ujkiegadat);
            }
            catch (Exception e)
            {
                throw new RepositoryException("A táplálékkiegeszítő adatainak hozzáadása nem sikerült.");
            }
        }
        public int getKiegIDKiegeszitoTablaba()
        {
            return kiegek.Max(x => x.Kid) +1;
        }
    
    }
}
