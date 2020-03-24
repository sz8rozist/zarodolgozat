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
                                            "`idopont` date DEFAULT CURRENT_DATE NOT NULL," +
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
                                 " `enev` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,"+
                                 " `feherje` double NOT NULL," +
                                 " `szenhidrat` double NOT NULL," +
                                 " `zsir` double NOT NULL," +
                                 " `kaloria` int(11) NOT NULL," +
                                 " `mennyiseg` varchar(20) COLLATE utf8_hungarian_ci NOT NULL" +
                               " ) ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci; ";
                MySqlCommand cmdetelek = new MySqlCommand(etelek, con);
                cmdetelek.ExecuteNonQuery();


                string etkezesek = "CREATE TABLE IF NOT EXISTS `etkezesek` (" +
                                 " `etkezesek_id` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                                 " `idopont` date NOT NULL,"+
                                 " `etel_id` int(11) NOT NULL,"+
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
                                 " `gynev` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,"+
                                 " `izomcsoport_id` int(11) NOT NULL," +
                                 " `leiras` text COLLATE utf8_hungarian_ci NOT NULL" +
                                ") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci; ";
                MySqlCommand cmdgyakorlatok = new MySqlCommand(gyakorlatok, con);
                cmdgyakorlatok.ExecuteNonQuery();



                string izomcsoportok = "CREATE TABLE IF NOT EXISTS `izomcsoportok` (" +
                                      "`izomcsoport_id` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT," +
                                     " `izomcsoport` varchar(20) COLLATE utf8_hungarian_ci NOT NULL"+
                                    ") ENGINE = InnoDB DEFAULT CHARSET = utf8 COLLATE = utf8_hungarian_ci; ";
                MySqlCommand cmdizom = new MySqlCommand(izomcsoportok, con);
                cmdizom.ExecuteNonQuery();



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
        public void felhasznaloTesztAdatok()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                string TesztAdatokFelhasznalok = "INSERT INTO `felhasznalok` (`f_id`, `fname`, `jelszo`, `teljesnev`, `email`, `tsuly`, `tmagassag`) VALUES" +
                    "(NULL, 'sz8rozist', '12345', 'Rózsa István', 'ristvan98@gmail.com', '110', '196')," +
                    "(NULL, 'admin', '12345', 'Rózsa István', 'ristvan98@gmail.com', '110', '196')," +
                    "(NULL, 'Valami', '12345', 'Rózsa István', 'ristvan98@gmail.com', '110', '193')," +
                    "(NULL, 'Adam', '12345', 'Rózsa István', 'ristvan98@gmail.com', '110', '194')," +
                    "(NULL, 'g8szatam', '12345', 'Rózsa István', 'ristvan98@gmail.com', '110', '196');";
                MySqlCommand cmdTesztAdatokFelhasznalok = new MySqlCommand(TesztAdatokFelhasznalok, con);
                cmdTesztAdatokFelhasznalok.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                Debug.WriteLine(ex.Message);
                throw new CreateDatabaseException("Felhasználók tesztadatainak feltöltése sikertelen!");
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

                string etelekTesztAdatok = "INSERT INTO `etelek`(`enev`, `feherje`, `szenhidrat`, `zsir`, `kaloria`, `mennyiseg`) VALUES" +
