-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2020. Jan 15. 19:48
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
-- Tábla szerkezet ehhez a táblához `bejelentkezes`
--

CREATE TABLE `bejelentkezes` (
  `id` int(11) NOT NULL,
  `fnev` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `jelszo` varchar(30) CHARACTER SET utf16 COLLATE utf16_hungarian_ci NOT NULL,
  `vendeg_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `edzesek`
--

CREATE TABLE `edzesek` (
  `id` int(11) NOT NULL,
  `vendeg_id` int(11) NOT NULL,
  `izomcsoport` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `gyakorlat_id` int(11) NOT NULL,
  `idopont` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `etelek`
--

CREATE TABLE `etelek` (
  `id` int(11) NOT NULL,
  `etel_nev` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `feherje` int(11) NOT NULL,
  `szenhidrat` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `etkezesek`
--

CREATE TABLE `etkezesek` (
  `id` int(11) NOT NULL,
  `vendeg_id` int(11) NOT NULL,
  `etel_id` int(11) NOT NULL,
  `mennyiseg` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `idopont` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `gyakorlatok`
--

CREATE TABLE `gyakorlatok` (
  `id` int(11) NOT NULL,
  `gyakorlat_nev` varchar(25) CHARACTER SET utf32 COLLATE utf32_hungarian_ci NOT NULL,
  `sorozatszam` varchar(25) CHARACTER SET utf32 COLLATE utf32_hungarian_ci NOT NULL,
  `ismetlesszam` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tkieg`
--

CREATE TABLE `tkieg` (
  `id` int(11) NOT NULL,
  `vendeg_id` int(11) NOT NULL,
  `tkieg_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tkiegek_adatai`
--

CREATE TABLE `tkiegek_adatai` (
  `id` int(11) NOT NULL,
  `nev` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `gyarto` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `tipus` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `izesites` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `kiszereles` int(11) NOT NULL,
  `mertekegyseg` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vendegek`
--

CREATE TABLE `vendegek` (
  `id` int(11) NOT NULL,
  `nev` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `email` varchar(25) COLLATE utf8_hungarian_ci NOT NULL,
  `tsuly` varchar(10) COLLATE utf8_hungarian_ci NOT NULL,
  `tmagassag` varchar(10) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `vendegek`
--

INSERT INTO `vendegek` (`id`, `nev`, `email`, `tsuly`, `tmagassag`) VALUES
(1, 'Rózsa István', '', '', '');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `bejelentkezes`
--
ALTER TABLE `bejelentkezes`
  ADD PRIMARY KEY (`id`),
  ADD KEY `vendeg_id` (`vendeg_id`);

--
-- A tábla indexei `edzesek`
--
ALTER TABLE `edzesek`
  ADD PRIMARY KEY (`id`),
  ADD KEY `vendeg_id` (`vendeg_id`),
  ADD KEY `gyakorlat_id` (`gyakorlat_id`);

--
-- A tábla indexei `etelek`
--
ALTER TABLE `etelek`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `etkezesek`
--
ALTER TABLE `etkezesek`
  ADD PRIMARY KEY (`id`),
  ADD KEY `vendeg_id` (`vendeg_id`),
  ADD KEY `etel_id` (`etel_id`);

--
-- A tábla indexei `gyakorlatok`
--
ALTER TABLE `gyakorlatok`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `tkieg`
--
ALTER TABLE `tkieg`
  ADD PRIMARY KEY (`id`),
  ADD KEY `vendeg_id` (`vendeg_id`),
  ADD KEY `tkieg_id` (`tkieg_id`);

--
-- A tábla indexei `tkiegek_adatai`
--
ALTER TABLE `tkiegek_adatai`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `vendegek`
--
ALTER TABLE `vendegek`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `bejelentkezes`
--
ALTER TABLE `bejelentkezes`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `edzesek`
--
ALTER TABLE `edzesek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `etelek`
--
ALTER TABLE `etelek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `etkezesek`
--
ALTER TABLE `etkezesek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `gyakorlatok`
--
ALTER TABLE `gyakorlatok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `tkieg`
--
ALTER TABLE `tkieg`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `tkiegek_adatai`
--
ALTER TABLE `tkiegek_adatai`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `vendegek`
--
ALTER TABLE `vendegek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `bejelentkezes`
--
ALTER TABLE `bejelentkezes`
  ADD CONSTRAINT `bejelentkezes_ibfk_1` FOREIGN KEY (`vendeg_id`) REFERENCES `vendegek` (`id`);

--
-- Megkötések a táblához `edzesek`
--
ALTER TABLE `edzesek`
  ADD CONSTRAINT `edzesek_ibfk_1` FOREIGN KEY (`vendeg_id`) REFERENCES `vendegek` (`id`),
  ADD CONSTRAINT `edzesek_ibfk_2` FOREIGN KEY (`gyakorlat_id`) REFERENCES `gyakorlatok` (`id`);

--
-- Megkötések a táblához `etkezesek`
--
ALTER TABLE `etkezesek`
  ADD CONSTRAINT `etkezesek_ibfk_1` FOREIGN KEY (`vendeg_id`) REFERENCES `vendegek` (`id`),
  ADD CONSTRAINT `etkezesek_ibfk_2` FOREIGN KEY (`etel_id`) REFERENCES `etelek` (`id`);

--
-- Megkötések a táblához `tkieg`
--
ALTER TABLE `tkieg`
  ADD CONSTRAINT `tkieg_ibfk_1` FOREIGN KEY (`vendeg_id`) REFERENCES `vendegek` (`id`),
  ADD CONSTRAINT `tkieg_ibfk_2` FOREIGN KEY (`tkieg_id`) REFERENCES `tkiegek_adatai` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
