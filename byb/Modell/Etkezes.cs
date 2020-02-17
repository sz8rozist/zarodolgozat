using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    /// <summary>
    /// Étkezés osztály
    /// </summary>
    public class Etkezes
    {
        /// <summary>
        /// Étkezés adatai
        /// </summary>
        private int etkezesid;
        private string idopont;
        private int etelid;
        private int fid;
        /// <summary>
        /// Konstruktor az étkezés adataival
        /// </summary>
        /// <param name="etkezesid">Étkezés azonosító</param>
        /// <param name="idopont">Étkezés időpontja</param>
        /// <param name="etelid">Étel azonosítója amit a felhasználó evett</param>
        /// <param name="fid">Felhasználó azonosítója</param>
        public Etkezes(int etkezesid,string idopont,int etelid,int fid)
        {
            this.etkezesid = etkezesid;
            this.idopont = idopont;
            this.etelid = etelid;
            this.fid = fid;
        }
        /// <summary>
        /// Konstruktor etkezes azonosító nélkül új rekord beszúrásánál mivel az ID auto increment
        /// </summary>
        /// <param name="idopont">Étkezés időpontja</param>
        /// <param name="etelid">Étel azonosítója amit a felhasználó evett</param>
        /// <param name="fid">Felhasználó azonosítója</param>
        public Etkezes(string idopont, int etelid, int fid)
        {
            this.idopont = idopont;
            this.etelid = etelid;
            this.fid = fid;
        }
        /// <summary>
        /// Set - get metódusok
        /// </summary>
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
