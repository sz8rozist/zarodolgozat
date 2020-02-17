using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class TaplalekkiegeszitokView
    {
        private string nev;
        private string tipus;
        private string gyarto;

        public TaplalekkiegeszitokView(string nev, string tipus, string gyarto)
        {
            this.nev = nev;
            this.tipus = tipus;
            this.gyarto = gyarto;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Gyarto { get => gyarto; set => gyarto = value; }
    }
}
