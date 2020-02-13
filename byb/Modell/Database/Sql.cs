using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell.Database
{
    class Sql
    {
        /// <summary>
        /// Ételek adatainak lekérdezése adatbázisból
        /// </summary>
        /// <returns>Minden adat az etelek táblából</returns>
        public static string getAllEtelekRecord()
        {
            return "SELECT * FROM etelek";
        }
        /// <summary>
        /// táplálékkiegészítők adatainak lekérdezése adatbázisból
        /// </summary>
        /// <returns>Minden adat az kiegeszitok táblából</returns>
        public static string getAllTkiegRecord()
        {
            return "SELECT * FROM kiegeszitok_adatai";
        }
        /// <summary>
        /// felhasználók adatainak lekérdezése adatbázisból
        /// </summary>
        /// <returns>Minden adat az felhasznalok táblából</returns>
        public static string getUsersAllRecord()
        {
            return "SELECT * FROM felhasznalok";
        }
        public static string getEtkezesekAllRecord()
        {
            return "SELECT * FROM etkezesek";
        }
    }
}
