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
        private string etelid;
        private string fid;

        public Etkezes(int etkezesid, string idopont, string etelid, string fid)
        {
            this.etkezesid = etkezesid;
            this.idopont = idopont;
            this.etelid = etelid;
            this.fid = fid;
        }

        public int Etkezesid { get => etkezesid; set => etkezesid = value; }
        public string Idopont { get => idopont; set => idopont = value; }
        public string Etelid { get => etelid; set => etelid = value; }
        public string Fid { get => fid; set => fid = value; }
    }
}
