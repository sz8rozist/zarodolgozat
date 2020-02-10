using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Etkezes
    {
        /// <summary>
        /// Étkezés adatai
        /// </summary>
        private int etkezesid;
        private string idopont;
        private int etelid;
        private string enev;
        private int fid;
        //Konstruktor az étkezés adataival
        public Etkezes(int etkezesid, string idopont, int etelid, int fid)
        {
            this.etkezesid = etkezesid;
            this.idopont = idopont;
            this.etelid = etelid;
            this.fid = fid;
        }
        //Konstruktor a view-n való megjelenítéshez
        public Etkezes(int etkezesid,string idopont,string enev)
        {
            this.etkezesid = etkezesid;
            this.idopont = idopont;
            this.enev = enev;
        }
        //set - get metódusok
        public int Etkezesid { get => etkezesid; set => etkezesid = value; }
        public string Idopont { get => idopont; set => idopont = value; }
        public int Etelid { get => etelid; set => etelid = value; }
        public int Fid { get => fid; set => fid = value; }
        public string Enev { get => enev; set => enev = value; }
    }
}
