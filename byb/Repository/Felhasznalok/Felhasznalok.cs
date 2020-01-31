using byb.Modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Repository.Felhasznalok
{
    class Felhasznalok
    {
        List<Felhasznalo> felhasznalok;
        public Felhasznalok()
        {
            felhasznalok = new List<Felhasznalo>();
        }
        public List<Felhasznalo> getFelhasznalok()
        {
            return felhasznalok;
        }
        public void setFelhasznalok(List<Felhasznalo> felhasznalok)
        {
            this.felhasznalok = felhasznalok;
        }
    }
}
