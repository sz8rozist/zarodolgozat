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
        List<Etkezes> etkezesek;
        public List<Etkezes> getEtkezesek()
        {
            return etkezesek;
        }
        public void setEtkezesek(List<Etkezes> etkezesek)
        {
            this.etkezesek = etkezesek;
        }
        public List<Etkezes> getEtkezesekAdatbazisbol()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                string query = Sql.getEtkezesekAllRecord();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["etkezesek_id"]);
                    string idopont = dr["idopont"].ToString();
                    int etelid = Convert.ToInt32(dr["etel_id"]);
                    int fid = Convert.ToInt32(dr["f_id"]);
                    Etkezes etkezes = new Etkezes(id,idopont,etelid,fid);
                    etkezesek.Add(etkezes);
                }
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                Debug.WriteLine(e.Message);
                throw new RepositoryException("Az étkezések adatainak kiolvasása sikertelen");
            }
            return etkezesek;

        }
        public DataTable getEtkezesDTListabol()
        {
            DataTable etkezesDT = new DataTable();
            etkezesDT.Columns.Add("etkezesek_id", typeof(int));
            etkezesDT.Columns.Add("idopont", typeof(string));
            etkezesDT.Columns.Add("etel_id", typeof(int));
            etkezesDT.Columns.Add("f_id", typeof(int));
            foreach (Etkezes etkezes in etkezesek)
            {
                etkezesDT.Rows.Add(etkezes.Etkezesid,etkezes.Idopont,etkezes.Etelid,etkezes.Fid);
            }
            return etkezesDT;
        }
    }
}
