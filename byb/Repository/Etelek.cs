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
    }
}
