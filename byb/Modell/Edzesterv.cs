using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Edzesterv
    {
        private int edzestervid;
        private int gyakorlatid;
        private int sszam;
        private int iszam;

        public Edzesterv(int edzestervid, int gyakorlatid, int sszam, int iszam)
        {
            this.edzestervid = edzestervid;
            this.gyakorlatid = gyakorlatid;
            this.sszam = sszam;
            this.iszam = iszam;
        }

        public int Edzestervid { get => edzestervid; set => edzestervid = value; }
        public int Gyakorlatid { get => gyakorlatid; set => gyakorlatid = value; }
        public int Sszam { get => sszam; set => sszam = value; }
        public int Iszam { get => iszam; set => iszam = value; }
    }
}
