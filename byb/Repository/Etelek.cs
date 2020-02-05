using byb.Database;
using byb.Modell;
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
    class Etelek
    {
        private readonly string connectionString;
        ConnectionString cs = new ConnectionString();
        //Ételek Lista
        List<Etel> etelek;
        public Etelek()
        {
            //Lista példányosítása
            etelek = new List<Etel>();
            //ConectionString
            connectionString = cs.getConnectionString();
        }
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
                string query = Etel.getAllEtelekRecord();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["etel_id"]);
                    string nev = dr["enev"].ToString();
                    int ka = Convert.ToInt32(dr["kaloria"]);
                    int fe = Convert.ToInt32(dr["feherje"]);
                    int sz = Convert.ToInt32(dr["szenhidrat"]);
                    int zs = Convert.ToInt32(dr["zsir"]);
                    string menny = dr["mennyiseg"].ToString();
                    Etel e = new Etel(id,nev,ka,fe,sz,zs,menny);
                    etelek.Add(e);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("A kiegészítők adatainak kiolvasása sikertelen");
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
            etelekDT.Columns.Add("kaloria", typeof(int));
            etelekDT.Columns.Add("feherje", typeof(int));
            etelekDT.Columns.Add("szenhidrat", typeof(int));
            etelekDT.Columns.Add("zsir", typeof(int));
            etelekDT.Columns.Add("mennyiseg", typeof(string));
            foreach(Etel e in etelek)
            {
                etelekDT.Rows.Add(e.Nev, e.Kaloria, e.Feherje, e.Szenhidrat, e.Zsir, e.Mennyiseg);
            }
            return etelekDT;
        }
    }
}
