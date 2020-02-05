using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Etel
    {
        private int id;
        private string nev;
        private int kaloria;
        private int feherje;
        private int zsir;
        private int szenhidrat;
        private string mennyiseg;

        public Etel(int id, string nev, int kaloria, int feherje, int zsir, int szenhidrat, string mennyiseg)
        {
            this.id = id;
            this.nev = nev;
            this.kaloria = kaloria;
            this.feherje = feherje;
            this.zsir = zsir;
            this.szenhidrat = szenhidrat;
            this.mennyiseg = mennyiseg;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Kaloria { get => kaloria; set => kaloria = value; }
        public int Feherje { get => feherje; set => feherje = value; }
        public int Zsir { get => zsir; set => zsir = value; }
        public int Szenhidrat { get => szenhidrat; set => szenhidrat = value; }
        public string Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

        public static string getAllEtelekRecord()
        {
            return "SELECT * FROM etelek";
        }
    }
}
