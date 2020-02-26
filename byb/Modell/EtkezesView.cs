using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class EtkezesView
    {
        private int etkezesekid;
        private string enev;
        private string idopont;
        private int feherje;
        private int szenhidrat;
        private int zsir;
        private string mennyiseg;

        public EtkezesView(int etkezesekid, string enev, string idopont, int feherje, int szenhidrat, int zsir, string mennyiseg)
        {
            this.etkezesekid = etkezesekid;
            this.enev = enev;
            this.idopont = idopont;
            this.feherje = feherje;
            this.szenhidrat = szenhidrat;
            this.zsir = zsir;
            this.mennyiseg = mennyiseg;
        }

        public int Etkezesekid { get => etkezesekid; set => etkezesekid = value; }
        public string Enev { get => enev; set => enev = value; }
        public string Idopont { get => idopont; set => idopont = value; }
        public int Feherje { get => feherje; set => feherje = value; }
        public int Szenhidrat { get => szenhidrat; set => szenhidrat = value; }
        public int Zsir { get => zsir; set => zsir = value; }
        public string Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
    }
}
