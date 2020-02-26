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
        private int feherje;
        private int szenhidrat;
        private int zsir;
        private string mennyiseg;
        private int fid;

        public Etkezes(int etkezesekid, string idopont, int etelid, int feherje, int szenhidrat, int zsir, string mennyiseg, int fid)
        {
            this.etkezesekid = etkezesekid;
            this.idopont = idopont;
            this.etelid = etelid;
            this.feherje = feherje;
            this.szenhidrat = szenhidrat;
            this.zsir = zsir;
            this.mennyiseg = mennyiseg;
            this.fid = fid;
        }
        public string InsertIntoEtkezesek()
        {
            return "INSERT INTO `etkezesek` (`idopont`, `etel_id`, `feherje`, `szenhidrat`, `zsir`, `mennyiseg`, `f_id`) VALUES ('" + Idopont + "', '" + Etelid + "', '" + Feherje + "', '" + Szenhidrat + "', '" + Zsir + "', '" + Mennyiseg + "', '" + Fid + "');";
        }
        public int Etkezesekid { get => etkezesekid; set => etkezesekid = value; }
        public string Idopont { get => idopont; set => idopont = value; }
        public int Etelid { get => etelid; set => etelid = value; }
        public int Feherje { get => feherje; set => feherje = value; }
        public int Szenhidrat { get => szenhidrat; set => szenhidrat = value; }
        public int Zsir { get => zsir; set => zsir = value; }
        public string Mennyiseg { get => mennyiseg; set => mennyiseg = value; }
        public int Fid { get => fid; set => fid = value; }
    }
}
