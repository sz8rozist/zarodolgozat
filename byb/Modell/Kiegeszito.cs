using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell
{
    /// <summary>
    /// Kiegeszitő osztály
    /// </summary>
    class Kiegeszito
    {
        /// <summary>
        /// Kiegészítő adatai
        /// </summary>
        private int kiegid;
        private int k_id;
        private int f_id;
        /// <summary>
        /// Konstruktor a kiegeszito adataival
        /// </summary>
        /// <param name="kiegid">Azonosító</param>
        /// <param name="k_id">Kiegeszito_adatID</param>
        /// <param name="f_id">Felhasználó ID</param>
        public Kiegeszito(int kiegid, int k_id, int f_id)
        {
            this.kiegid = kiegid;
            this.k_id = k_id;
            this.f_id = f_id;
        }
        /// <summary>
        /// Konstruktor a kiegeszito adataival record hozzáadáshoz de azonosító nélkül mert az adatbázisba auto increment tulajdonságot kapott
        /// </summary>
        /// <param name="k_id">Kiegeszito_adatID</param>
        /// <param name="f_id">Felhasználó ID</param>
        public Kiegeszito(int k_id, int f_id)
        {
            this.k_id = k_id;
            this.f_id = f_id;
        }
        /// <summary>
        /// Set - get metódusok
        /// </summary>
        public int Kiegid { get => kiegid; set => kiegid = value; }
        public int K_id { get => k_id; set => k_id = value; }
        public int F_id { get => f_id; set => f_id = value; }
        /// <summary>
        /// Insert Into SQL lekérdezés
        /// </summary>
        /// <returns>Új record beszúrása a kiegeszitok táblába</returns>
        public string insertIntoKiegeszito()
        {
            return "INSERT INTO `kiegeszitok`(`k_id`, `f_id`) VALUES ('"+K_id+"','"+F_id+"')";
        }
    }
}
