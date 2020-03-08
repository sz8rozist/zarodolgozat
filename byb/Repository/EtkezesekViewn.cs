using byb.Modell;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Repository
{
    partial class Repo
    {
        List<EtkezesView> etkezesekviewn;
        public void setEtkezesekViewn(List<EtkezesView> etkezesekviewn)
        {
            this.etkezesekviewn = etkezesekviewn;
        }
        public List<EtkezesView> getEtkezesekViewn()
        {
            return etkezesekviewn;
        }
        public List<EtkezesView> getEtkezesekViewraFelhasznaloAlapjan(int fid,List<Etel> etelek,List<Etkezes> etkezesek)
        {
            List<Etkezes> etkezes = etkezesek.FindAll(x => x.Fid == fid);
            foreach(Etkezes e in etkezes)
            {
                Etel etel = etelek.Find(x => x.Etelid == e.Etelid);
                EtkezesView ev = new EtkezesView(
                        e.Etkezesekid,
                        etel.Enev,
                        e.Idopont,
                        e.Feherje,
                        e.Szenhidrat,
                        e.Zsir,
                        e.Mennyiseg
                    );
                etkezesekviewn.Add(ev);
            }
            return etkezesekviewn;
        }
        public DataTable getEtkezesekViewFelhasznaloAlapjanDT()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("etkezesek_id", typeof(int));
            dt.Columns.Add("enev", typeof(string));
            dt.Columns.Add("idopont", typeof(string));
            dt.Columns.Add("feherje", typeof(int));
            dt.Columns.Add("szenhidrat", typeof(int));
            dt.Columns.Add("zsir", typeof(int));
            dt.Columns.Add("mennyiseg", typeof(string));
            foreach(EtkezesView ev in etkezesekviewn)
            {
                dt.Rows.Add(ev.Etkezesekid, ev.Enev,ev.Idopont, ev.Feherje, ev.Szenhidrat, ev.Zsir, ev.Mennyiseg);
            }
            return dt;
        }
    }
}
