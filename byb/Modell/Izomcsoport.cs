using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Izomcsoport
    {
        private int izomcsoportid;
        private string izomcsoportNev;

        public Izomcsoport(int izomcsoportid, string izomcsoportNev)
        {
            this.izomcsoportid = izomcsoportid;
            this.izomcsoportNev = izomcsoportNev;
        }

        public int Izomcsoportid { get => izomcsoportid; set => izomcsoportid = value; }
        public string IzomcsoportNev { get => izomcsoportNev; set => izomcsoportNev = value; }
    }
}
