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

        public Etel(int etelid, string enev)
        {
            this.etelid = etelid;
            this.enev = enev;
        }

        public int Etelid { get => etelid; set => etelid = value; }
        public string Enev { get => enev; set => enev = value; }
    }
}
