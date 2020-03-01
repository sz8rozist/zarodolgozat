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
        List<Izomcsoport> izomcsoportok;
        public void setIzomcsoportok(List<Izomcsoport> izomcsoportok)
        {
            this.izomcsoportok = izomcsoportok;
        }
        public List<Izomcsoport> getIzomcsoportok()
        {
            return izomcsoportok;
        }
        public List<Izomcsoport> getIzomcsoportokFromDB()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Sql.getIzomcsoportokAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int izomcsoportid = Convert.ToInt32(dr["izomcsoport_id"]);
                    string izomcsoport = dr["izomcsoport"].ToString();
                    Izomcsoport gy = new Izomcsoport(izomcsoportid,izomcsoport);
                    izomcsoportok.Add(gy);

                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Izomcsoportok beolvasása az adatbázisból nem sikerült!");
            }
            return izomcsoportok;
        }
        public List<string> getIzomcsoportNevek()
        {
            List<string> inevek = new List<string>();
            foreach (Izomcsoport izom in izomcsoportok)
            {
                inevek.Add(izom.IzomcsoportNev);
            }
            return inevek;
        }
    }
}
