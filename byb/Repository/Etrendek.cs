using byb.Modell;
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
        private List<Etrend> etrendek;
       /* public Etrendek(int azon,List<Etel> etelek, List<Etkezes> etkezesek)
        {
            etrendek = new List<Etrend>();
            List<Etkezes> etk = etkezesek.FindAll(x => x.Fid == azon);
            foreach(Etkezes e in etk)
            {
                Etel etel = etelek.Find(x => x.Id == e.Etelid);
                if(etel != null)
                {
                    Etrend etrend = new Etrend(
                    azon,
                    e.Idopont,
                    etel.Nev,
                    etel.Feherje,
                    etel.Szenhidrat,
                    etel.Zsir,
                    etel.Mennyiseg
                    );
                    etrendek.Add(etrend);
                }
                
            }
        }*/
        public List<Etrend> getEtrendekListakbolUIDalapjan(int azon, List<Etel> etelek, List<Etkezes> etkezesek)
        {
            List<Etkezes> etk = etkezesek.FindAll(x => x.Fid == azon);
            foreach (Etkezes e in etk)
            {
                Etel etel = etelek.Find(x => x.Id == e.Etelid);
                if (etel != null)
                {
                    Etrend etrend = new Etrend(
                    azon,
                    e.Idopont,
                    etel.Nev,
                    etel.Feherje,
                    etel.Szenhidrat,
                    etel.Zsir,
                    etel.Mennyiseg
                    );
                    etrendek.Add(etrend);
                }

            }
            return etrendek;
        }
        public void setEtrendek(List<Etrend> etrendek)
        {
            this.etrendek = etrendek;
        }
        public List<Etrend> getEtrendek()
        {
            return etrendek;
        }
        public void AddEtrendItemToList(Etrend ujetrend)
        {
            try
            {
                etrendek.Add(ujetrend);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
        }
        public DataTable getEtrendDT()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("idopont",typeof(string));
            dt.Columns.Add("enev",typeof(string));
            dt.Columns.Add("feherje",typeof(int));
            dt.Columns.Add("szenhidrat",typeof(int));
            dt.Columns.Add("zsir",typeof(int));
            dt.Columns.Add("mennyiseg",typeof(string));

            foreach(Etrend etrend in etrendek)
            {
                dt.Rows.Add(etrend.Idopont, etrend.Etelnev, etrend.Feherje,etrend.Szenhidrat,etrend.Zsir,etrend.Menny);
            }
            return dt;
        }

    }
}
