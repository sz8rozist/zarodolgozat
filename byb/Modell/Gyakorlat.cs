using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Gyakorlat
    {
        private int gyakorlatokid;
        private string gynev;
        private int izomcsoportid;
        private string leiras;

        public Gyakorlat(int gyakorlatokid, string gynev, int izomcsoportid, string leiras)
        {
            this.gyakorlatokid = gyakorlatokid;
            this.gynev = gynev;
            this.izomcsoportid = izomcsoportid;
            this.leiras = leiras;
        }

        public int Gyakorlatokid { get => gyakorlatokid; set => gyakorlatokid = value; }
        public string Gynev { get => gynev; set => gynev = value; }
        public int Izomcsoportid { get => izomcsoportid; set => izomcsoportid = value; }
        public string Leiras { get => leiras; set => leiras = value; }
    }
}
