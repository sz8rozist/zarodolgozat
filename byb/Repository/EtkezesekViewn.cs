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
                        etel.Enev,
                        e.Idopont,
                        etel.Feherje,
                        etel.Szenhidrat,
                        etel.Zsir,
                        etel.Kaloria,
                        etel.Mennyiseg
                    );
                etkezesekviewn.Add(ev);
            }
            return etkezesekviewn;
        }
        public List<EtkezesView> getEtkezesIdopontAlapjan(string idopont)
        {
            return etkezesekviewn.FindAll(x => x.Idopont == idopont);
        }
        public int getOsszFeherje(string idopont)
        {
            List<EtkezesView> etkezesview = etkezesekviewn.FindAll(x => x.Idopont == idopont);
            int totalfeherje = 0;
            foreach(EtkezesView evv in etkezesview)
            {
                totalfeherje = totalfeherje + evv.Feherje;
            }
            return totalfeherje;
        }
        public int getOsszSzenhidrat(string idopont)
        {
            List<EtkezesView> etkezesview = etkezesekviewn.FindAll(x => x.Idopont == idopont);
            int totalszenhidrat = 0;
            foreach (EtkezesView evv in etkezesview)
            {
                totalszenhidrat = totalszenhidrat + evv.Szenhidrat;
            }
            return totalszenhidrat;
        }
        public int getOsszZsir(string idopont)
        {
            List<EtkezesView> etkezesview = etkezesekviewn.FindAll(x => x.Idopont == idopont);
            int totalzsir = 0;
            foreach (EtkezesView evv in etkezesview)
            {
                totalzsir = totalzsir + evv.Zsir;
            }
            return totalzsir;
        }
        public int getOsszKaloria(string idopont)
        {
            List<EtkezesView> etkezesview = etkezesekviewn.FindAll(x => x.Idopont == idopont);
            int totalkaloria = 0;
            foreach (EtkezesView evv in etkezesview)
            {
                totalkaloria = totalkaloria + evv.Kaloria;
            }
            return totalkaloria;
        }
        public void addEtkezesViewnToLIst(EtkezesView ujEtkezesView)
        {
            try
            {
                etkezesekviewn.Add(ujEtkezesView);
            }
            catch (Exception e)
            {
                throw new RepositoryException("Az étkezésviewn hozzáadása nem sikerült");
            }
        }
    }
}
