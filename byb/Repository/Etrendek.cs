using byb.Modell;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Repository
{
    class Etrendek
    {
        private List<Etrend> etrendek;
        public Etrendek(int azon,List<Etel> etelek, List<Etkezes> etkezesek)
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
        }
        public Etrendek()
        {

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
        public void AddEtrendItemToList(Etrend ujetrend)
        {
            etrendek.Add(ujetrend);
        }
    }
}
