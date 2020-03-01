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
        List<Edzes> edzesek;
        public void setEdzesek(List<Edzes> edzesek)
        {
            this.edzesek = edzesek;
        }
        public List<Edzes> getEdzesek()
        {
            return edzesek;
        }
        public List<Edzes> getEdzesekFromDB()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Sql.getEdzesekAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int edzesid = Convert.ToInt32(dr["edzesek_id"]);
                    string idopont = dr["idopont"].ToString();
                    int fid = Convert.ToInt32(dr["f_id"]);
                    int edzestervid = Convert.ToInt32(dr["edzesterv_id"]);
                    Edzes e = new Edzes(edzesid,idopont,fid,edzestervid);
                    edzesek.Add(e);

                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Edzések beolvasása az adatbázisból nem sikerült!");
            }
            return edzesek;
        }
        public List<string> getIdopontok()
        {
            List<string> idopont = new List<string>();
            foreach(Edzes e in edzesek)
            {
                idopont.Add(e.Idopont);
            }
            return idopont;
        }
    }
}
