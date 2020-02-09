using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    class Taplalekkiegeszito
    {
        /// <summary>
        /// Táplálékkiegészítő adatai
        /// </summary>
        private int id;
        private string nev;
        private string tipus;
        private string gyarto;
        private int kiszereles;
        private string kme;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="id">tkieg azonosito</param>
        /// <param name="nev">tkieg neve</param>
        /// <param name="tipus">tkieg típusa</param>
        /// <param name="gyarto">tkieg gyártója</param>
        /// <param name="kiszereles">tkieg kiszerelése</param>
        /// <param name="kme">kiszerelés mértékegysége</param>
        public Taplalekkiegeszito(int id, string nev, string tipus, string gyarto, int kiszereles, string kme)
        {
            this.id = id;
            this.nev = nev;
            this.tipus = tipus;
            this.gyarto = gyarto;
            this.kiszereles = kiszereles;
            this.kme = kme;
        }
        /// <summary>
        /// set - get metódusok
        /// </summary>
        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Gyarto { get => gyarto; set => gyarto = value; }
        public int Kiszereles { get => kiszereles; set => kiszereles = value; }
        public string Kme { get => kme; set => kme = value; }

        /// <summary>
        /// Táplálékkiegészítő adatainak lekérdezése adatbázisból
        /// </summary>
        /// <returns>Minden adat a kiegeszitok táblából</returns>

    }
}
