using byb.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Felhasznalo
    {

        /// <summary>
        /// A felhasználó adatai
        /// </summary>
        private int id;
        private string fname;
        private string jelszo;
        private string teljesnev;
        private string email;
        private int tsuly;
        private int tmagassag;
        /// <summary>
        /// Konstruktor a felhasználó adataival
        /// </summary>
        /// <param name="id">Azonosító</param>
        /// <param name="fname">Felhasználónév</param>
        /// <param name="jelszo">Jelszó</param>
        /// <param name="teljesnev">Teljes név</param>
        /// <param name="email">Elérhetőség</param>
        /// <param name="tsuly">Testsúly</param>
        /// <param name="tmagassag">Testmagasság</param>
        public Felhasznalo(int id, string fname,string jelszo, string teljesnev, string email, int tsuly, int tmagassag)
        {
            this.id = id;
            this.fname = fname;
            this.jelszo = jelszo;
            this.teljesnev = teljesnev;
            this.email = email;
            this.tsuly = tsuly;
            this.tmagassag = tmagassag;
        }
        //Set metódusok
        public void setId(int id)
        {
            this.id = id;
        }
        public void setFname(string fname)
        {
            this.fname = fname;
        }
        public void setJelszo(string jelszo)
        {
            this.jelszo = jelszo;
        }
        public void setTeljesnev(string nev)
        {
            this.teljesnev = nev;
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
        public string getFname()
        {
            return fname;
        }
        public string getJelszo()
        {
            return jelszo;
        }
        public string getTeljesNev()
        {
            return teljesnev;
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
