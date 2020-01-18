using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Vendeg
    {
        /// <summary>
        /// A vendég adatai
        /// </summary>
        private int id;
        private string nev;
        private string email;
        private int tsuly;
        private int tmagassag;
        /// <summary>
        /// Vendég osztály konstruktora
        /// </summary>
        /// <param name="id">A vendég azonosítója</param>
        /// <param name="nev">A vendég neve</param>
        /// <param name="email">A vendég e-mail címe</param>
        /// <param name="tsuly">A vendég testsúlya</param>
        /// <param name="tmagassag">A vendég testmagassága</param>
        public Vendeg(int id, string nev, string email, int tsuly, int tmagassag)
        {
            this.id = id;
            this.nev = nev;
            this.email = email;
            this.tsuly = tsuly;
            this.tmagassag = tmagassag;
        }
        /// <summary>
        /// Metódus a formon való módosításhoz.
        /// </summary>
        /// <param name="update">A módosított vendég</param>
        public void update(Vendeg update)
        {
            this.nev = update.getNev();
            this.email = update.getEmail();
            this.tsuly = update.getTsuly();
            this.tmagassag = update.getTmagassag();
        }
       //Set metódusok
        public void setId(int id)
        {
            this.id = id;
        }
        public void setNev(string nev)
        {
            this.nev = nev;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setTsuly(int tsuly)
        {
            this.tsuly = tsuly;
        }
        public void setTmagassag(int tmagassag)
        {
            this.tmagassag = tmagassag;
        }
        //Get metódusok
        public int getId()
        {
            return id;
        }
        public string getNev()
        {
            return nev;
        }
        public string getEmail()
        {
            return email;
        }
        public int getTmagassag()
        {
            return tmagassag;
        }
        public int getTsuly()
        {
            return tsuly;
        }
        

    }
}
