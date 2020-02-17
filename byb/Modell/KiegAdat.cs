using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class KiegAdat
    {
        private int kid;
        private string knev;
        private string tipus;
        private string gyarto;

        public KiegAdat (int kid,string knev, string tipus, string gyarto)
        {
            this.kid = kid;
            this.knev = knev;
            this.tipus = tipus;
            this.gyarto = gyarto;
        }
        public KiegAdat(string knev, string tipus, string gyarto)
        {
            this.knev = knev;
            this.tipus = tipus;
            this.gyarto = gyarto;
        }

        public int Kid { get => kid; set => kid = value; }
        public string Knev { get => knev; set => knev = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Gyarto { get => gyarto; set => gyarto = value; }

        public string insertIntoKiegAdatok()
        {
            return "INSERT INTO `kiegeszitok_adatai`(`knev`, `tipus`, `gyarto`) VALUES ('"+Knev+"','"+Tipus+"','"+Gyarto+"')";
        }
    }
}
