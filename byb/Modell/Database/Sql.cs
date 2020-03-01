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
            return "SELECT etel_id, enev FROM etelek";
        }
        /// <summary>
        /// Kiegészítők adatainak lekérdezése adatbázisból
        /// </summary>
        /// <returns>Minden adat a kiegeszitok_adatai táblából</returns>
        public static string getKiegAdatok()
        {
            return "SELECT * FROM kiegeszitok_adatai";
        }

        public static string getEdzesekAllRecord()
        {
            return "SELECT * FROM edzesek";
        }

        public static string getEdzestervekAllRecord()
        {
            return "SELECT * FROM edzestervek";
        }

        /// <summary>
        /// Kiegészítők kapcsoló tábla adatainak lekérdezése adatbázisból
        /// </summary>
        /// <returns>Minden adat a kiegeszitok táblából</returns>
        public static string getHasznaltKiegAdatok()
        {
            return "SELECT * FROM kiegeszitok";
        }
        /// <summary>
        /// felhasználók adatainak lekérdezése adatbázisból
        /// </summary>
        /// <returns>Minden adat az felhasznalok táblából</returns>
        public static string getUsersAllRecord()
        {
            return "SELECT * FROM felhasznalok";
        }
        public static string getGyakorlatokAllRecord()
        {
            return "SELECT * FROM gyakorlatok";
        }
        public static string getIzomcsoportokAllRecord()
        {
            return "SELECT * FROM izomcsoportok";
        }
        /// <summary>
        /// Étkezések kapcsoló tábla adatainak lekérdezése adatbázisból
        /// </summary>
        /// <returns>Minden adat az étkezések táblából</returns>
        public static string getEtkezesekAllRecord()
        {
            return "SELECT * FROM etkezesek";
        }
    }
}
