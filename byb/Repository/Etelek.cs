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
                    int feherje = Convert.ToInt32(dr["feherje"]);
                    int szenhidrat = Convert.ToInt32(dr["szenhidrat"]);
                    int zsir = Convert.ToInt32(dr["zsir"]);
                    int kaloria = Convert.ToInt32(dr["kaloria"]);
                    string mennyiseg = dr["mennyiseg"].ToString();
                    Etel etel = new Etel(etelid, enev,feherje,szenhidrat,zsir,kaloria,mennyiseg);
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
        public List<Etel> getEtelEtelNevAlapjan(string etelnev)
        {
            return etelek.FindAll(x => x.Enev == etelnev);
        }
        public List<Etel> getEtelAdatai(string etelnev, int feherje, int ch,int zsir, int kcal,string mennyiseg)
        {
            List<Etel> eteladatai = etelek.FindAll(x => x.Enev == etelnev);
            foreach(Etel e in eteladatai)
            {
                feherje += e.Feherje;
                ch += e.Szenhidrat;
                zsir += e.Zsir;
                kcal += e.Kaloria;
                mennyiseg += e.Mennyiseg;
            }
            return eteladatai;

        }
        public List<string> getEtelNevek()
        {
            List<string> nevek = new List<string>();
            foreach(Etel e in etelek)
            {
                if (!nevek.Contains(e.Enev))
                    nevek.Add(e.Enev);
            }
            return nevek;
        }
        public void addEtelToList(Etel ujEtel)
        {
            try
            {
                etelek.Add(ujEtel);
            }
            catch (Exception e)
            {
                throw new RepositoryException("Az étel hozzáadása nem sikerült");
            }
        }
        public void insertEtelToDatabase(Etel ujEtel)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = ujEtel.getInsert();
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
        public void deleteEtelFromList(int id)
        {
            Etel p = etelek.Find(x => x.Etelid == id);
            Etkezes e = etkezesek.Find(x => x.Etelid == id);
            if (p != null && !etkezesek.Contains(e))
                etelek.Remove(p);
            else
                throw new RepositoryException("Az ételt nem lehetett törölni.");
        }
        public void deleteEtelFromDataBase(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM etelek WHERE etel_id=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(id + " idéjű étel törlése nem sikerült.");
                throw new RepositoryException("Sikertelen törlés az adatbázisból.");
            }
        }
        public int getNextEtelID()
        {
            return etelek.Max(x => x.Etelid) + 1;
        }

    }
}
