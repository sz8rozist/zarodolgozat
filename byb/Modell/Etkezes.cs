using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Etkezes
    {
        private int etkezesid;
        private string idopont;
        private int etelid;
        private int fid;

        public Etkezes(int etkezesid, string idopont, int etelid, int fid)
        {
            this.etkezesid = etkezesid;
            this.idopont = idopont;
            this.etelid = etelid;
            this.fid = fid;
        }
        public Etkezes(string idopont,int etelid)
        {
            this.idopont = idopont;
            this.etelid = etelid;
        }

        public int Etkezesid { get => etkezesid; set => etkezesid = value; }
        public string Idopont { get => idopont; set => idopont = value; }
        public int Etelid { get => etelid; set => etelid = value; }
        public int Fid { get => fid; set => fid = value; }
    }
}