"('Szilvás Pite', 3.6, 21.8, 11.1, 207, '100gr'),"+
"('Pulyka fasírt', 15.1, 4.4, 13, 196, '100gr')," +
"('Túrós kölesfelfújt', 9.1, 9.6, 6.7, 142, '100gr')," +
"('Rántotta 3 tojásból', 12, 1.7, 12.7, 169, '100gr')," +
"('Natúr Csirkemell', 20, 0, 0, 140, '100gr')," +
"('BBQ szósz', 2, 10, 20, 200, '100gr')," +
"('Ananászos Csirkemell', 25, 7.8, 5.5, 170, '100gr')," +
"('Zabkása fehérjével', 40, 50, 11.1, 250, '100gr')," +
"('Pirított Csirkemály', 3.6, 21.8, 11.1, 207, '100gr')," +
"('Petrezselymes Krumpli', 3.6, 21.8, 11.1, 207, '100gr')," +
"('Főtt basmati rizs', 9, 70.0, 11.1, 200, '100gr')," +
"('Tojásos stefánia szelet', 20, 12.3, 11.1, 340, '100gr')," +
"('Párolt Brokkoli', 3.6, 1, 0, 80, '100gr')," +
"('Avokádó', 10, 10, 16, 240, '100gr')," +
"('T-bone steak', 20, 20.6, 14.5, 240, '100gr')," +
"('Almás Pite', 3.6, 21.8, 11.1, 320, '100gr')," +
"('Aranygaluska', 3.6, 21.8, 11.1, 207, '100gr')," +
"('Joghurt 0%', 1.7, 2.3, 0.1, 17, '50gr')," +
"('Káposzta(savanyított)', 1.1, 3.4, 0.2, 242, '100gr')," +
"('Pulykacomb', 20, 0, 7, 147, '100gr')," +
"('Sovány túró', 14, 3.4, 0.6, 80, '100gr')," +
"('Kesudió', 4.5, 8, 10.4, 149, '25gr')," +
"('Pulykamell filé', 44, 0, 12, 292, '200gr')," +
"('Alma, Jonatán', 0.4, 7, 0, 30, '100gr')," +
"('Csirkecomb', 20.9, 0.5, 5.2, 136, '100gr')," +
"('Lenmagolaj', 0, 0, 11.1, 93, '10gr'); ";
                MySqlCommand cmdEtel = new MySqlCommand(etelekTesztAdatok, con);
                cmdEtel.ExecuteNonQuery();


                string gyakorlatok = "INSERT INTO `gyakorlatok` (`gyakorlatok_id`, `gynev`, `izomcsoport_id`, `leiras`) VALUES (NULL, 'Fekvenyomás egyenes padon', '1', 'A fekvenyomás egyenes padon igénybe veszi a mellkasi izmokat, a deltaizmokat és a tricepszet. Biztosítva, hogy felkar a törzstől oldalirányban kifelé mozogjon, lassan hajlítsd be karodat és ereszd lefelé a rudat, míg az meg nem érinti a mellkasod közepét, a mellbimbók vonalában.'), (NULL, 'Fekvenyomás egykezes súlyzókkal', '1', 'A fekvenyomás egykezes súlyzókkal a mellizom középső részét edzi meg, de alapvetően az egész mellizmot stimulálja.\r\nEngedd le mindkét súlyt a mellkasod mellé, könyöködet a testre merőleges síkban tartva a mozdulat alatt, majd azonnal nyomd vissza a súlyzókat a kiinduló helyzetbe.'), (NULL, 'Fekvenyomás ferde padon', '1', 'A fekvenyomás ferde padon a felső mellizmokat, a mellső deltaizmokat és háromfejű karizmokat veszi igénybe. Nagy előnye a gyakorlatnak, hogy előnyösebb formát kölcsönöz a mellizmoknak. Vedd le a rudat a tartójáról vállszélességnél kissé szélesebb fogásvétellel. Lélegezz be, és ereszd le mellkasod legmagasabb pontjára.'), (NULL, 'Tárogatás egyenes padon', '1', 'A mellizmokat és a deltaizmokat fejleszti. Feküdj háton egy vízszintes padon két egykezes súlyzóval a kezeidben. A könyöködet enyhén behajlítva a súlyzókat távolítsd a törzsedtől ki és lefelé olyan távolra amíg feszülést nem érzel a mellkasi területen. Fontos hogy úgy végezd a gyakorlatot mintha egy ölelő mozdulatot csinálnál.'), (NULL, 'Tolódzkodás', '1', 'A rudak távol legyenek egymástól, ha közel vannak az már tricepsz tolódzkodás. Akkor fog a mellizomra hatni ha relatíve széles fogást alkalmazol. Lábaid legyenek a test előtt, álladat szegezd le a melledre, könyökeidet nyomd ki oldalra. Engedd le magad olyan mélyre amennyire cska bírod. A pozitív szakasz végén a könyék ne legyen kiakasztva.'), (NULL, 'Csigás keresztezés', '1', 'Remekül izolálja a mellizmot kizárva a segédizmokat. Könyöködet hajlítsd be enyhén és kissé dőlj előre. Húzd le a karjaidat a melled vagy a csípőd elé, majd kontrolláltan engedd vissza őket a mellizom megnyúlásáig. Tudatos ráfeszítés a két fogantyú összehúzásakor ajánlott.'), (NULL, 'Chest-press gépes nyomás', '1', 'A fekvenyomás helyettesítésére kiváló alternatíva a chest press gépes nyomás. Vállszélességnél szélesebb fogást érdemes alkalmazni és tartsd feszesen a hátadat. A fejed és csipőd a gép támlájához legyen szorítva, koncentrálj a mellizom megfeszítésére, emeld ki a mellkasodat, a vállakat ne engedd előre. Így nyomd ki a kart.'), (NULL, 'Tárogatás pec-deck gépen', '1', 'Remekül fejleszti a mellizom belső régióit. Az alkarodat felfelé tartva fogd meg a gép fogantyúit. A mellizom megfeszítésével nyomd össze a karokat majd lassú mozgással engedd vissza a kiinduló helyzetbe.'), (NULL, 'Fekvenyomás ferdepadon kézisúlyzókkal', '1', 'A mellizom felső izomrostjait stimulálja elsősorban, de a tricepsz és a delta első feje is jelentős terhelést kap. Egy 35-40 fokos szögbe állított padon érdemes végezni a gyakorlatot, nagyobb dőlésszög esetén túl nagy szerepet kap az elülső deltaizom. Nyomd ki a kézisúlyzókat egyszerre, nyújtsd ki teljesen a karod, majd azonnal engedd vissza a súlyzókat a kiindulási helyzetbe.'), (NULL, 'Mellhez húzás széles fogással', '2', 'A széles hátizmokat dolgoztatja meg elsősorban, de a bicepsz és az alkar is kap másodlagos terhelést. A cél az lenne, hogy ezt kiküszöböld. Húzd le a rudat a könyöködre koncentrálva - ez segít, hogy kikapcsold a bicepszed a munkából amennyire csak lehet.'), (NULL, 'Felhúzás', '2', 'Másnéven deadlift. Az erőemelés harmadik gyakorlata. A guggolás mellett a leghatásosabb teljes testet megmozgató gyakorlat. Erősíti a fogást. A hát alsó és középső részének izomzatát, a csipő izmait, a combizmokat és a csuklyás izmot is stimulálja. Állj úgy, hogy lábszárcsont éppen érintse a súlyzót. Hajolj előre, és ragadd meg a rudat. Egyenesedj ki, természetesen használva lábad és hátad együttes erejét.'), (NULL, 'Döntött törzsű evezés', '2', 'A széles hátizmokat dolgoztatja meg leginkább. Másodlagos hatással van a csuklyás izomra, a deltaizom hátsó felére. Állj vállszélességű terpeszbe, dőlj előre min. 45 fokos szögig. Térded legyen kissé behajlítva. Húzd fel a rudat a hasad/mellkas irányába úgy, hogy a könyöködre koncentrálsz a mozdulat ideje alatt. Ez fog segíteni, hogy kikapcsold a bicepszedet a mozgásból. Amikor a rúd megérinti a törzsedet engedd vissza a kiinduló pozícióba'), (NULL, 'Kábeles evezés', '2', 'A hagyományos, szűk fogantyúval végezve a hátizom alsó részét dolgoztatja meg. A fogás szélességétől függően stimulálhatod a belső és külső részeket is. Rögzítsd a lábadat, majd húzd a fogantyút a tested középső része felé, vízszintes irányban. Maradj ebben a helyzetben két másodpercig, majd engedd vissza a karodat lassan amíg a hátizmok meg nem nyúlnak teljesen. A karok kinyúlásakor próbálj meg arra törekedni, hogy a hátizom is megnyúljon'), (NULL, 'T-rudas evezés', '2', 'Egy kiváló gyakorlat a hátizom vastagságának növelésére. Fogd meg a fogantyút vagy a rudat és egyenesedj fel kb 45 fokos szögig. Húzd a hasadhoz a rudat/fogantyút, majd amikor a tárcsák megérintik a hasadat, engedd vissza a súlyokat. Leengedéskor az egész hátizomnak meg kell nyúlnia nem csak a karoknak.'), (NULL, 'Fűrészelés', '2', 'A hát felső izmait de leginkább a széles hátizmokat dolgoztatja meg. Ezt a gyakorlatot lehet padon végezni, vagy bárhol ahol az egyik karoddal meg tudsz támaszkodni. Ha megtámaszkodtál ragadd meg a padlón lévő egykezes súlyzót, majd emeld a vállad magasságáig vagy még feljebb a hátizmaidat használva. Lassan engedd vissza a kézisúlyzót hadd nyúljon ki a hátizom.'), (NULL, 'Vállból nyomás egykezes súlyzóval', '3', 'Elsősorban az első és az oldalsó deltaizmokat fejleszti. Egyenes háttal, emelt fejjel ülj a padon. A vállaid magasságánál kicsit feljebb tarts két kézisúlyzót. Nyomd ki a két súlyzót a fejed fölé egyszerre. Majd lassan kontrolláltan engedd vissza a kiinduló pozicíóig'), (NULL, 'Oldalemelés ', '3', 'Az oldalsó deltaizmokat fejleszti leginkább. A gyakorlat végzése közben a könyökre kell koncentrálni. Emeld fel a két súlyzót vállmagasságig úgy mintha egy kancsóbol vizet öntenél ki. Majd engedd vissza lassan és kontrolláltan'), (NULL, 'Mellről nyomás ülve', '3', 'Elsődleges terhelés az elülső delták számára, de az oldalsó delta is beleszól a mozgásba. Minél jobban kiforgatod a könyököd annál jobban terheled az oldalsó rostokat. Fogd meg a kétkezes rudat vállszélességben vagy kicsit szélesebben. Emeld ki majd engedd le a rudat fülmagasságig majd nyomd ki a fejed fölé.'), (NULL, 'Arnold nyomás', '3', 'A deltaizom első és oldalsó fejét stimulálja. Fogj egy-egy súlyzót úgy hogy a súlyokat vállmagasságban az arcod előtt tartod. Tenyerek az arcod felé néznek. Emeld fel a súlyt a fejed fölé egyenes vonalban, miközben a tenyereidet kifelé fordítod. A súly a felső pozícióba úgy érkezik, hogy a tenyereid kifelé néznek. Ugyanezen az útvonalon engedd vissza a súlyt a kiinduló pozícióba.'), (NULL, 'Állig húzás', '3', 'Erősíti a delta és a csuklyás izmot. Állj egyenesen szűk fogást felvéve. tenyerek a test felé. Lassan húzd a súlyzót felfelé tested közelében egy vonal mentén, könyöködet felfelé emelve és mindig a kezed vonala fölött tartva. Amint a rúd nyakmagasságba ér, tarts szünetet, és ereszd le a súlyzót lassan ugyanezen vonalon, egészen addig, míg a combodhoz ér.'), (NULL, 'Előreemelés', '3', 'A deltaizom elülső rostjait hivatott megdolgoztatni. Álló helyzetben fogj a kezeidben egy pár kézisúlyzót. Egyik kezed emeld fel egyenesen magad előtt, amíg a súly magasabbra kerül a szemednél, majd miközben ezt a karodat leereszted, ezzel párhuzamosan emeld fel a másikat.'), (NULL, 'Guggolás', '9', 'A guggolás egy olyan alapgyakorlat, ami megfelelően végrehajtva a teljes testet megedzi. Állj kiegyenesedve egy kétkezes súlyzó rúdját egyensúlyozva a nyakad mögött a hátadon keresztben. Tedd sarkaidat egymástól 30-50 cm-re úgy, hogy lábfejeid kissé kifelé mutassanak. Szemeddel nézz egy pontra magad elé, szemmagasságnál kicsit feljebb, és tartsd tekintetedet azon a ponton az egész mozgás során. Ezután lassan hajlítsd be térdedet, és ereszd le tested teljes guggolásba.'), (NULL, 'Lábtolás', '9', 'Sok testépítő jobban kedveli ezt a gyakorlatot, mint a guggolást, mert lehetővé teszi, hogy teljes mértékben a láb mozgására összpontosítsanak, anélkül, hogy a csípő jelentősebb mértékben részt venne a mozdulatban. Helyezd a lábaidat egymástól mintegy harminc centiméterre a készülék taposólemeze alá. Nyomd ki a lábaidat, amíg a lábad ki nem egyenesedik, de a térdedet ne akaszd ki. Engedd vissza a súlyt, és ismételd a gyakorlatot.'), (NULL, 'Lábnyújtás', '9', 'Legjobb izolációs gyakorlat a combizom igénybevételére. Ülj be a gépbe, hogy a térdhajlatod a pad emelőkar felőli oldalának végéhez illeszkedjen. A quadricepsz erejét használva, lassan egyenesítsd ki lábadat. Tartsd ki a csúcsösszehúzódást 1-2 másodpercig, majd lassan engedd vissza a lábadat.'), (NULL, 'Lábhajlítás', '9', 'Ülj a gépbe, támaszd ki a hátadat és tartsd is a támlához szorítva végig a gyakorlat ideje alatt. Akaszd be sarkad a görgőpárnák alá, és nyújtsd ki teljesen a lábad. A láb kétfejű izmait használva hajlítsd be a lábadat, amennyire csak tudod. Tartsd ki ezt a leginkább összehúzott helyzetet 1-2 másodpercig, majd ereszkedj vissza a kiinduló pontig.'), (NULL, 'Kitörés', '9', 'Ez a mozgás a combhajlítókat, a farizmokat és a négyfejű combizmot fejleszti. Állj egyenesen. Egy nagy lépést lépj előre, és kinyújtott lábaddal lassan süllyedj guggolásba. Amint leereszkedtél ebbe a helyzetbe, tégy egy újabb lépést előre a másik lábaddal, úgy, hogy közben kinyújtod az eddig behajlított lábadat, tehát fel-le ereszkedve lépegetsz előre.'), (NULL, 'Hack guggolás', '9', 'Ez a gyakorlat a comb középső és alsó részét stimulálja, emellett a terpesz szélességével is tudod irányítani a stimuláció helyét. Guggolj le minimum addig, amíg a combod derékszöget nem zár be a lábszáraddal (de legjobb, ha teljesen leguggolsz), majd nyújtsd ki a lábadat, de figyelj rá, hogy a térdedet ne akasszad ki. A térd kiakasztásával, valamint az alsó ponton rugózással tudsz a legtöbbet ártani magadnak ennél a gyakorlatnál.'), (NULL, 'Merevlábas felhúzás', '9', 'A gyakorlat kisebb súllyal helyesen végezve a comb-bicepszet és az alsó hátat erősíti.\r\nTarts a kezedben egy kétkezes rudat, nem túl nagy súllyal felpakolva. A térdedet mozdulatlanul tartva, mereven tartva hajolj előre, miközben a csípőd enyhén hátrafelé tolódik, hogy az egyensúlyodat meg tudd tartani. A súlynak nem szabad nagynak lennie, mert ez a gyakorlat fokozottan terheli a gerincet és az alsó hátat. Engedd a comb-bicepszet maximálisan kinyúlni, majd lassú de határozott mozdulattal emelkedj fel, a csípődet előre mozgatva.'); INSERT INTO `gyakorlatok` (`gyakorlatok_id`, `gynev`, `izomcsoport_id`, `leiras`) VALUES" +
