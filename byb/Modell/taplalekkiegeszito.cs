using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Taplalekkiegeszito
    {
        private int kid;
        private string knev;
        private string tipus;
        private string gyarto;
        private int kiszereles;
        private string ksMertekE;
        private int fid;

        public Taplalekkiegeszito(int kid, string knev, string tipus, string gyarto, int kiszereles, string ksMertekE, int fid)
        {
            this.kid = kid;
            this.knev = knev;
            this.tipus = tipus;
            this.gyarto = gyarto;
            this.kiszereles = kiszereles;
            this.ksMertekE = ksMertekE;
            this.fid = fid;
        }

        public int Kid { get => kid; set => kid = value; }
        public string Knev { get => knev; set => knev = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Gyarto { get => gyarto; set => gyarto = value; }
        public int Kiszereles { get => kiszereles; set => kiszereles = value; }
        public string KsMertekE { get => ksMertekE; set => ksMertekE = value; }
        public int Fid { get => fid; set => fid = value; }
    }
}
