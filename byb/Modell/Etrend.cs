using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    /// <summary>
    /// Étrend osztály
    /// </summary>
    class Etrend
    {
        /// <summary>
        /// Étrend adatai
        /// </summary>
        private int fid;
        private int etelid;
        private int etkezesid;
        private string idopont;
        private string etelnev;
        private int feherje;
        private int szenhidrat;
        private int zsir;
        private string menny;
        /// <summary>
        /// Konstruktor az étrend adataival
        /// </summary>
        /// <param name="fid">Felhasználó azonosító</param>
        /// <param name="idopont">Időpont</param>
        /// <param name="etelnev">Ételnév</param>
        /// <param name="feherje">Fehérje tartalom</param>
        /// <param name="szenhidrat">Szénhidrát tartalom</param>
        /// <param name="zsir">Zsír tartalom</param>
        /// <param name="menny">Mennyiség</param>
        public Etrend(int fid,int etelid,int etkezesid,string idopont,string etelnev, int feherje, int szenhidrat, int zsir,string menny)
        {
            this.fid = fid;
            this.etelid = etelid;
            this.etkezesid = etkezesid;
            this.idopont = idopont;
            this.etelnev = etelnev;
            this.feherje = feherje;
            this.szenhidrat = szenhidrat;
            this.zsir = zsir;
            this.menny = menny;
        }
        /// <summary>
        /// Set - Get metódusok
        /// </summary>
        public int Fid { get => fid; set => fid = value; }
        public string Idopont { get => idopont; set => idopont = value; }
        public string Etelnev { get => etelnev; set => etelnev = value; }
        public int Feherje { get => feherje; set => feherje = value; }
        public int Szenhidrat { get => szenhidrat; set => szenhidrat = value; }
        public int Zsir { get => zsir; set => zsir = value; }
        public string Menny { get => menny; set => menny = value; }
        public int Etelid { get => etelid; set => etelid = value; }
        public int Etkezesid { get => etkezesid; set => etkezesid = value; }
    }
}
