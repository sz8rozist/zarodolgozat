using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Database
{
    /// <summary>
    /// CreateDatabase osztály
    /// </summary>
    class CreateDatabase
    {
        /// <summary>
        /// Connection stringek, csak olvashatóak
        /// </summary>
        private readonly string connectionString;
        private readonly string createString;
        /// <summary>
        /// Kontruktor-ban connection stringek példányosítása
        /// </summary>
        public CreateDatabase()
        {
            ConnectionString dbc = new ConnectionString();
            connectionString = dbc.getConnectionString();
            createString = dbc.getCreateString();
        }
        /// <summary>
        /// Adatbázis létrehozása.
        /// </summary>
        public void createDataBase()
        {
            MySqlConnection con = new MySqlConnection(createString);
            try
            {
                con.Open();
                string query = "CREATE DATABASE IF NOT EXISTS `buildyourbody` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci; USE `buildyourbody`; ";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (CreateDatabaseException cde)
            {
                con.Close();
                Debug.WriteLine("Az adatbázis létrehozása sikertelen!" + cde.Message);
            }

        }
        /// <summary>
        /// Adatbázis tábláinak létrehozása
        /// </summary>
        public void createDataBaseTable()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                string edzesekQuery = "CREATE TABLE IF NOT EXISTS `edzesek` ( " +
                                            " `edzesek_id` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT ," +
                                            "`idopont` datetime NOT NULL," +
                                            "`f_id` int(11) NOT NULL," +
                                            "`edzesterv_id` int(11) NOT NULL" +
                                            ") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci; ";
                MySqlCommand cdmedzes = new MySqlCommand(edzesekQuery, con);
                cdmedzes.ExecuteNonQuery();


                string edzesterv = "CREATE TABLE IF NOT EXISTS `edzestervek` ( "+
 " `edzesterv_id` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT,"+
 " `gyakorlat_id` int(11) NOT NULL,"+
 " `sorozatszam` int(11) NOT NULL,"+
 " `ismetlesszam` int(11) NOT NULL"+
") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci; ";
                MySqlCommand cmdterv = new MySqlCommand(edzesterv, con);
                cmdterv.ExecuteNonQuery();



                string etelek = "CREATE TABLE IF NOT EXISTS `etelek` (" +
                                 " `etel_id` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                                 " `enev` varchar(20) COLLATE utf8_hungarian_ci NOT NULL"+
                               " ) ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci; ";
                MySqlCommand cmdetelek = new MySqlCommand(etelek, con);
                cmdetelek.ExecuteNonQuery();


                string etkezesek = "CREATE TABLE IF NOT EXISTS `etkezesek` (" +
                                 " `etkezesek_id` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                                 " `idopont` datetime NOT NULL,"+
                                 " `etel_id` int(11) NOT NULL,"+
                                 " `feherje` int(11) NOT NULL," +
                                 " `szenhidrat` int(11) NOT NULL," +
                                 " `zsir` int(11) NOT NULL," +
                                 " `mennyiseg` varchar(20) COLLATE utf8_hungarian_ci NOT NULL," +
                                 " `f_id` int(11) NOT NULL" +
                               " ) ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci; ";
                MySqlCommand cmdetkezesek = new MySqlCommand(etkezesek, con);
                cmdetkezesek.ExecuteNonQuery();



                string felhasznalok = "CREATE TABLE IF NOT EXISTS `felhasznalok` (" +
                              "`f_id` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                             " `fname` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,"+
                             " `jelszo` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,"+
                             " `teljesnev` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,"+
                             " `email` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,"+
                             " `tsuly` int(11) NOT NULL,"+
                              "`tmagassag` int(11) NOT NULL"+
                           " ) ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci; ";
                MySqlCommand cmdfelhasznalok = new MySqlCommand(felhasznalok, con);
                cmdfelhasznalok.ExecuteNonQuery();


                string gyakorlatok = "CREATE TABLE IF NOT EXISTS `gyakorlatok` (" +
                                 " `gyakorlatok_id` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                                 " `gynev` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,"+
                                 " `izomcsoport_id` int(11) NOT NULL," +
                                 " `leiras` varchar(20) COLLATE utf8_hungarian_ci NOT NULL" +
                                ") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci; ";
                MySqlCommand cmdgyakorlatok = new MySqlCommand(gyakorlatok, con);
                cmdgyakorlatok.ExecuteNonQuery();



                string izomcsoportok = "CREATE TABLE IF NOT EXISTS `izomcsoportok` (" +
                                      "`izomcsoport_id` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                                     " `izomcsoport` varchar(20) COLLATE utf8_hungarian_ci NOT NULL"+
                                    ") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci; ";
                MySqlCommand cmdizom = new MySqlCommand(izomcsoportok, con);
                cmdizom.ExecuteNonQuery();


                string kieg = "CREATE TABLE IF NOT EXISTS `kiegeszitok` (" +
                                                          "`id` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                                                          "`k_id` int(11) NOT NULL,"+
                                                         " `f_id` int(11) NOT NULL"+
                                                       " ) ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci; ";
                MySqlCommand cmdkieg = new MySqlCommand(kieg, con);
                cmdkieg.ExecuteNonQuery();


                string kiegadatok = "CREATE TABLE IF NOT EXISTS `kiegeszitok_adatai` (" +
                                          "`k_id` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                                          "`knev` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,"+
                                          "`tipus` varchar(20) CHARACTER SET utf32 COLLATE utf32_hungarian_ci NOT NULL,"+
                                          "`gyarto` varchar(20) COLLATE utf8_hungarian_ci NOT NULL"+
                                        ") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci; ";
                MySqlCommand cmdkiegadatok = new MySqlCommand(kiegadatok, con);
                cmdkiegadatok.ExecuteNonQuery();


                string fkeyEdzesek = "ALTER TABLE `edzesek`" +
  "ADD CONSTRAINT `edzesek_ibfk_1` FOREIGN KEY IF NOT EXISTS (`f_id`) REFERENCES `felhasznalok` (`f_id`)," +
  "ADD CONSTRAINT `edzesek_ibfk_2` FOREIGN KEY IF NOT EXISTS (`edzesterv_id`) REFERENCES `edzestervek` (`edzesterv_id`); ";
                MySqlCommand fkeyEdzesekcmd = new MySqlCommand(fkeyEdzesek, con);
                fkeyEdzesekcmd.ExecuteNonQuery();


                string fkeyEdzesterv = "ALTER TABLE `edzestervek`"+
  "ADD CONSTRAINT `edzestervek_ibfk_1` FOREIGN KEY IF NOT EXISTS (`gyakorlat_id`) REFERENCES `gyakorlatok` (`gyakorlatok_id`);";
                MySqlCommand fkeyEdzestervcmd = new MySqlCommand(fkeyEdzesterv, con);
                fkeyEdzestervcmd.ExecuteNonQuery();


                string fkeyEdtkezesek = "ALTER TABLE `etkezesek`"+
  "ADD CONSTRAINT `etkezesek_ibfk_1` FOREIGN KEY IF NOT EXISTS (`etel_id`) REFERENCES `etelek` (`etel_id`),"+
  "ADD CONSTRAINT `etkezesek_ibfk_2` FOREIGN KEY IF NOT EXISTS (`f_id`) REFERENCES `felhasznalok` (`f_id`); ";
                MySqlCommand fkeyEtkezesekcmd = new MySqlCommand(fkeyEdtkezesek, con);
                fkeyEtkezesekcmd.ExecuteNonQuery();

                string fkeyKieg = "ALTER TABLE `kiegeszitok`"+
  "ADD CONSTRAINT `kiegeszitok_ibfk_1` FOREIGN KEY IF NOT EXISTS (`f_id`) REFERENCES `felhasznalok` (`f_id`),"+
  "ADD CONSTRAINT `kiegeszitok_ibfk_2` FOREIGN KEY IF NOT EXISTS (`k_id`) REFERENCES `kiegeszitok_adatai` (`k_id`); ";
                MySqlCommand fkeyKiegcmd = new MySqlCommand(fkeyKieg, con);
                fkeyKiegcmd.ExecuteNonQuery();

                string fkeyGyak = "ALTER TABLE `gyakorlatok`"+
  "ADD CONSTRAINT `gyakorlatok_ibfk_1` FOREIGN KEY IF NOT EXISTS (`izomcsoport_id`) REFERENCES `izomcsoportok` (`izomcsoport_id`); ";
                MySqlCommand fkeyGyakcmd = new MySqlCommand(fkeyGyak, con);
                fkeyGyakcmd.ExecuteNonQuery();
                con.Close();
            }
            catch (CreateDatabaseException cde)
            {
                con.Close();
                Debug.WriteLine(cde.Message);
                throw new CreateDatabaseException("Hiba történt a táblák létrehozásakor.");
            }
        }
        /// <summary>
        /// Tesztadatok feltöltése az adatbázisba
        /// </summary>
        public void tesztadatokFeltoltese()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                string TesztAdatokFelhasznalok = "INSERT  INTO `felhasznalok` (`f_id`, `fname`, `jelszo`, `teljesnev`, `email`, `tsuly`, `tmagassag`) VALUES" +
                    "(NULL, 'sz8rozist', '12345', 'Rózsa István', 'ristvan98@gmail.com', '110', '196')," +
                    "(NULL, 'admin', '12345', 'Rózsa István', 'ristvan98@gmail.com', '110', '196')," +
                    "(NULL, 'Valami', '12345', 'Rózsa István', 'ristvan98@gmail.com', '110', '193')," +
                    "(NULL, 'Adam', '12345', 'Rózsa István', 'ristvan98@gmail.com', '110', '194')," +
                    "(NULL, 'g8szatam', '12345', 'Rózsa István', 'ristvan98@gmail.com', '110', '196');";
                MySqlCommand cmdTesztAdatokFelhasznalok = new MySqlCommand(TesztAdatokFelhasznalok, con);
                cmdTesztAdatokFelhasznalok.ExecuteNonQuery();

                string izomcsoportTesztAdatok = "INSERT INTO `izomcsoportok` (`izomcsoport_id`, `izomcsoport`) VALUES " +
                    "(NULL, 'Mell'),"+
                    "(NULL, 'Hát')," +
                    "(NULL, 'Váll')," +
                    "(NULL, 'Bicepsz')," +
                    "(NULL, 'Tricepsz')," +
                    "(NULL, 'Alkar')," +
                    "(NULL, 'Vádli')," +
                    "(NULL, 'Has')," +
                    "(NULL, 'Láb');";
                MySqlCommand cmdIzomcsoport = new MySqlCommand(izomcsoportTesztAdatok, con);
                cmdIzomcsoport.ExecuteNonQuery();

                string etelekTesztAdatok = "INSERT INTO `etelek`(`etel_id`, `enev`) VALUES" +
                    " (null, 'Csirkemell'),"+
                    " (null, 'Sajt'),"+
                    " (null, 'Brokkoli'),"+
                    " (null, 'Avokádó'),"+
                    " (null, 'Beef Steak');";
                MySqlCommand cmdEtel = new MySqlCommand(etelekTesztAdatok, con);
                cmdEtel.ExecuteNonQuery();

                string kiegadatok = "INSERT INTO `kiegeszitok_adatai` (`k_id`, `knev`, `tipus`, `gyarto`) VALUES " +
                    "(NULL, 'Iso Whey Zero', 'Fehérje', 'Biotech Usa')," +
                    "(NULL, '100% Whey', 'Fehérje', 'Scitec Nutrition')," +
                    "(NULL, 'Bcaa Flash Zero', 'Aminosav', 'Biotech Usa')," +
                    "(NULL, 'True Whey', 'Fehérje', 'Gym Beam')," +
                    "(NULL, 'Wianabol', 'Tesztoszteron Serkentő', 'Biotech Usa')," +
                    "(NULL, 'Anabolic Whey', 'Fehérje', 'Scitec Nutrition')," +
                    "(NULL, 'Mega Daily One', 'Multivitamin', 'Scitec Nutrition')," +
                    "(NULL, 'Multipro', 'Multivitamin', 'Scitec Nutrition')," +
                    "(NULL, 'Beef Isolate', 'Fehérje', 'Biotech Usa');";
                MySqlCommand cmdkiegadatok = new MySqlCommand(kiegadatok, con);
                cmdkiegadatok.ExecuteNonQuery();

                string gyakorlatok = "INSERT INTO `gyakorlatok` (`gyakorlatok_id`, `gynev`, `izomcsoport_id`, `leiras`) VALUES " +
                    "(NULL, 'Fekvenyomás', '1', 'bbbb')" +
                    "(NULL, 'Guggolás', '9', 'aaaa')" +
                    "(NULL, 'Letolás Csigán', '5', 'aha')" +
                    "(NULL, 'Szélesfogású Mellhezhúzás', '2', 'Ahadsa')" +
                    "(NULL, 'Kalapács bicepsz', '4', 'Ahadsa')" +
                "(NULL, 'Lórugás', '5', 'Ahadsa');";
                MySqlCommand cmdgyakorlatok = new MySqlCommand(gyakorlatok, con);
                cmdgyakorlatok.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();   
                Debug.WriteLine(e.Message);
                throw new CreateDatabaseException("Tesztadatok feltöltése sikertelen!");
            }
        }
        
    }
}
