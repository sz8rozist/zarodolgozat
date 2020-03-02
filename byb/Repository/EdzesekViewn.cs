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
        List<EdzesViewn> edzesviewn;
        public void setListEdzesViewn(List<EdzesViewn> edzesviewn)
        {
            this.edzesviewn = edzesviewn;
        }
        public List<EdzesViewn> getEdzesViewn()
        {
            return edzesviewn;
        }
        public List<EdzesViewn> getEdzesekViewra(int fid, List<Gyakorlat> gyakorlatok, List<Edzesterv> edzestervek, List<Edzes> edzesek)
        {
            List<Edzes> e = edzesek.FindAll(x => (x.Fid == fid));

            foreach(Edzes edzes in e)
            {
                    Edzesterv terv = edzestervek.Find(x => x.Edzestervid == edzes.Edzestervid);
                    Gyakorlat gyak = gyakorlatok.Find(x => x.Gyakorlatokid == terv.Gyakorlatid);
                    EdzesViewn ev = new EdzesViewn(gyak.Gynev, terv.Sszam, terv.Iszam,edzes.Idopont);
                    edzesviewn.Add(ev);
            }
            return edzesviewn;
        }
        public List<EdzesViewn> getEdzesekViewraIdopontAlapjan(string idopont)
        {
            return edzesviewn.FindAll(x => x.Idopont == idopont);
        }
        public DataTable edzesewkviewnDT()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("gynev", typeof(string));
            dt.Columns.Add("sorozatszam", typeof(int));
            dt.Columns.Add("ismetlesszam", typeof(int));
            foreach(EdzesViewn ev in edzesviewn)
            {
                dt.Rows.Add(ev.Gyakorlatnev, ev.Sorozatszam, ev.Ismetlesszam);
            }
            return dt;
        }
    }
}
