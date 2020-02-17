using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Database
{
    /// <summary>
    /// ConnectionString osztály a csatlakozáshoz
    /// </summary>
    class ConnectionString
    {
        /// <summary>
        /// Connection Stringet csinál az adatbázis létrehozásához
        /// </summary>
        /// <returns>Connection string ami a test adatbázishoz csatlakozik</returns>
        public string getCreateString()
        {
            return
                "SERVER=\"localhost\";"
                + "DATABASE=\"test\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3306\";";
        }
        /// <summary>
        /// Connection string a táblák és a teszt adatok feltöltéséhez
        /// </summary>
        /// <returns>maga a string ami a buildyourbody adatbázishoz csatlakozik</returns>
        public string getConnectionString()
        {
            return
                "SERVER=\"localhost\";"
                + "DATABASE=\"buildyourbody\";"
                + "UID=\"root\";"
                + "PASSWORD=\"\";"
                + "PORT=\"3306\";";
        }
    }
}