"(35, 'Bicepsz állva kétkezes rúddal', 4, 'A kétfejű karizmokat veszi igénybe. Állj egyenesen, vállszélességű fogással a kétkezes súlyzón, a tenyerek előre néznek. Csak alkart mozgatva hajlítsd be a karodat, és mozgasd a súlyzót felfelé, félkörívben az állad irányába.'),"+
"(36, 'Bicepsz Scott padon', 4, 'Helyezkedj el a Scott-pad mögött kényelmesen. Mindkét karoddal egyszerre emeld fel a súlyt addig, míg az alkarod a bicepszedhez nem ér. Lassan engedd vissza a súlyokat, kihasználva a teljes mozgástartományt.'),"+
"(37, 'Kalapács bicepsz', 4, 'A kalapács-bicepsz gyakorlat a bicepsz alatt futó brachialis izmot és az alkar izmait dolgoztatja meg. Ragadj meg mindkét kezedben egy-egy kézisúlyzót, és tartsd őket a tested mellett, a tenyereid nézzenek a tested irányába. A könyöködet egy helyben tartva, lassan és egyenletesen emeld az egyik súlyzót a válladhoz. Ereszd vissza, és a másik karral is ismételd a mozdulatot.'),"+
"(38, 'Bicepsz ülve egykezes kézisúlyzóval', 4, 'A bicepsz edzés egykezes súlyzóval egy kiváló bicepszgyakorlat, amely igénybe veszi az alkar hajlítóizmait is. A bal kezedben lévő súlyt hajlítással emeld felfelé, a csuklódat közben úgy forgatva, hogy tenyered a mozgás második felében felfelé nézzen. Végezd ugyanezt a mozgást visszafelé a súlyt leeresztve a kiinduló helyzetbe.'); INSERT INTO `gyakorlatok` (`gyakorlatok_id`, `gynev`, `izomcsoport_id`, `leiras`) VALUES (NULL, 'Csigás letolás', '5', 'Kiválóan képes hangsúlyozni a jellegzetes \"lópatkót\". Elsősorban izolációs gyakorlatként érdemes rá tekinteni. Nyomd le a rudat egészen addig, amíg a karjaid ki nem egyenesednek. Engedd vissza a súlyt, és ismételd meg a mozdulatot. A legtöbben e gyakorlat során a könyöküket szorosan az oldalukhoz szorítják, de néhányan viszont oldalt kinyomják és \"belehajolnak\" a mozdulatba. Fontos azonban, hogy a könyök mozdulatlan legyen'), (NULL, 'Csigás letolás kötéllel', '5', 'A kötéllel végzett mozgás kisebb súly, ám nagyobb mozgástartomány használatát feltételezi. Emellett a gyakorlat végpontján sokkal jobban rá tudsz feszíteni a tricepszedre. A gyakorlatot kétféle módon végezheted: vagy a tested mellé húzod le a kötél két végét, vagy pedig az egész gyakorlatot a tested előtt végzed, kifelé megfeszítve a kötél végeit. Mindkét variáció másféle érzetet kelt a tricepszedben.'), (NULL, 'Tricepsznyújtás fekve', '5', 'Mindhárom fej erős terhelést kap, de a legjobban a tricepsz hosszú feje (long head) dolgozik a gyakorlat közben. Felkarodat mozdulatlanul tartva, hajlítsd be könyöködet, és mozgasd a súlyzót félkörívben egészen addig, amíg a homlokodhoz nem ér, vagy a fejed felett túl nem megy a padon.'), (NULL, 'Szűknyomás', '5', 'A szűknyomás elsődlegesen a mellizmokat, a deltaizom elülső fejét és a háromfejű karizmot veszi igénybe. Keskeny felső fogást alkalmazz. Hajlítsd be karodat, és lassan ereszd le a súlyzót egészen addig, amíg mellkasodat nem érinti. Nyomd lassan vissza a kiinduló pontra, és ismételd a mozgást az előírt számban.'), (NULL, 'Lórugás', '5', 'A lórúgás csaknem kizárólag a háromfejű karizmot építi. Izolációs gyakorlat, segédizmok gyakorlatilag nem kapcsolódnak be a mozgásba. Így nagy súlyokkal nem is lehet, és nem is célszerű végezni. Előrehajolva támaszkodj egyik kezeddel egy pad végére és másik kezedben tarts egy egykezes súlyzót. A könyöködet tartsd magasan, de stabilan, és egyenesítsd ki alkarodat. Csak az alkaroddal végezd a mozgást.'); INSERT INTO `gyakorlatok` (`gyakorlatok_id`, `gynev`, `izomcsoport_id`, `leiras`) VALUES (NULL, 'Felülés', '8', 'A felülés a teljes egyenes hasizmot, különösen az izomzat felső felét fejleszti. Feküdj le például egy bordásfal elé, akaszd be a lábadat. Végezz felülés, figyelve arra, hogy a hasizom erejét használod, nem pedig a csipő hajlítóizmait. A hátadat görbítsd be ennek érdekében. A mellkasodat közelítsd a térded felé. '), (NULL, 'Hasprés', '8', 'A hasprés a hasizmok felső részét dolgozza meg, de jó technikával az egyenes hasizom egésze kellő terhelést kap. Feküdj hanyatt. A karodat fond össze a tested előtt, vagy kulcsold össze a fejed mögött. Lassan hajlítsd vállát a térded felé, annyira, hogy lapockáid 3-5 cm-re eltávolodjanak a padlótól. Tarts ki így egy másodpercig, majd ereszkedj vissza a kiinduló helyzetbe és ismételj.'), (NULL, 'Lábkeresztezés fekve', '8', 'A lábkeresztezés fekve az egyenes hasizmokat, a ferde hasizmokat és a csípő izmait fejleszti. Feküdj háttal a padlóra egy olyan helyen, ahol a kezeddel megkapaszkodhatsz. A gyakorlat alatt a vállaiad tartsd a padlón. Miközben a jobb lábadat szorosan a padlón tartod, emeld a bal lábad enyhén fel, és a padlóval párhuzamosan húzd fel a jobb könyököd felé. A lábaid tartsd kinyújtva az egész gyakorlat alatt. A térdeidet ne hajlítsd be.'), (NULL, 'Térdfelhúzás ülve', '8', 'A térdfelhúzás ülve igénybe veszi a teljes egyenes hasizmot, különösen az izomcsoport alsó harmadát. Ülj egy vízszintes pad végére, és hajtsd hátra törzsedet addig, amíg a paddal 45 fokos szöget nem zár be. Fogd meg a pad széleit, hogy felsőtestedet ebben a helyzetben rögzítsd. Nyújtsd ki lábadat lefelé addig, míg a padlóval körülbelül 45 fokos szöget nem zár be, felsőtested vonalának folytatásaként. Hasizmaid erejét használva húzd fel térdedet a mellkasodhoz, míg ezzel egy időben teljesen hajlítsd be lábad.'), (NULL, 'Lábemelés', '8', 'Az alsó hasizmokat dolgoztatja meg, le, egészen az ágyékig. Nagyon fontos, hogy ne csak a lábunkat, térdünket emelgessük, hanem begörbítsük a csipőt is, mert a hasizom csak ebben az esetben tud összehúzótni. Lábaidat tartsd kinyújtva, és emeld azokat a padlóval párhuzamos helyzetnél magasabbra, majd engedd vissza és ismételd a mozdulatot.'), (NULL, 'Kábeles hasprés', '8', 'A kábeles hasprés a hasizmokat és a fűrészizmokat dolgoztatja meg leginkább. Térdelj le egy felső csiga előtt, melyre egy tricepsz kötelet erősítesz. Fogd meg a kötelet úgy, hogy a végei a nyakad mellett vannak amikor előredőlsz. A hasizmod erejével görbítsd be a tested. Ezt akkor fogod tudni elérni, ha a hátad domború. A csípő legyen mozdulatlan, felsőtestből mozogj, a mellkasod előredöntésére koncentrálj.'); INSERT INTO `gyakorlatok` (`gyakorlatok_id`, `gynev`, `izomcsoport_id`, `leiras`) VALUES (NULL, 'Álló vádligép', '7', 'Ez a gyakorlat a kétfejű lábikraizmot, azaz a vádlit, valamint a talpemelő izmot fejleszti. Áll a vádligépbe úgy, hogy csak a talppárnáidon támaszkodj. Emelkedj lábujjhegyre és ereszkedj vissza, anélkül, hogy nagyon behajlítanád a térdedet vagy visszarugóznál az alsó holtpontról.'), (NULL, 'Ülő vádligép', '7', 'Ezt a gyakorlatot is egy speciális gépen kell végezni. A végzett mozdulat inkább a talpemelő izmot mozgatja meg. Ülj be a gépbe, a térdedet szorítsd be a támasz alá úgy, hogy a vádlid megnyújtott állapotban legyen. Akaszd ki a rögzítő kart. Emeld meg a vádlidat amennyire tudod, feszíts rá a felső ponton, majd lassan engedd vissza.'); INSERT INTO `gyakorlatok` (`gyakorlatok_id`, `gynev`, `izomcsoport_id`, `leiras`) VALUES (NULL, 'Csuklóbehúzás', '6', 'Ez a gyakorlat erősen fejleszti az alkar izmait. Ülj le egy pad végére, alkarod a combodon legyen úgy, hogy a csuklód a térdeden túllógjon. Tenyereddel felfelé fogd meg a rudat. Csuklód hajlításával billentsd a súlyzót olyan magasra, amilyen magasra csak tudod. Térj vissza a kiinduló helyzetbe, majd ismételd a mozdulatot.'), (NULL, 'Csuklófeszítés', '6', 'Végrehajtása során az alkar külső oldalán lévő feszítő izmok vannak igénybe véve. Ülj le egy pad végére, alkarod a combodon legyen úgy, hogy a csuklód a térdeden túllógjon. Tenyereddel lefelé fogd meg a rudat. Csuklód hajlításával billentsd a súlyzót olyan magasra, amilyen magasra csak tudod. Térj vissza a kiinduló helyzetbe, majd ismételd a mozdulatot.'); ";
                MySqlCommand cmdgyakorlatok = new MySqlCommand(gyakorlatok, con);
                cmdgyakorlatok.ExecuteNonQuery();

                string tervek = "INSERT INTO `edzestervek` (`edzesterv_id`, `gyakorlat_id`, `sorozatszam`, `ismetlesszam`) VALUES " +
                    "(NULL, '3', '1', '2')," +
                    "(NULL, '4', '1', '2')," +
                    "(NULL, '5', '12', '2')," +
                    "(NULL, '6', '13', '2')," +
                    "(NULL, '6', '14', '2')," +
                    "(NULL, '5', '145', '2')," +
                    "(NULL, '5', '145', '2')," +
                    "(NULL, '4', '134', '2')," +
                    "(NULL, '2', '1', '2')," +
                    "(NULL, '3', '133', '2')," +
                    "(NULL, '1', '1', '2')," +
                    "(NULL, '5', '1', '2')," +
                    "(NULL, '4', '1', '2')," +
                    "(NULL, '4', '1', '2')," +
                    "(NULL, '6', '1', '2')," +
                    "(NULL, '1', '1', '2')," +
               "(NULL, '1', '1', '2');";
                MySqlCommand cmdtervek = new MySqlCommand(tervek, con);
                cmdtervek.ExecuteNonQuery();

                string edzesek = "INSERT INTO `edzesek` (`edzesek_id`, `idopont`, `f_id`, `edzesterv_id`) VALUES " +
                    "(NULL, '2020-03-12 00:00:00', '1', '1'),"+
                    "(NULL, '2020-03-14 00:00:00', '1', '4'),"+
                    "(NULL, '2020-03-15 00:00:00', '1', '3'),"+
                    "(NULL, '2020-03-17 00:00:00', '1', '5'),"+
                    "(NULL, '2020-03-17 00:00:00', '1', '10'),"+
                    "(NULL, '2020-03-17 00:00:00', '1', '11'),"+
                    "(NULL, '2020-03-17 00:00:00', '1', '14'),"+
                    "(NULL, '2020-03-17 00:00:00', '1', '9'),"+
                    "(NULL, '2020-03-19 00:00:00', '1', '10'),"+
                    "(NULL, '2020-03-19 00:00:00', '1', '11'),"+
                    "(NULL, '2020-03-19 00:00:00', '1', '8'),"+
                    "(NULL, '2020-03-19 00:00:00', '1', '7'),"+
                    "(NULL, '2020-03-19 00:00:00', '1', '6');";
                MySqlCommand cmdedzesek = new MySqlCommand(edzesek, con);
                cmdedzesek.ExecuteNonQuery();

           
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();   
                Debug.WriteLine(e.Message);
                throw new CreateDatabaseException("Tesztadatok feltöltése sikertelen!");
            }
        }
        public void torolTesztadatok()
        {
            MySqlConnection con = new MySqlConnection(connectionString);
            try
            {
                con.Open();
                string query = "DELETE FROM edzesek; " +
                    "DELETE FROM edzestervek; DELETE FROM gyakorlatok; DELETE FROM izomcsoportok; DELETE FROM etkezesek; DELETE FROM etelek; " +
                    "DELETE FROM felhasznalok";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new CreateDatabaseException("Tesztadatok törlése sikertelen!");
            }
        }
        
    }
}
