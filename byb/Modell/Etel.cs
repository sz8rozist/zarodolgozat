using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    public class Etel
    {
        private int etelid;
        private string enev;
        private int feherje;
        private int szenhidrat;
        private int zsir;
        private int kaloria;
        private string mennyiseg;

        public Etel(int etelid, string enev, int feherje, int szenhidrat, int zsir,int kaloria, string mennyiseg)
        {
            this.etelid = etelid;
            this.enev = enev;
            this.feherje = feherje;
            this.szenhidrat = szenhidrat;
            this.zsir = zsir;
            this.kaloria = kaloria;
            this.mennyiseg = mennyiseg;
        }
        public Etel(string enev, int feherje, int szenhidrat, int zsir, int kaloria, string mennyiseg)
        {
            this.enev = enev;
            this.feherje = feherje;
            this.szenhidrat = szenhidrat;
            this.zsir = zsir;
            this.kaloria = kaloria;
            this.mennyiseg = mennyiseg;
        }

        public bool validate()
        {
            if (!enevIsEmpty())
                throw new ValidateEtelNevIsEmpty("Megkell adnod az étel nevét!");
            if (feherjeIsNegative())
                throw new ValidateFeherjeIsNegative("Negatív értéket nem adhatsz meg!");
            if (!enevFirstLetterUpperCase())
                throw new ValidateEnevFirstLetterUpperCaseException("Az első betű nagybetű kell legyen!");
            if (!mennyisegFristCharacterIsNumber())
                throw new ValidateMennyisegFirstLetterIsNumberException("Az első karakter csak szám lehet!");
            if (!mennyisegVanBenneBetu())
                throw new ValidateMennyisegContainBetuException("Nem adtál meg mértékegységet(gr,kg ..stb)!");
            
            return true;
        }

        private bool mennyisegVanBenneBetu()
        {
            for(int i=0;i<Mennyiseg.Length; i++)
            {
                if (char.IsLetter(mennyiseg.ElementAt(i)))
                    return true;
            }
            return false;
        }

        private bool mennyisegFristCharacterIsNumber()
        {
            if (char.IsDigit(Mennyiseg.ElementAt(0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool enevFirstLetterUpperCase()
        {
            if (char.IsUpper(Enev.ElementAt(0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool feherjeIsNegative()
        {
           if(Feherje < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool enevIsEmpty()
        {
            if(Enev == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int Etelid { get => etelid; set => etelid = value; }
        public string Enev { get => enev; set => enev = value; }
        public int Kaloria { get => kaloria; set => kaloria = value; }
        public int Feherje { get => feherje; set => feherje = value; }
        public int Szenhidrat { get => szenhidrat; set => szenhidrat = value; }
        public int Zsir { get => zsir; set => zsir = value; }
        public string Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

        public string getInsert()
        {
            return "INSERT INTO `etelek` (`enev`, `feherje`, `szenhidrat`, `zsir`, `kaloria`, `mennyiseg`) VALUES ('"+Enev+"', '"+Feherje+"', '"+Szenhidrat+"', '"+Zsir+"', '"+Kaloria+"', '"+Mennyiseg+"');";
        }
    }
}
