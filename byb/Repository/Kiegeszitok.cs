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
        List<Kiegeszito> tkiegek;
        public void setTkiegek(List<Kiegeszito> tkiegek)
        {
            this.tkiegek = tkiegek;
        }
        public List<Kiegeszito> getTkiegek()
        {
            return tkiegek;
        }
        public List<Kiegeszito> getHasznaltKiegeszitoAdatokAdatbazisbol()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                string query = Sql.getHasznaltKiegAdatok();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["id"]);
                    int kid = Convert.ToInt32(dr["k_id"]);
                    int fid = Convert.ToInt32(dr["f_id"]);
                    Kiegeszito k = new Kiegeszito(id, kid, fid);
                    tkiegek.Add(k);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("A használt kiegeszítők adatainak kiolvasása sikertelen");
            }
            return tkiegek;
        }
        public void AddujKieg(Kiegeszito ujkieg)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = ujkieg.insertIntoKiegeszito();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(ujkieg + "kiegeszito adat hozzáadása nem sikerült.");
                throw new RepositoryException("Sikertelen hozzáadás az adatbázishoz.");
            }
        }
        public void addUjKiegeszitoListahoz(Kiegeszito ujk)
        {
            try
            {
                tkiegek.Add(ujk);
            }
            catch (Exception e)
            {
                throw new RepositoryException("A táplálékkiegeszítő adatainak hozzáadása nem sikerült.");
            }
        }
    }
}
