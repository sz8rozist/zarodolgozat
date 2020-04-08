-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Ápr 08. 10:31
-- Kiszolgáló verziója: 10.4.8-MariaDB
-- PHP verzió: 7.1.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `buildyourbody`
--
CREATE DATABASE IF NOT EXISTS `buildyourbody` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `buildyourbody`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `edzesek`
--

CREATE TABLE `edzesek` (
  `edzesek_id` int(11) NOT NULL,
  `idopont` date NOT NULL DEFAULT curdate(),
  `f_id` int(11) NOT NULL,
  `edzesterv_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `edzesek`
--

INSERT INTO `edzesek` (`edzesek_id`, `idopont`, `f_id`, `edzesterv_id`) VALUES
(1, '2020-03-12', 1, 1),
(2, '2020-03-14', 1, 4),
(3, '2020-03-15', 1, 3),
(4, '2020-03-17', 1, 5),
(5, '2020-03-17', 1, 10),
(6, '2020-03-17', 1, 11),
(7, '2020-03-17', 1, 14),
(8, '2020-03-17', 1, 9),
(9, '2020-03-19', 1, 10),
(10, '2020-03-19', 1, 11),
(11, '2020-03-19', 2, 5),
(12, '2020-03-19', 2, 3),
(13, '2020-03-19', 2, 2),
(14, '2020-03-12', 2, 12),
(15, '2020-03-14', 2, 4),
(16, '2020-03-15', 2, 12),
(17, '2020-03-17', 2, 1),
(18, '2020-03-17', 2, 15),
(19, '2020-03-17', 2, 11),
(20, '2020-03-17', 2, 14),
(21, '2020-03-17', 3, 9),
(22, '2020-03-19', 3, 10),
(23, '2020-03-19', 3, 11),
(24, '2020-03-19', 3, 8),
(25, '2020-03-19', 3, 7),
(26, '2020-03-19', 3, 3),
(27, '2020-03-12', 3, 14),
(28, '2020-03-14', 3, 11),
(29, '2020-03-15', 3, 9),
(30, '2020-03-17', 4, 1),
(31, '2020-03-17', 4, 10),
(32, '2020-03-17', 4, 11),
(33, '2020-03-17', 4, 14),
(34, '2020-03-17', 4, 9),
(35, '2020-03-19', 4, 10),
(36, '2020-03-19', 1, 11),
(37, '2020-03-19', 2, 7),
(38, '2020-03-19', 3, 4),
(39, '2020-03-19', 4, 10),
(40, '2020-03-17', 1, 13),
(41, '2020-03-19', 1, 10),
(42, '2020-03-19', 1, 18),
(43, '2020-03-19', 2, 8),
(44, '2020-03-19', 2, 7),
(45, '2020-03-19', 2, 6),
(46, '2020-03-12', 2, 1),
(47, '2020-03-14', 2, 4),
(48, '2020-03-15', 2, 3),
(49, '2020-03-17', 2, 5),
(50, '2020-03-17', 2, 10),
(51, '2020-03-17', 2, 11),
(52, '2020-03-17', 2, 14),
(53, '2020-03-17', 3, 9),
(54, '2020-03-19', 3, 10),
(55, '2020-03-19', 3, 11),
(56, '2020-03-19', 3, 8),
(57, '2020-03-19', 3, 7),
(58, '2020-03-19', 3, 6),
(59, '2020-03-12', 3, 1),
(60, '2020-03-14', 3, 4),
(61, '2020-03-15', 3, 3),
(62, '2020-03-17', 4, 5),
(63, '2020-03-17', 4, 10),
(64, '2020-03-17', 4, 11),
(65, '2020-03-17', 4, 14),
(66, '2020-03-17', 4, 9),
(67, '2020-03-19', 4, 10),
(68, '2020-03-19', 1, 11),
(69, '2020-03-19', 2, 8),
(70, '2020-03-19', 3, 7),
(71, '2020-03-19', 4, 6);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `edzestervek`
--

CREATE TABLE `edzestervek` (
  `edzesterv_id` int(11) NOT NULL,
  `gyakorlat_id` int(11) NOT NULL,
  `sorozatszam` int(11) NOT NULL,
  `ismetlesszam` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `edzestervek`
--

INSERT INTO `edzestervek` (`edzesterv_id`, `gyakorlat_id`, `sorozatszam`, `ismetlesszam`) VALUES
(1, 3, 1, 2),
(2, 4, 1, 2),
(3, 5, 12, 2),
(4, 40, 13, 2),
(5, 36, 14, 2),
(6, 5, 145, 2),
(7, 5, 145, 2),
(8, 20, 134, 2),
(9, 25, 1, 2),
(10, 22, 133, 2),
(11, 1, 1, 2),
(12, 5, 1, 2),
(13, 4, 1, 2),
(14, 4, 1, 2),
(15, 6, 1, 2),
(16, 1, 1, 2),
(17, 10, 1, 2),
(18, 35, 1, 2),
(19, 14, 1, 2),
(20, 45, 12, 2),
(21, 50, 13, 2),
(22, 6, 14, 2),
(23, 5, 145, 2),
(24, 5, 145, 2),
(25, 4, 134, 2),
(26, 2, 1, 2),
(27, 19, 133, 2),
(28, 17, 1, 2),
(29, 28, 1, 2),
(30, 4, 1, 2),
(31, 4, 1, 2),
(32, 6, 1, 2),
(33, 1, 1, 2);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `etelek`
--

CREATE TABLE `etelek` (
  `etel_id` int(11) NOT NULL,
  `enev` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `feherje` double NOT NULL,
  `szenhidrat` double NOT NULL,
  `zsir` double NOT NULL,
  `kaloria` int(11) NOT NULL,
  `mennyiseg` varchar(20) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `etelek`
--

INSERT INTO `etelek` (`etel_id`, `enev`, `feherje`, `szenhidrat`, `zsir`, `kaloria`, `mennyiseg`) VALUES
(1, 'Szilvás Pite', 3.6, 21.8, 11.1, 207, '100gr'),
(2, 'Pulyka fasírt', 15.1, 4.4, 13, 196, '100gr'),
(3, 'Túrós kölesfelfújt', 9.1, 9.6, 6.7, 142, '100gr'),
(4, 'Rántotta 3 tojásból', 12, 1.7, 12.7, 169, '100gr'),
(5, 'Natúr Csirkemell', 20, 0, 0, 140, '100gr'),
(6, 'BBQ szósz', 2, 10, 20, 200, '100gr'),
(7, 'Ananászos Csirkemell', 25, 7.8, 5.5, 170, '100gr'),
(8, 'Zabkása fehérjével', 40, 50, 11.1, 250, '100gr'),
(9, 'Pirított Csirkemály', 3.6, 21.8, 11.1, 207, '100gr'),
(10, 'Petrezselymes Krumpl', 3.6, 21.8, 11.1, 207, '100gr'),
(11, 'Főtt basmati rizs', 9, 70, 11.1, 200, '100gr'),
(12, 'Tojásos stefánia sze', 20, 12.3, 11.1, 340, '100gr'),
(13, 'Párolt Brokkoli', 3.6, 1, 0, 80, '100gr'),
(14, 'Avokádó', 10, 10, 16, 240, '100gr'),
(15, 'T-bone steak', 20, 20.6, 14.5, 240, '100gr'),
(16, 'Almás Pite', 3.6, 21.8, 11.1, 320, '100gr'),
(17, 'Aranygaluska', 3.6, 21.8, 11.1, 207, '100gr'),
(18, 'Joghurt 0%', 1.7, 2.3, 0.1, 17, '50gr'),
(19, 'Káposzta(savanyított', 1.1, 3.4, 0.2, 242, '100gr'),
(20, 'Pulykacomb', 20, 0, 7, 147, '100gr'),
(21, 'Sovány túró', 14, 3.4, 0.6, 80, '100gr'),
(22, 'Kesudió', 4.5, 8, 10.4, 149, '25gr'),
(23, 'Pulykamell filé', 44, 0, 12, 292, '200gr'),
(24, 'Alma, Jonatán', 0.4, 7, 0, 30, '100gr'),
(25, 'Csirkecomb', 20.9, 0.5, 5.2, 136, '100gr'),
(26, 'Lenmagolaj', 0, 0, 11.1, 93, '10gr');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `etkezesek`
--

CREATE TABLE `etkezesek` (
  `etkezesek_id` int(11) NOT NULL,
  `idopont` date NOT NULL,
  `etel_id` int(11) NOT NULL,
  `f_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `etkezesek`
--

INSERT INTO `etkezesek` (`etkezesek_id`, `idopont`, `etel_id`, `f_id`) VALUES
(1, '2020-05-19', 4, 1),
(2, '2020-05-19', 2, 1),
(3, '2020-05-19', 12, 1),
(4, '2020-05-19', 23, 1),
(5, '2020-05-19', 5, 1),
(6, '2020-05-19', 6, 1),
(7, '2020-05-19', 7, 1),
(8, '2020-07-19', 9, 1),
(9, '2020-07-19', 1, 1),
(10, '2020-07-19', 6, 1),
(11, '2020-07-19', 16, 1),
(12, '2020-06-19', 20, 1),
(13, '2020-06-19', 23, 1),
(14, '2020-06-19', 21, 1),
(15, '2020-06-19', 11, 1),
(16, '2020-06-19', 15, 1),
(17, '2020-03-19', 1, 2),
(18, '2020-03-19', 2, 2),
(19, '2020-03-19', 11, 2),
(20, '2020-03-19', 14, 2),
(21, '2020-03-19', 23, 2),
(22, '2020-07-19', 20, 2),
(23, '2020-07-19', 17, 2),
(24, '2020-07-19', 18, 2),
(25, '2020-07-19', 19, 2),
(26, '2020-07-19', 9, 2),
(27, '2020-09-19', 5, 3),
(28, '2020-09-19', 6, 3),
(29, '2020-09-19', 7, 3),
(30, '2020-09-19', 8, 3),
(31, '2020-09-19', 9, 3),
(32, '2020-01-19', 11, 3),
(33, '2020-01-19', 14, 3),
(34, '2020-01-19', 25, 3),
(35, '2020-01-19', 24, 3),
(36, '2020-01-19', 23, 3),
(37, '2020-10-19', 10, 4),
(38, '2020-10-19', 11, 4),
(39, '2020-10-19', 12, 4),
(40, '2020-10-19', 13, 4),
(41, '2020-10-19', 14, 4),
(42, '2020-12-19', 21, 4),
(43, '2020-12-19', 22, 4),
(44, '2020-12-19', 23, 4),
(45, '2020-12-19', 25, 4),
(46, '2020-12-19', 11, 4);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `felhasznalok`
--

CREATE TABLE `felhasznalok` (
  `f_id` int(11) NOT NULL,
  `fname` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `jelszo` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `teljesnev` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `email` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `tsuly` int(11) NOT NULL,
  `tmagassag` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `felhasznalok`
--

INSERT INTO `felhasznalok` (`f_id`, `fname`, `jelszo`, `teljesnev`, `email`, `tsuly`, `tmagassag`) VALUES
(1, 'sz8rozist', '12345', 'Rózsa István', 'ristvan98@gmail.com', 110, 196),
(2, 'admin', '12345', 'Rózsa István', 'ristvan98@gmail.com', 110, 196),
(3, 'Valami', '12345', 'Rózsa István', 'ristvan98@gmail.com', 110, 193),
(4, 'Adam', '12345', 'Rózsa István', 'ristvan98@gmail.com', 110, 194);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `gyakorlatok`
--

CREATE TABLE `gyakorlatok` (
  `gyakorlatok_id` int(11) NOT NULL,
  `gynev` varchar(100) COLLATE utf8_hungarian_ci NOT NULL,
  `izomcsoport_id` int(11) NOT NULL,
  `leiras` text COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `gyakorlatok`
--

INSERT INTO `gyakorlatok` (`gyakorlatok_id`, `gynev`, `izomcsoport_id`, `leiras`) VALUES
(1, 'Fekvenyomás egyenes padon', 1, 'A fekvenyomás egyenes padon igénybe veszi a mellkasi izmokat, a deltaizmokat és a tricepszet. Biztosítva, hogy felkar a törzstől oldalirányban kifelé mozogjon, lassan hajlítsd be karodat és ereszd lefelé a rudat, míg az meg nem érinti a mellkasod közepét, a mellbimbók vonalában.'),
(2, 'Fekvenyomás egykezes súlyzókkal', 1, 'A fekvenyomás egykezes súlyzókkal a mellizom középső részét edzi meg, de alapvetően az egész mellizmot stimulálja.\r\nEngedd le mindkét súlyt a mellkasod mellé, könyöködet a testre merőleges síkban tartva a mozdulat alatt, majd azonnal nyomd vissza a súlyzókat a kiinduló helyzetbe.'),
(3, 'Fekvenyomás ferde padon', 1, 'A fekvenyomás ferde padon a felső mellizmokat, a mellső deltaizmokat és háromfejű karizmokat veszi igénybe. Nagy előnye a gyakorlatnak, hogy előnyösebb formát kölcsönöz a mellizmoknak. Vedd le a rudat a tartójáról vállszélességnél kissé szélesebb fogásvétellel. Lélegezz be, és ereszd le mellkasod legmagasabb pontjára.'),
(4, 'Tárogatás egyenes padon', 1, 'A mellizmokat és a deltaizmokat fejleszti. Feküdj háton egy vízszintes padon két egykezes súlyzóval a kezeidben. A könyöködet enyhén behajlítva a súlyzókat távolítsd a törzsedtől ki és lefelé olyan távolra amíg feszülést nem érzel a mellkasi területen. Fontos hogy úgy végezd a gyakorlatot mintha egy ölelő mozdulatot csinálnál.'),
(5, 'Tolódzkodás', 1, 'A rudak távol legyenek egymástól, ha közel vannak az már tricepsz tolódzkodás. Akkor fog a mellizomra hatni ha relatíve széles fogást alkalmazol. Lábaid legyenek a test előtt, álladat szegezd le a melledre, könyökeidet nyomd ki oldalra. Engedd le magad olyan mélyre amennyire cska bírod. A pozitív szakasz végén a könyék ne legyen kiakasztva.'),
(6, 'Csigás keresztezés', 1, 'Remekül izolálja a mellizmot kizárva a segédizmokat. Könyöködet hajlítsd be enyhén és kissé dőlj előre. Húzd le a karjaidat a melled vagy a csípőd elé, majd kontrolláltan engedd vissza őket a mellizom megnyúlásáig. Tudatos ráfeszítés a két fogantyú összehúzásakor ajánlott.'),
(7, 'Chest-press gépes nyomás', 1, 'A fekvenyomás helyettesítésére kiváló alternatíva a chest press gépes nyomás. Vállszélességnél szélesebb fogást érdemes alkalmazni és tartsd feszesen a hátadat. A fejed és csipőd a gép támlájához legyen szorítva, koncentrálj a mellizom megfeszítésére, emeld ki a mellkasodat, a vállakat ne engedd előre. Így nyomd ki a kart.'),
(8, 'Tárogatás pec-deck gépen', 1, 'Remekül fejleszti a mellizom belső régióit. Az alkarodat felfelé tartva fogd meg a gép fogantyúit. A mellizom megfeszítésével nyomd össze a karokat majd lassú mozgással engedd vissza a kiinduló helyzetbe.'),
(9, 'Fekvenyomás ferdepadon kézisúlyzókkal', 1, 'A mellizom felső izomrostjait stimulálja elsősorban, de a tricepsz és a delta első feje is jelentős terhelést kap. Egy 35-40 fokos szögbe állított padon érdemes végezni a gyakorlatot, nagyobb dőlésszög esetén túl nagy szerepet kap az elülső deltaizom. Nyomd ki a kézisúlyzókat egyszerre, nyújtsd ki teljesen a karod, majd azonnal engedd vissza a súlyzókat a kiindulási helyzetbe.'),
(10, 'Mellhez húzás széles fogással', 2, 'A széles hátizmokat dolgoztatja meg elsősorban, de a bicepsz és az alkar is kap másodlagos terhelést. A cél az lenne, hogy ezt kiküszöböld. Húzd le a rudat a könyöködre koncentrálva - ez segít, hogy kikapcsold a bicepszed a munkából amennyire csak lehet.'),
(11, 'Felhúzás', 2, 'Másnéven deadlift. Az erőemelés harmadik gyakorlata. A guggolás mellett a leghatásosabb teljes testet megmozgató gyakorlat. Erősíti a fogást. A hát alsó és középső részének izomzatát, a csipő izmait, a combizmokat és a csuklyás izmot is stimulálja. Állj úgy, hogy lábszárcsont éppen érintse a súlyzót. Hajolj előre, és ragadd meg a rudat. Egyenesedj ki, természetesen használva lábad és hátad együttes erejét.'),
(12, 'Döntött törzsű evezés', 2, 'A széles hátizmokat dolgoztatja meg leginkább. Másodlagos hatással van a csuklyás izomra, a deltaizom hátsó felére. Állj vállszélességű terpeszbe, dőlj előre min. 45 fokos szögig. Térded legyen kissé behajlítva. Húzd fel a rudat a hasad/mellkas irányába úgy, hogy a könyöködre koncentrálsz a mozdulat ideje alatt. Ez fog segíteni, hogy kikapcsold a bicepszedet a mozgásból. Amikor a rúd megérinti a törzsedet engedd vissza a kiinduló pozícióba'),
(13, 'Kábeles evezés', 2, 'A hagyományos, szűk fogantyúval végezve a hátizom alsó részét dolgoztatja meg. A fogás szélességétől függően stimulálhatod a belső és külső részeket is. Rögzítsd a lábadat, majd húzd a fogantyút a tested középső része felé, vízszintes irányban. Maradj ebben a helyzetben két másodpercig, majd engedd vissza a karodat lassan amíg a hátizmok meg nem nyúlnak teljesen. A karok kinyúlásakor próbálj meg arra törekedni, hogy a hátizom is megnyúljon'),
(14, 'T-rudas evezés', 2, 'Egy kiváló gyakorlat a hátizom vastagságának növelésére. Fogd meg a fogantyút vagy a rudat és egyenesedj fel kb 45 fokos szögig. Húzd a hasadhoz a rudat/fogantyút, majd amikor a tárcsák megérintik a hasadat, engedd vissza a súlyokat. Leengedéskor az egész hátizomnak meg kell nyúlnia nem csak a karoknak.'),
(15, 'Fűrészelés', 2, 'A hát felső izmait de leginkább a széles hátizmokat dolgoztatja meg. Ezt a gyakorlatot lehet padon végezni, vagy bárhol ahol az egyik karoddal meg tudsz támaszkodni. Ha megtámaszkodtál ragadd meg a padlón lévő egykezes súlyzót, majd emeld a vállad magasságáig vagy még feljebb a hátizmaidat használva. Lassan engedd vissza a kézisúlyzót hadd nyúljon ki a hátizom.'),
(16, 'Vállból nyomás egykezes súlyzóval', 3, 'Elsősorban az első és az oldalsó deltaizmokat fejleszti. Egyenes háttal, emelt fejjel ülj a padon. A vállaid magasságánál kicsit feljebb tarts két kézisúlyzót. Nyomd ki a két súlyzót a fejed fölé egyszerre. Majd lassan kontrolláltan engedd vissza a kiinduló pozicíóig'),
(17, 'Oldalemelés ', 3, 'Az oldalsó deltaizmokat fejleszti leginkább. A gyakorlat végzése közben a könyökre kell koncentrálni. Emeld fel a két súlyzót vállmagasságig úgy mintha egy kancsóbol vizet öntenél ki. Majd engedd vissza lassan és kontrolláltan'),
(18, 'Mellről nyomás ülve', 3, 'Elsődleges terhelés az elülső delták számára, de az oldalsó delta is beleszól a mozgásba. Minél jobban kiforgatod a könyököd annál jobban terheled az oldalsó rostokat. Fogd meg a kétkezes rudat vállszélességben vagy kicsit szélesebben. Emeld ki majd engedd le a rudat fülmagasságig majd nyomd ki a fejed fölé.'),
(19, 'Arnold nyomás', 3, 'A deltaizom első és oldalsó fejét stimulálja. Fogj egy-egy súlyzót úgy hogy a súlyokat vállmagasságban az arcod előtt tartod. Tenyerek az arcod felé néznek. Emeld fel a súlyt a fejed fölé egyenes vonalban, miközben a tenyereidet kifelé fordítod. A súly a felső pozícióba úgy érkezik, hogy a tenyereid kifelé néznek. Ugyanezen az útvonalon engedd vissza a súlyt a kiinduló pozícióba.'),
(20, 'Állig húzás', 3, 'Erősíti a delta és a csuklyás izmot. Állj egyenesen szűk fogást felvéve. tenyerek a test felé. Lassan húzd a súlyzót felfelé tested közelében egy vonal mentén, könyöködet felfelé emelve és mindig a kezed vonala fölött tartva. Amint a rúd nyakmagasságba ér, tarts szünetet, és ereszd le a súlyzót lassan ugyanezen vonalon, egészen addig, míg a combodhoz ér.'),
(21, 'Előreemelés', 3, 'A deltaizom elülső rostjait hivatott megdolgoztatni. Álló helyzetben fogj a kezeidben egy pár kézisúlyzót. Egyik kezed emeld fel egyenesen magad előtt, amíg a súly magasabbra kerül a szemednél, majd miközben ezt a karodat leereszted, ezzel párhuzamosan emeld fel a másikat.'),
(22, 'Guggolás', 9, 'A guggolás egy olyan alapgyakorlat, ami megfelelően végrehajtva a teljes testet megedzi. Állj kiegyenesedve egy kétkezes súlyzó rúdját egyensúlyozva a nyakad mögött a hátadon keresztben. Tedd sarkaidat egymástól 30-50 cm-re úgy, hogy lábfejeid kissé kifelé mutassanak. Szemeddel nézz egy pontra magad elé, szemmagasságnál kicsit feljebb, és tartsd tekintetedet azon a ponton az egész mozgás során. Ezután lassan hajlítsd be térdedet, és ereszd le tested teljes guggolásba.'),
(23, 'Lábtolás', 9, 'Sok testépítő jobban kedveli ezt a gyakorlatot, mint a guggolást, mert lehetővé teszi, hogy teljes mértékben a láb mozgására összpontosítsanak, anélkül, hogy a csípő jelentősebb mértékben részt venne a mozdulatban. Helyezd a lábaidat egymástól mintegy harminc centiméterre a készülék taposólemeze alá. Nyomd ki a lábaidat, amíg a lábad ki nem egyenesedik, de a térdedet ne akaszd ki. Engedd vissza a súlyt, és ismételd a gyakorlatot.'),
(24, 'Lábnyújtás', 9, 'Legjobb izolációs gyakorlat a combizom igénybevételére. Ülj be a gépbe, hogy a térdhajlatod a pad emelőkar felőli oldalának végéhez illeszkedjen. A quadricepsz erejét használva, lassan egyenesítsd ki lábadat. Tartsd ki a csúcsösszehúzódást 1-2 másodpercig, majd lassan engedd vissza a lábadat.'),
(25, 'Lábhajlítás', 9, 'Ülj a gépbe, támaszd ki a hátadat és tartsd is a támlához szorítva végig a gyakorlat ideje alatt. Akaszd be sarkad a görgőpárnák alá, és nyújtsd ki teljesen a lábad. A láb kétfejű izmait használva hajlítsd be a lábadat, amennyire csak tudod. Tartsd ki ezt a leginkább összehúzott helyzetet 1-2 másodpercig, majd ereszkedj vissza a kiinduló pontig.'),
(26, 'Kitörés', 9, 'Ez a mozgás a combhajlítókat, a farizmokat és a négyfejű combizmot fejleszti. Állj egyenesen. Egy nagy lépést lépj előre, és kinyújtott lábaddal lassan süllyedj guggolásba. Amint leereszkedtél ebbe a helyzetbe, tégy egy újabb lépést előre a másik lábaddal, úgy, hogy közben kinyújtod az eddig behajlított lábadat, tehát fel-le ereszkedve lépegetsz előre.'),
(27, 'Hack guggolás', 9, 'Ez a gyakorlat a comb középső és alsó részét stimulálja, emellett a terpesz szélességével is tudod irányítani a stimuláció helyét. Guggolj le minimum addig, amíg a combod derékszöget nem zár be a lábszáraddal (de legjobb, ha teljesen leguggolsz), majd nyújtsd ki a lábadat, de figyelj rá, hogy a térdedet ne akasszad ki. A térd kiakasztásával, valamint az alsó ponton rugózással tudsz a legtöbbet ártani magadnak ennél a gyakorlatnál.'),
(28, 'Merevlábas felhúzás', 9, 'A gyakorlat kisebb súllyal helyesen végezve a comb-bicepszet és az alsó hátat erősíti.\r\nTarts a kezedben egy kétkezes rudat, nem túl nagy súllyal felpakolva. A térdedet mozdulatlanul tartva, mereven tartva hajolj előre, miközben a csípőd enyhén hátrafelé tolódik, hogy az egyensúlyodat meg tudd tartani. A súlynak nem szabad nagynak lennie, mert ez a gyakorlat fokozottan terheli a gerincet és az alsó hátat. Engedd a comb-bicepszet maximálisan kinyúlni, majd lassú de határozott mozdulattal emelkedj fel, a csípődet előre mozgatva.'),
(35, 'Bicepsz állva kétkezes rúddal', 4, 'A kétfejű karizmokat veszi igénybe. Állj egyenesen, vállszélességű fogással a kétkezes súlyzón, a tenyerek előre néznek. Csak alkart mozgatva hajlítsd be a karodat, és mozgasd a súlyzót felfelé, félkörívben az állad irányába.'),
(36, 'Bicepsz Scott padon', 4, 'Helyezkedj el a Scott-pad mögött kényelmesen. Mindkét karoddal egyszerre emeld fel a súlyt addig, míg az alkarod a bicepszedhez nem ér. Lassan engedd vissza a súlyokat, kihasználva a teljes mozgástartományt.'),
(37, 'Kalapács bicepsz', 4, 'A kalapács-bicepsz gyakorlat a bicepsz alatt futó brachialis izmot és az alkar izmait dolgoztatja meg. Ragadj meg mindkét kezedben egy-egy kézisúlyzót, és tartsd őket a tested mellett, a tenyereid nézzenek a tested irányába. A könyöködet egy helyben tartva, lassan és egyenletesen emeld az egyik súlyzót a válladhoz. Ereszd vissza, és a másik karral is ismételd a mozdulatot.'),
(38, 'Bicepsz ülve egykezes kézisúlyzóval', 4, 'A bicepsz edzés egykezes súlyzóval egy kiváló bicepszgyakorlat, amely igénybe veszi az alkar hajlítóizmait is. A bal kezedben lévő súlyt hajlítással emeld felfelé, a csuklódat közben úgy forgatva, hogy tenyered a mozgás második felében felfelé nézzen. Végezd ugyanezt a mozgást visszafelé a súlyt leeresztve a kiinduló helyzetbe.'),
(39, 'Csigás letolás', 5, 'Kiválóan képes hangsúlyozni a jellegzetes \"lópatkót\". Elsősorban izolációs gyakorlatként érdemes rá tekinteni. Nyomd le a rudat egészen addig, amíg a karjaid ki nem egyenesednek. Engedd vissza a súlyt, és ismételd meg a mozdulatot. A legtöbben e gyakorlat során a könyöküket szorosan az oldalukhoz szorítják, de néhányan viszont oldalt kinyomják és \"belehajolnak\" a mozdulatba. Fontos azonban, hogy a könyök mozdulatlan legyen'),
(40, 'Csigás letolás kötéllel', 5, 'A kötéllel végzett mozgás kisebb súly, ám nagyobb mozgástartomány használatát feltételezi. Emellett a gyakorlat végpontján sokkal jobban rá tudsz feszíteni a tricepszedre. A gyakorlatot kétféle módon végezheted: vagy a tested mellé húzod le a kötél két végét, vagy pedig az egész gyakorlatot a tested előtt végzed, kifelé megfeszítve a kötél végeit. Mindkét variáció másféle érzetet kelt a tricepszedben.'),
(41, 'Tricepsznyújtás fekve', 5, 'Mindhárom fej erős terhelést kap, de a legjobban a tricepsz hosszú feje (long head) dolgozik a gyakorlat közben. Felkarodat mozdulatlanul tartva, hajlítsd be könyöködet, és mozgasd a súlyzót félkörívben egészen addig, amíg a homlokodhoz nem ér, vagy a fejed felett túl nem megy a padon.'),
(42, 'Szűknyomás', 5, 'A szűknyomás elsődlegesen a mellizmokat, a deltaizom elülső fejét és a háromfejű karizmot veszi igénybe. Keskeny felső fogást alkalmazz. Hajlítsd be karodat, és lassan ereszd le a súlyzót egészen addig, amíg mellkasodat nem érinti. Nyomd lassan vissza a kiinduló pontra, és ismételd a mozgást az előírt számban.'),
(43, 'Lórugás', 5, 'A lórúgás csaknem kizárólag a háromfejű karizmot építi. Izolációs gyakorlat, segédizmok gyakorlatilag nem kapcsolódnak be a mozgásba. Így nagy súlyokkal nem is lehet, és nem is célszerű végezni. Előrehajolva támaszkodj egyik kezeddel egy pad végére és másik kezedben tarts egy egykezes súlyzót. A könyöködet tartsd magasan, de stabilan, és egyenesítsd ki alkarodat. Csak az alkaroddal végezd a mozgást.'),
(44, 'Felülés', 8, 'A felülés a teljes egyenes hasizmot, különösen az izomzat felső felét fejleszti. Feküdj le például egy bordásfal elé, akaszd be a lábadat. Végezz felülés, figyelve arra, hogy a hasizom erejét használod, nem pedig a csipő hajlítóizmait. A hátadat görbítsd be ennek érdekében. A mellkasodat közelítsd a térded felé. '),
(45, 'Hasprés', 8, 'A hasprés a hasizmok felső részét dolgozza meg, de jó technikával az egyenes hasizom egésze kellő terhelést kap. Feküdj hanyatt. A karodat fond össze a tested előtt, vagy kulcsold össze a fejed mögött. Lassan hajlítsd vállát a térded felé, annyira, hogy lapockáid 3-5 cm-re eltávolodjanak a padlótól. Tarts ki így egy másodpercig, majd ereszkedj vissza a kiinduló helyzetbe és ismételj.'),
(46, 'Lábkeresztezés fekve', 8, 'A lábkeresztezés fekve az egyenes hasizmokat, a ferde hasizmokat és a csípő izmait fejleszti. Feküdj háttal a padlóra egy olyan helyen, ahol a kezeddel megkapaszkodhatsz. A gyakorlat alatt a vállaiad tartsd a padlón. Miközben a jobb lábadat szorosan a padlón tartod, emeld a bal lábad enyhén fel, és a padlóval párhuzamosan húzd fel a jobb könyököd felé. A lábaid tartsd kinyújtva az egész gyakorlat alatt. A térdeidet ne hajlítsd be.'),
(47, 'Térdfelhúzás ülve', 8, 'A térdfelhúzás ülve igénybe veszi a teljes egyenes hasizmot, különösen az izomcsoport alsó harmadát. Ülj egy vízszintes pad végére, és hajtsd hátra törzsedet addig, amíg a paddal 45 fokos szöget nem zár be. Fogd meg a pad széleit, hogy felsőtestedet ebben a helyzetben rögzítsd. Nyújtsd ki lábadat lefelé addig, míg a padlóval körülbelül 45 fokos szöget nem zár be, felsőtested vonalának folytatásaként. Hasizmaid erejét használva húzd fel térdedet a mellkasodhoz, míg ezzel egy időben teljesen hajlítsd be lábad.'),
(48, 'Lábemelés', 8, 'Az alsó hasizmokat dolgoztatja meg, le, egészen az ágyékig. Nagyon fontos, hogy ne csak a lábunkat, térdünket emelgessük, hanem begörbítsük a csipőt is, mert a hasizom csak ebben az esetben tud összehúzótni. Lábaidat tartsd kinyújtva, és emeld azokat a padlóval párhuzamos helyzetnél magasabbra, majd engedd vissza és ismételd a mozdulatot.'),
(49, 'Kábeles hasprés', 8, 'A kábeles hasprés a hasizmokat és a fűrészizmokat dolgoztatja meg leginkább. Térdelj le egy felső csiga előtt, melyre egy tricepsz kötelet erősítesz. Fogd meg a kötelet úgy, hogy a végei a nyakad mellett vannak amikor előredőlsz. A hasizmod erejével görbítsd be a tested. Ezt akkor fogod tudni elérni, ha a hátad domború. A csípő legyen mozdulatlan, felsőtestből mozogj, a mellkasod előredöntésére koncentrálj.'),
(50, 'Álló vádligép', 7, 'Ez a gyakorlat a kétfejű lábikraizmot, azaz a vádlit, valamint a talpemelő izmot fejleszti. Áll a vádligépbe úgy, hogy csak a talppárnáidon támaszkodj. Emelkedj lábujjhegyre és ereszkedj vissza, anélkül, hogy nagyon behajlítanád a térdedet vagy visszarugóznál az alsó holtpontról.'),
(51, 'Ülő vádligép', 7, 'Ezt a gyakorlatot is egy speciális gépen kell végezni. A végzett mozdulat inkább a talpemelő izmot mozgatja meg. Ülj be a gépbe, a térdedet szorítsd be a támasz alá úgy, hogy a vádlid megnyújtott állapotban legyen. Akaszd ki a rögzítő kart. Emeld meg a vádlidat amennyire tudod, feszíts rá a felső ponton, majd lassan engedd vissza.'),
(52, 'Csuklóbehúzás', 6, 'Ez a gyakorlat erősen fejleszti az alkar izmait. Ülj le egy pad végére, alkarod a combodon legyen úgy, hogy a csuklód a térdeden túllógjon. Tenyereddel felfelé fogd meg a rudat. Csuklód hajlításával billentsd a súlyzót olyan magasra, amilyen magasra csak tudod. Térj vissza a kiinduló helyzetbe, majd ismételd a mozdulatot.'),
(53, 'Csuklófeszítés', 6, 'Végrehajtása során az alkar külső oldalán lévő feszítő izmok vannak igénybe véve. Ülj le egy pad végére, alkarod a combodon legyen úgy, hogy a csuklód a térdeden túllógjon. Tenyereddel lefelé fogd meg a rudat. Csuklód hajlításával billentsd a súlyzót olyan magasra, amilyen magasra csak tudod. Térj vissza a kiinduló helyzetbe, majd ismételd a mozdulatot.');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `izomcsoportok`
--

CREATE TABLE `izomcsoportok` (
  `izomcsoport_id` int(11) NOT NULL,
  `izomcsoport` varchar(20) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `izomcsoportok`
--

INSERT INTO `izomcsoportok` (`izomcsoport_id`, `izomcsoport`) VALUES
(1, 'Mell'),
(2, 'Hát'),
(3, 'Váll'),
(4, 'Bicepsz'),
(5, 'Tricepsz'),
(6, 'Alkar'),
(7, 'Vádli'),
(8, 'Has'),
(9, 'Láb');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `edzesek`
--
ALTER TABLE `edzesek`
  ADD PRIMARY KEY (`edzesek_id`),
  ADD KEY `edzesek_ibfk_1` (`f_id`),
  ADD KEY `edzesek_ibfk_2` (`edzesterv_id`);

--
-- A tábla indexei `edzestervek`
--
ALTER TABLE `edzestervek`
  ADD PRIMARY KEY (`edzesterv_id`),
  ADD KEY `edzestervek_ibfk_1` (`gyakorlat_id`);

--
-- A tábla indexei `etelek`
--
ALTER TABLE `etelek`
  ADD PRIMARY KEY (`etel_id`);

--
-- A tábla indexei `etkezesek`
--
ALTER TABLE `etkezesek`
  ADD PRIMARY KEY (`etkezesek_id`),
  ADD KEY `etkezesek_ibfk_1` (`etel_id`),
  ADD KEY `etkezesek_ibfk_2` (`f_id`);

--
-- A tábla indexei `felhasznalok`
--
ALTER TABLE `felhasznalok`
  ADD PRIMARY KEY (`f_id`);

--
-- A tábla indexei `gyakorlatok`
--
ALTER TABLE `gyakorlatok`
  ADD PRIMARY KEY (`gyakorlatok_id`),
  ADD KEY `gyakorlatok_ibfk_1` (`izomcsoport_id`);

--
-- A tábla indexei `izomcsoportok`
--
ALTER TABLE `izomcsoportok`
  ADD PRIMARY KEY (`izomcsoport_id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `edzesek`
--
ALTER TABLE `edzesek`
  MODIFY `edzesek_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=72;

--
-- AUTO_INCREMENT a táblához `edzestervek`
--
ALTER TABLE `edzestervek`
  MODIFY `edzesterv_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT a táblához `etelek`
--
ALTER TABLE `etelek`
  MODIFY `etel_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- AUTO_INCREMENT a táblához `etkezesek`
--
ALTER TABLE `etkezesek`
  MODIFY `etkezesek_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- AUTO_INCREMENT a táblához `felhasznalok`
--
ALTER TABLE `felhasznalok`
  MODIFY `f_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT a táblához `gyakorlatok`
--
ALTER TABLE `gyakorlatok`
  MODIFY `gyakorlatok_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- AUTO_INCREMENT a táblához `izomcsoportok`
--
ALTER TABLE `izomcsoportok`
  MODIFY `izomcsoport_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `edzesek`
--
ALTER TABLE `edzesek`
  ADD CONSTRAINT `edzesek_ibfk_1` FOREIGN KEY (`f_id`) REFERENCES `felhasznalok` (`f_id`),
  ADD CONSTRAINT `edzesek_ibfk_2` FOREIGN KEY (`edzesterv_id`) REFERENCES `edzestervek` (`edzesterv_id`);

--
-- Megkötések a táblához `edzestervek`
--
ALTER TABLE `edzestervek`
  ADD CONSTRAINT `edzestervek_ibfk_1` FOREIGN KEY (`gyakorlat_id`) REFERENCES `gyakorlatok` (`gyakorlatok_id`);

--
-- Megkötések a táblához `etkezesek`
--
ALTER TABLE `etkezesek`
  ADD CONSTRAINT `etkezesek_ibfk_1` FOREIGN KEY (`etel_id`) REFERENCES `etelek` (`etel_id`),
  ADD CONSTRAINT `etkezesek_ibfk_2` FOREIGN KEY (`f_id`) REFERENCES `felhasznalok` (`f_id`);

--
-- Megkötések a táblához `gyakorlatok`
--
ALTER TABLE `gyakorlatok`
  ADD CONSTRAINT `gyakorlatok_ibfk_1` FOREIGN KEY (`izomcsoport_id`) REFERENCES `izomcsoportok` (`izomcsoport_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
