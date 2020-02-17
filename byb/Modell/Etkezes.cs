using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    public class Etkezes
    {
        /// <summary>
        /// Étkezés adatai
        /// </summary>
        private int etkezesid;
        private string idopont;
        private int etelid;
        private int fid;
        //Konstruktor a view-n való megjelenítéshez
        public Etkezes(int etkezesid,string idopont,int etelid,int fid)
        {
            this.etkezesid = etkezesid;
            this.idopont = idopont;
            this.etelid = etelid;
            this.fid = fid;
        }
        public Etkezes(string idopont, int etelid, int fid)
        {
            this.idopont = idopont;
            this.etelid = etelid;
            this.fid = fid;
        }
        //set - get metódusok
        public int Etkezesid { get => etkezesid; set => etkezesid = value; }
        public string Idopont { get => idopont; set => idopont = value; }
        public int Etelid { get => etelid; set => etelid = value; }
        public int Fid { get => fid; set => fid = value; }

        public string getInsertEtkezes()
        {
            return "INSERT INTO `etkezesek`(`etkezesek_id`, `idopont`, `etel_id`, `f_id`) VALUES ('"+Etkezesid+"', '"+Idopont+"', '"+Etelid+"', '"+Fid+"')";
        }
    }
}
