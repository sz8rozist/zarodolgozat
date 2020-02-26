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
        List<Etel> etelek;
        public void setEtelek(List<Etel> etelek)
        {
            this.etelek = etelek;
        }
        public List<Etel> getEtelek()
        {
            return etelek;
        }
        public List<Etel> getEtelekFromDB()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Sql.getAllEtelekRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int etelid = Convert.ToInt32(dr["etel_id"]);
                    string enev = dr["enev"].ToString();
                    Etel etel = new Etel(etelid, enev);
                    etelek.Add(etel);
                    
                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Ételek beolvasása az adatbázisból nem sikerült!");
            }
            return etelek;
        }
        public DataTable EtelDataTableEtelekListabol()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("etel_id", typeof(int));
            dt.Columns.Add("enev", typeof(string));
            foreach(Etel etel in etelek)
            {
                dt.Rows.Add(etel.Etelid, etel.Enev);
            }
            return dt;
        }
        public int getEtelNevhezID(string nev)
        {
            return etelek.Find(x => x.Enev == nev).Etelid;
        }
        public int getKovetkezoEtelID()
        {
            return etelek.Max(x => x.Etelid) + 1;
        }
        public void InsertEtelek(Etel ujEtel)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = ujEtel.InsertEtel();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(ujEtel + " étel beszúrása adatbázisba nem sikerült.");
                throw new RepositoryException("Sikertelen beszúrás az adatbázisból.");
            }
        }
        public void AddEtelListahoz(Etel ujEtel)
        {
            try
            {
                etelek.Add(ujEtel);
            }
            catch (RepositoryException re)
            {
                throw new EtelekAddListahozException("Az étel hozzáadása listához nem járt sikerrel.");
            }
            
        }
    }
}
