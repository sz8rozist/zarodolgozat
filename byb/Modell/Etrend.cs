using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Etrend
    {
        private int fid;
        private string idopont;
        private string etelnev;
        private int feherje;
        private int szenhidrat;
        private int zsir;
        private string menny;
        public Etrend(int fid,string idopont,string etelnev, int feherje, int szenhidrat, int zsir,string menny)
        {
            this.fid = fid;
            this.idopont = idopont;
            this.etelnev = etelnev;
            this.feherje = feherje;
            this.szenhidrat = szenhidrat;
            this.zsir = zsir;
            this.menny = menny;
        }
        public int Fid { get => fid; set => fid = value; }
        public string Idopont { get => idopont; set => idopont = value; }
        public string Etelnev { get => etelnev; set => etelnev = value; }
        public int Feherje { get => feherje; set => feherje = value; }
        public int Szenhidrat { get => szenhidrat; set => szenhidrat = value; }
        public int Zsir { get => zsir; set => zsir = value; }
        public string Menny { get => menny; set => menny = value; }
    }
}
