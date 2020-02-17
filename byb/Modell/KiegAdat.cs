using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    /// <summary>
    /// Kiegészítő Adatai osztály
    /// </summary>
    class KiegAdat
    {
        /// <summary>
        /// Kiegészítő adatai
        /// </summary>
        private int kid;
        private string knev;
        private string tipus;
        private string gyarto;
        /// <summary>
        /// Konstruktor a kiegészítő adataival
        /// </summary>
        /// <param name="kid">Azonosító</param>
        /// <param name="knev">Név</param>
        /// <param name="tipus">Típus</param>
        /// <param name="gyarto">Gyártó</param>
        public KiegAdat (int kid,string knev, string tipus, string gyarto)
        {
            this.kid = kid;
            this.knev = knev;
            this.tipus = tipus;
            this.gyarto = gyarto;
        }
        /// <summary>
        /// Konstruktor a kiegészítő adataival de kid nélkül az insert into miatt mivel ez az érték az adatbázisban auto increment tulajdonságot kapott
        /// </summary>
        /// <param name="knev">Név</param>
        /// <param name="tipus">Típus</param>
        /// <param name="gyarto">Gyártó</param>
        public KiegAdat(string knev, string tipus, string gyarto)
        {
            this.knev = knev;
            this.tipus = tipus;
            this.gyarto = gyarto;
        }
        /// <summary>
        /// Set - get metódusok
        /// </summary>
        public int Kid { get => kid; set => kid = value; }
        public string Knev { get => knev; set => knev = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Gyarto { get => gyarto; set => gyarto = value; }
        /// <summary>
        /// Insert Into SQL lekérdezés
        /// </summary>
        /// <returns>Új record beszúrása a kiegeszitok_adatai táblába</returns>
        public string insertIntoKiegAdatok()
        {
            return "INSERT INTO `kiegeszitok_adatai`(`knev`, `tipus`, `gyarto`) VALUES ('"+Knev+"','"+Tipus+"','"+Gyarto+"')";
        }
    }
}
