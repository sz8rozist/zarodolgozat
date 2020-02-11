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
        //étkezések lista
        List<Etkezes> etkezesek;
        //lista set-get metódusok
        public List<Etkezes> getEtkezesek()
        {
            return etkezesek;
        }
        public void setEtkezesek(List<Etkezes> etkezesek)
        {
            this.etkezesek = etkezesek;
        }
        /// <summary>
        /// Étkezés rekordok hozzáadása listához adatbázisból
        /// </summary>
        /// <returns>etkezesek lista</returns>
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
        /// <summary>
        /// Listából készít dataTable-t
        /// </summary>
        /// <returns>Data Table</returns>
        public DataTable getEtkezesDTListabol()
        {
            DataTable etkezesDT = new DataTable();
            etkezesDT.Columns.Add("etkezesek_id", typeof(int));
            etkezesDT.Columns.Add("idopont", typeof(string));
            etkezesDT.Columns.Add("etel_id", typeof(int));
            etkezesDT.Columns.Add("f_id", typeof(int));
            foreach (Etkezes etkezes in etkezesek)
            {
                    etkezesDT.Rows.Add(etkezes.Etkezesid, etkezes.Idopont, etkezes.Etelid,etkezes.Fid);
            }
            return etkezesDT;
        }
        //Id alapján töröl a listából
        public void torolEtkezesListabol(int id)
        {
            Etkezes etkezes = etkezesek.Find(x => x.Etkezesid == id);
            if (etkezes != null)
            {
                etkezesek.Remove(etkezes);
            }
            else
            {
                throw new RepositoryException("Sikertelen etkezes törlés a listából!");
            }
        }
        //id alapján töröl az adatbázisból
        public void torolEtkezesAdatbazisbol(int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM etkezesek WHERE etkezesek_id=" + id;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(id + " idjű etkezes törlése nem sikerült.");
                throw new RepositoryException("Sikertelen törlés az adatbázisból.");
            }
        }
        public void AddEtkezesListahoz(Etkezes ujetkezes)
        {
            try
            {
                etkezesek.Add(ujetkezes);
            }
            catch (Exception e)
            {
                throw new RepositoryException("Az étkezés hozzáadása nem sikerült.");
            }
        }
        public int getKovetkezoEtkezesID()
        {
            if (etkezesek.Count == 0)
                return 1;
            else
                return etkezesek.Max(x => x.Etkezesid) + 1;
        }
    }
}
