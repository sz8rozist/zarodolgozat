using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Edzes
    {
        private int edzesid;
        private string idopont;
        private int fid;
        private int edzestervid;

        public Edzes(int edzesid, string idopont, int fid, int edzestervid)
        {
            this.edzesid = edzesid;
            this.idopont = idopont;
            this.fid = fid;
            this.edzestervid = edzestervid;
        }

        public int Edzesid { get => edzesid; set => edzesid = value; }
        public string Idopont { get => idopont; set => idopont = value; }
        public int Fid { get => fid; set => fid = value; }
        public int Edzestervid { get => edzestervid; set => edzestervid = value; }
    }
}
