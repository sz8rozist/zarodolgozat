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
                    int feherje = Convert.ToInt32(dr["feherje"]);
                    int szenhidrat = Convert.ToInt32(dr["szenhidrat"]);
                    int zsir = Convert.ToInt32(dr["zsir"]);
                    string mennyiseg = dr["mennyiseg"].ToString();
                    int fid = Convert.ToInt32(dr["f_id"]);
                    Etkezes etkezes = new Etkezes(etkezesekid,idopont,etelid,feherje,szenhidrat,zsir,mennyiseg,fid);
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
        public void InsertEtkezes(Etkezes ujEtkezes)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = ujEtkezes.InsertIntoEtkezesek();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(ujEtkezes + " étkezés beszúrása adatbázisba nem sikerült.");
            }
        }
        public void AddEtkezesListahoz(Etkezes ujEtkezes)
        {
            try
            {
                etkezesek.Add(ujEtkezes);
            }catch(RepositoryException re)
            {
                throw new EtkezesekAddListahozException("Az étkezés listához adása nem járt sikerrel");
            }
            
        }
        public int KovetkezoEtkezesID()
        {
            if (etkezesek.Count == 0)
                return 1;
            else
                return etkezesek.Max(x => x.Etkezesekid) + 1;
        }
        public void TorolEtkezesListabol(int etkid)
        {
            Etkezes e = etkezesek.Find(x => x.Etkezesekid == etkid);
            if (e != null)
                etkezesek.Remove(e);
            else
                throw new TorlesEtkezesException("Az étkezés nem létezik, sikertelen törlés a listából!");
        }
        public void DeletEtkezes(int etkid)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                string query = "DELETE FROM etkezesek WHERE etkezesek_id= "+etkid;
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                connection.Close();
                Debug.WriteLine(e.Message);
                Debug.WriteLine(etkid + " idjű étkezés törlése az adatbázisból nem sikerült.");
            }
        }
    }
}
