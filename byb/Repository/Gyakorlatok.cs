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
        List<Gyakorlat> gyakorlatok;
        public void SetGyakorlatok(List<Gyakorlat> gyakorlatok)
        {
            this.gyakorlatok = gyakorlatok;
        }
        public List<Gyakorlat> getGyakorlatok()
        {
            return gyakorlatok;
        }
        public List<Gyakorlat> getGyakorlatokFromDB()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Sql.getGyakorlatokAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int gyakorlatid = Convert.ToInt32(dr["gyakorlatok_id"]);
                    string gyakorlatnev = dr["gynev"].ToString();
                    int izomcsoportid = Convert.ToInt32(dr["izomcsoport_id"]);
                    string leiras = dr["leiras"].ToString();
                    Gyakorlat gy = new Gyakorlat(gyakorlatid,gyakorlatnev,izomcsoportid,leiras);
                    gyakorlatok.Add(gy);

                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                 throw new RepositoryException("Gyakorlatok beolvasása az adatbázisból nem sikerült!");
            }
            return gyakorlatok;
        }
    }
}
