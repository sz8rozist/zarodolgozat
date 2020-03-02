using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class EdzesViewn
    {
        private string gyakorlatnev;
        private int sorozatszam;
        private int ismetlesszam;
        private string idopont;

        public EdzesViewn(string gyakorlatnev, int sorozatszam, int ismetlesszam,string idopont)
        {
            this.gyakorlatnev = gyakorlatnev;
            this.sorozatszam = sorozatszam;
            this.ismetlesszam = ismetlesszam;
            this.idopont = idopont;
        }

        public string Gyakorlatnev { get => gyakorlatnev; set => gyakorlatnev = value; }
        public int Sorozatszam { get => sorozatszam; set => sorozatszam = value; }
        public int Ismetlesszam { get => ismetlesszam; set => ismetlesszam = value; }
        public string Idopont { get => idopont; set => idopont = value; }
    }
}
