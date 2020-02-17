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
        List<Etel> etelek;
        //Get metódus ami visszaadja a lista tartalmát
        public List<Etel> getEtelek()
        {
            return etelek;
        }
        //Set metódus
        public void setEtelek(List<Etel> etelek)
        {
            this.etelek = etelek;
        }
        /// <summary>
        /// Az ételek listához hozzáadja a rekordokat az adatbázisból
        /// </summary>
        /// <returns>etelek lista</returns>
        public List<Etel> getEtelekAdatbazisbol()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                string query = Sql.getAllEtelekRecord();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["etel_id"]);
                    string nev = dr["enev"].ToString();
                    int fe = Convert.ToInt32(dr["feherje"]);
                    int sz = Convert.ToInt32(dr["szenhidrat"]);
                    int zs = Convert.ToInt32(dr["zsir"]);
                    string menny = dr["mennyiseg"].ToString();
                    Etel e = new Etel(id,nev,fe,sz,zs,menny);
                    etelek.Add(e);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Az ételek adatainak kiolvasása sikertelen");
            }
            return etelek;

        }
        /// <summary>
        /// Listából készít DataTablet a view-n való megjelenítéshez DGV-ben
        /// </summary>
        /// <returns>etelekDT - DataTable</returns>
        public DataTable getListabolDataTable()
        {
            DataTable etelekDT = new DataTable();
            etelekDT.Columns.Add("enev", typeof(string));
            etelekDT.Columns.Add("feherje", typeof(int));
            etelekDT.Columns.Add("szenhidrat", typeof(int));
            etelekDT.Columns.Add("zsir", typeof(int));
            etelekDT.Columns.Add("mennyiseg", typeof(string));
            foreach(Etel e in etelek)
            {
                etelekDT.Rows.Add(e.Nev, e.Feherje, e.Szenhidrat, e.Zsir, e.Mennyiseg);
            }
            return etelekDT;
        }
        /// <summary>
        /// Új étel hozzáadása az adatbázishoz (insert into)
        /// </summary>
        /// <param name="ujetel">Az új étel</param>
        public void AddEtelAdatbazishoz(Etel ujetel)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = ujetel.getInsertEtelek();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(ujetel + "etel hozzáadása nem sikerült.");
                throw new RepositoryException("Sikertelen hozzáadás az adatbázishoz.");
            }
        }

        /// <summary>
        /// Metódus új étel adathoz, ha az ételek lista üres akkor 1 es id vel tér vissza ha nem akkor megkeressük a legnagyobb id-t és hozzáadunk egyet
        /// </summary>
        /// <returns>A max id- hez hozzáadott plusz 1</returns>
        public int getEtelIDEtkezeshez()
        {
            if (etelek.Count == 0)
                return 1;
            else
                return etelek.Max(x => x.Id) + 1;
        }
        /// <summary>
        /// Új étel hozzáadása listához
        /// </summary>
        /// <param name="ujetel">Az új étel</param>
        public void AddEtelListahoz(Etel ujetel)
        {
            try
            {
                etelek.Add(ujetel);
            }
            catch (Exception e)
            {
                throw new RepositoryException("Az étel hozzáadása nem sikerült.");
            }
        }
        /// <summary>
        /// Lista törlése kapott paraméter alapján
        /// </summary>
        /// <param name="nev">A kapott paraméter ami alapján törlünk</param>
        public void torolEtelListabol(string nev)
        {
            Etel e = etelek.Find(x => x.Nev == nev);
            if (e != null)
            {
                etelek.Remove(e);
            }
            else
            {
                throw new RepositoryException("Sikertelen etel törlés a listából!");
            }
        }
        /// <summary>
        /// Étel törlése adatbázisból kapott paraméter alapján
        /// </summary>
        /// <param name="nev">A paraméter ami alapján törlünk</param>
        public void torolEtelAdatbazisbol(string nev)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM etelek WHERE enev=" +nev;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(nev + " idéjű etel törlése nem sikerült.");
                throw new RepositoryException("Sikertelen törlés az adatbázisból.");
            }
        }
    }
}
