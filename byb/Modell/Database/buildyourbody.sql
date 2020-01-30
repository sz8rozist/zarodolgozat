-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Jan 30. 16:08
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
  `izomcsoport_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `edzesterv`
--

CREATE TABLE `edzesterv` (
  `edzesterv_id` int(11) NOT NULL,
  `gyakorlatok_id` int(11) NOT NULL,
  `edzesek_id` int(11) NOT NULL
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

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `gyakorlatok`
--

CREATE TABLE `gyakorlatok` (
  `gyakorlatok_id` int(11) NOT NULL,
  `gynev` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `sorozatszam` int(11) NOT NULL,
  `ismetlesszam` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `izomcsoportok`
--

CREATE TABLE `izomcsoportok` (
  `izomcsoport_id` int(11) NOT NULL,
  `izomcsoport` varchar(20) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

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
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `edzesek`
--
ALTER TABLE `edzesek`
  ADD PRIMARY KEY (`edzesek_id`),
  ADD KEY `f_id` (`f_id`),
  ADD KEY `izomcsoport_id` (`izomcsoport_id`);

--
-- A tábla indexei `edzesterv`
--
ALTER TABLE `edzesterv`
  ADD PRIMARY KEY (`edzesterv_id`),
  ADD KEY `edzesek_id` (`edzesek_id`),
  ADD KEY `gyakorlatok_id` (`gyakorlatok_id`);

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
  ADD KEY `etel_id` (`etel_id`),
  ADD KEY `f_id` (`f_id`);

--
-- A tábla indexei `felhasznalok`
--
ALTER TABLE `felhasznalok`
  ADD PRIMARY KEY (`f_id`);

--
-- A tábla indexei `gyakorlatok`
--
ALTER TABLE `gyakorlatok`
  ADD PRIMARY KEY (`gyakorlatok_id`);

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
  ADD KEY `f_id` (`f_id`),
  ADD KEY `k_id` (`k_id`);

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
-- AUTO_INCREMENT a táblához `edzesterv`
--
ALTER TABLE `edzesterv`
  MODIFY `edzesterv_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `etelek`
--
ALTER TABLE `etelek`
  MODIFY `etel_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `etkezesek`
--
ALTER TABLE `etkezesek`
  MODIFY `etkezesek_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `felhasznalok`
--
ALTER TABLE `felhasznalok`
  MODIFY `f_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `gyakorlatok`
--
ALTER TABLE `gyakorlatok`
  MODIFY `gyakorlatok_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `izomcsoportok`
--
ALTER TABLE `izomcsoportok`
  MODIFY `izomcsoport_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `kiegeszitok`
--
ALTER TABLE `kiegeszitok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `kiegeszitok_adatai`
--
ALTER TABLE `kiegeszitok_adatai`
  MODIFY `k_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `edzesek`
--
ALTER TABLE `edzesek`
  ADD CONSTRAINT `edzesek_ibfk_1` FOREIGN KEY (`f_id`) REFERENCES `felhasznalok` (`f_id`),
  ADD CONSTRAINT `edzesek_ibfk_2` FOREIGN KEY (`izomcsoport_id`) REFERENCES `izomcsoportok` (`izomcsoport_id`);

--
-- Megkötések a táblához `edzesterv`
--
ALTER TABLE `edzesterv`
  ADD CONSTRAINT `edzesterv_ibfk_1` FOREIGN KEY (`edzesek_id`) REFERENCES `edzesek` (`edzesek_id`),
  ADD CONSTRAINT `edzesterv_ibfk_2` FOREIGN KEY (`gyakorlatok_id`) REFERENCES `gyakorlatok` (`gyakorlatok_id`);

--
-- Megkötések a táblához `etkezesek`
--
ALTER TABLE `etkezesek`
  ADD CONSTRAINT `etkezesek_ibfk_1` FOREIGN KEY (`etel_id`) REFERENCES `etelek` (`etel_id`),
  ADD CONSTRAINT `etkezesek_ibfk_2` FOREIGN KEY (`f_id`) REFERENCES `felhasznalok` (`f_id`);

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
