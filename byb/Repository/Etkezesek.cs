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
        List<Etkezes> etkezesek;
        public void setEtkezesek(List<Etkezes> etkezesek)
        {
            this.etkezesek = etkezesek;
        }
        public List<Etkezes> getEtkezesek()
        {
            return etkezesek;
        }
        public List<string> getIdopontok()
        {
            List<string> pontok = new List<string>();
            foreach(Etkezes e in etkezesek)
            {
                if (!pontok.Contains(e.Idopont))
                {
                    pontok.Add(e.Idopont);
                }
                
            }
            return pontok;
        }
        public List<Etkezes> getEtkezesekFromDB()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = Sql.getEtkezesekAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int etkezesekid = Convert.ToInt32(dr["etkezesek_id"]);
                    string idopont = dr["idopont"].ToString();
                    int etelid = Convert.ToInt32(dr["etel_id"]);
                    int fid = Convert.ToInt32(dr["f_id"]);
                    Etkezes etkezes = new Etkezes(etkezesekid,idopont,etelid,fid);
                    etkezesek.Add(etkezes);

                }
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Étkezések beolvasása az adatbázisból nem sikerült!");
            }
            return etkezesek;
        }
  
    }
}
