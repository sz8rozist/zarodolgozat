using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Etel
    {
        private int etelid;
        private string enev;
        private int feherje;
        private int szenhidrat;
        private int zsir;
        private int kaloria;
        private string mennyiseg;

        public Etel(int etelid, string enev, int feherje, int szenhidrat, int zsir,int kaloria, string mennyiseg)
        {
            this.etelid = etelid;
            this.enev = enev;
            this.feherje = feherje;
            this.szenhidrat = szenhidrat;
            this.zsir = zsir;
            this.kaloria = kaloria;
            this.mennyiseg = mennyiseg;
        }
        public Etel(string enev, int feherje, int szenhidrat, int zsir, int kaloria, string mennyiseg)
        {
            this.enev = enev;
            this.feherje = feherje;
            this.szenhidrat = szenhidrat;
            this.zsir = zsir;
            this.kaloria = kaloria;
            this.mennyiseg = mennyiseg;
        }
        public int Etelid { get => etelid; set => etelid = value; }
        public string Enev { get => enev; set => enev = value; }
        public int Kaloria { get => kaloria; set => kaloria = value; }
        public int Feherje { get => feherje; set => feherje = value; }
        public int Szenhidrat { get => szenhidrat; set => szenhidrat = value; }
        public int Zsir { get => zsir; set => zsir = value; }
        public string Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

        public string getInsert()
        {
            return "INSERT INTO `etelek` (`enev`, `feherje`, `szenhidrat`, `zsir`, `kaloria`, `mennyiseg`) VALUES ('"+Enev+"', '"+Feherje+"', '"+Szenhidrat+"', '"+Zsir+"', '"+Kaloria+"', '"+Mennyiseg+"');";
        }
    }
}
