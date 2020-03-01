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
        List<Edzesterv> tervek;
        public void setTervek(List<Edzesterv> tervek)
        {
            this.tervek = tervek;
        }
        public List<Edzesterv> getTervek()
        {
            return tervek;
        }
        public List<Edzesterv> getedzestervekFromDB()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Sql.getEdzestervekAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int edzestervid = Convert.ToInt32(dr["edzesterv_id"]);
                    int gyakorlatid = Convert.ToInt32(dr["gyakorlat_id"]);
                    int sorozatszam = Convert.ToInt32(dr["sorozatszam"]);
                    int ismetlesszam = Convert.ToInt32(dr["ismetlesszam"]);
                    Edzesterv terv = new Edzesterv(edzestervid, gyakorlatid, sorozatszam, ismetlesszam);
                    tervek.Add(terv);

                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Edzéstervek beolvasása az adatbázisból nem sikerült!");
            }
            return tervek;
        }
    }
}
