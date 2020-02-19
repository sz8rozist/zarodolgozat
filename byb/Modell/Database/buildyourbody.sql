-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Feb 19. 17:08
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
  `idopont` datetime NOT NULL,
  `f_id` int(11) NOT NULL,
  `edzesterv_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

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

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `etelek`
--

CREATE TABLE `etelek` (
  `etel_id` int(11) NOT NULL,
  `enev` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `kaloria` int(11) NOT NULL,
  `feherje` int(11) NOT NULL,
  `szenhidrat` int(11) NOT NULL,
  `zsir` int(11) NOT NULL,
  `mennyiseg` varchar(20) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `etelek`
--

INSERT INTO `etelek` (`etel_id`, `enev`, `kaloria`, `feherje`, `szenhidrat`, `zsir`, `mennyiseg`) VALUES
(1, 'Csirkemell', 0, 24, 2, 2, '100gr'),
(2, 'Rizs', 0, 1, 50, 22, '70gr'),
(3, 'Pulykamell', 0, 24, 2, 23, '10gr'),
(4, 'Tilápia', 0, 30, 2, 2, '87gr'),
(5, 'Bélszín', 0, 35, 10, 6, '132gr'),
(6, 'Iso Whey Zero', 0, 20, 0, 0, '34gr'),
(7, 'Bulgur', 0, 24, 2, 2, '322gr'),
(8, 'Paradicsom', 0, 24, 2, 2, '32gr'),
(9, 'Édesburgonya', 0, 24, 2, 2, '60gr'),
(10, 'Avokádó', 0, 24, 2, 2, '90gr');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `etkezesek`
--

CREATE TABLE `etkezesek` (
  `etkezesek_id` int(11) NOT NULL,
  `idopont` datetime NOT NULL,
  `etel_id` int(11) NOT NULL,
  `f_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

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
(4, 'Adam', '12345', 'Rózsa István', 'ristvan98@gmail.com', 110, 194),
(5, 'g8szatam', '12345', 'Rózsa István', 'ristvan98@gmail.com', 110, 196);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `gyakorlatok`
--

CREATE TABLE `gyakorlatok` (
  `gyakorlatok_id` int(11) NOT NULL,
  `gynev` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `izomcsoport_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

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

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kiegeszitok`
--

CREATE TABLE `kiegeszitok` (
  `id` int(11) NOT NULL,
  `k_id` int(11) NOT NULL,
  `f_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kiegeszitok_adatai`
--

CREATE TABLE `kiegeszitok_adatai` (
  `k_id` int(11) NOT NULL,
  `knev` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `tipus` varchar(20) CHARACTER SET utf32 COLLATE utf32_hungarian_ci NOT NULL,
  `gyarto` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `kiszereles` int(11) NOT NULL,
  `ks_mertekegyseg` varchar(5) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `kiegeszitok_adatai`
--

INSERT INTO `kiegeszitok_adatai` (`k_id`, `knev`, `tipus`, `gyarto`, `kiszereles`, `ks_mertekegyseg`) VALUES
(1, 'Iso Whey Zero', 'Fehérje', 'Biotech Usa', 0, ''),
(2, '100% Whey', 'Fehérje', 'Scitec Nutrition', 0, ''),
(3, 'Bcaa Flash Zero', 'Aminosav', 'Biotech Usa', 0, ''),
(4, 'True Whey', 'Fehérje', 'Gym Beam', 0, ''),
(5, 'Wianabol', 'Tesztoszteron Serken', 'Biotech Usa', 0, ''),
(6, 'Anabolic Whey', 'Fehérje', 'Scitec Nutrition', 0, ''),
(7, 'Mega Daily One', 'Multivitamin', 'Scitec Nutrition', 0, ''),
(8, 'Multipro', 'Multivitamin', 'Scitec Nutrition', 0, ''),
(9, 'Beef Isolate', 'Fehérje', 'Biotech Usa', 0, '');

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
-- A tábla indexei `kiegeszitok`
--
ALTER TABLE `kiegeszitok`
  ADD PRIMARY KEY (`id`),
  ADD KEY `kiegeszitok_ibfk_1` (`f_id`),
  ADD KEY `kiegeszitok_ibfk_2` (`k_id`);

--
-- A tábla indexei `kiegeszitok_adatai`
--
ALTER TABLE `kiegeszitok_adatai`
  ADD PRIMARY KEY (`k_id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `edzesek`
--
ALTER TABLE `edzesek`
  MODIFY `edzesek_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `edzestervek`
--
ALTER TABLE `edzestervek`
  MODIFY `edzesterv_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `etelek`
--
ALTER TABLE `etelek`
  MODIFY `etel_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT a táblához `etkezesek`
--
ALTER TABLE `etkezesek`
  MODIFY `etkezesek_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `felhasznalok`
--
ALTER TABLE `felhasznalok`
  MODIFY `f_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT a táblához `gyakorlatok`
--
ALTER TABLE `gyakorlatok`
  MODIFY `gyakorlatok_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `izomcsoportok`
--
ALTER TABLE `izomcsoportok`
  MODIFY `izomcsoport_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT a táblához `kiegeszitok`
--
ALTER TABLE `kiegeszitok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `kiegeszitok_adatai`
--
ALTER TABLE `kiegeszitok_adatai`
  MODIFY `k_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

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

--
-- Megkötések a táblához `kiegeszitok`
--
ALTER TABLE `kiegeszitok`
  ADD CONSTRAINT `kiegeszitok_ibfk_1` FOREIGN KEY (`f_id`) REFERENCES `felhasznalok` (`f_id`),
  ADD CONSTRAINT `kiegeszitok_ibfk_2` FOREIGN KEY (`k_id`) REFERENCES `kiegeszitok_adatai` (`k_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
