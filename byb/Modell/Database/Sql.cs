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
        public static string getKiegAdatok()
        {
            return "SELECT kiegeszitok_adatai.k_id, kiegeszitok_adatai.knev,kiegeszitok_adatai.tipus, kiegeszitok_adatai.gyarto, kiegeszitok_adatai.kiszereles, kiegeszitok_adatai.ks_mertekegyseg, kiegeszitok.f_id FROM kiegeszitok_adatai INNER JOIN kiegeszitok ON kiegeszitok_adatai.k_id = kiegeszitok.id WHERE kiegeszitok.f_id = " + FormLogin.loggedID;
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
