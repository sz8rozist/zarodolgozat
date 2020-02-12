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
                Etrend etrend = new Etrend(
                    e.Etkezesid,
                    azon,
                    e.Idopont,
                    etel.Nev
                    );
                etrendek.Add(etrend);
            }
        }
        public DataTable getEtrendDT()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("etkezesek_id",typeof(int));
            dt.Columns.Add("idopont",typeof(string));
            dt.Columns.Add("enev",typeof(string));

            foreach(Etrend etrend in etrendek)
            {
                dt.Rows.Add(etrend.Etkezesid,etrend.Idopont, etrend.Etelnev);
            }
            return dt;
        }
    }
}
