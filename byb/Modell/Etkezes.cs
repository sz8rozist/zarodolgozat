using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Etkezes
    {
        private int etkezesekid;
        private string idopont;
        private int etelid;

        private int fid;

        public Etkezes(int etkezesekid, string idopont, int etelid, int fid)
        {
            this.etkezesekid = etkezesekid;
            this.idopont = idopont;
            this.etelid = etelid;
            this.fid = fid;
        }
        public Etkezes( string idopont, int etelid, int fid)
        {
            this.idopont = idopont;
            this.etelid = etelid;
            this.fid = fid;
        }
        public int Etkezesekid { get => etkezesekid; set => etkezesekid = value; }
        public string Idopont { get => idopont; set => idopont = value; }
        public int Etelid { get => etelid; set => etelid = value; }
        public int Fid { get => fid; set => fid = value; }

        public string getInsert()
        {
            return "INSERT INTO `etkezesek` (`idopont`, `etel_id`, `f_id`) VALUES ('"+Idopont+"', '"+Etelid+"', '"+FormLogin.loggedID+"');";
        }
    }
}
