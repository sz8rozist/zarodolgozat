using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class EtkezesView
    {
        private int etkezesid;
        private string enev;
        private string idopont;
        private int feherje;
        private int szenhidrat;
        private int zsir;
        private int kaloria;
        private string mennyiseg;

        public EtkezesView(int etkezesid, string enev, string idopont, int feherje, int szenhidrat, int zsir, int kaloria, string mennyiseg)
        {
            this.etkezesid = etkezesid;
            this.enev = enev;
            this.idopont = idopont;
            this.feherje = feherje;
            this.szenhidrat = szenhidrat;
            this.zsir = zsir;
            this.mennyiseg = mennyiseg;
            this.kaloria = kaloria;
        }
        public EtkezesView(string enev, string idopont, int feherje, int szenhidrat, int zsir, int kaloria, string mennyiseg)
        {
            this.enev = enev;
            this.idopont = idopont;
            this.feherje = feherje;
            this.szenhidrat = szenhidrat;
            this.zsir = zsir;
            this.mennyiseg = mennyiseg;
            this.kaloria = kaloria;
        }

        public string Enev { get => enev; set => enev = value; }
        public string Idopont { get => idopont; set => idopont = value; }
        public int Feherje { get => feherje; set => feherje = value; }
        public int Szenhidrat { get => szenhidrat; set => szenhidrat = value; }
        public int Zsir { get => zsir; set => zsir = value; }
        public string Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        public int Kaloria { get => kaloria; set => kaloria = value; }
        public int Etkezesid { get => etkezesid; set => etkezesid = value; }
    }
}
