-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2019. Dec 13. 10:22
-- Kiszolgáló verziója: 10.1.34-MariaDB
-- PHP verzió: 7.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `csarp`
--
CREATE DATABASE IF NOT EXISTS `csarp` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `csarp`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `pfutar`
--

CREATE TABLE `pfutar` (
  `fazon` int(3) NOT NULL DEFAULT '0',
  `fnev` varchar(15) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `ftel` varchar(15) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `pfutar`
--

INSERT INTO `pfutar` (`fazon`, `fnev`, `ftel`) VALUES
(1, 'István', '+36705468974'),
(2, 'Anna', '+36202368874'),
(3, 'Éva', '+36705468974'),
(4, 'Ildikó', '+36305423974'),
(5, 'József', '+36702108974');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ppizza`
--

CREATE TABLE `ppizza` (
  `pazon` int(3) NOT NULL DEFAULT '0',
  `pnev` varchar(15) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `par` int(4) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `ppizza`
--

INSERT INTO `ppizza` (`pazon`, `pnev`, `par`) VALUES
(1, 'Capricciosa', 900),
(2, 'Frutti di Mare', 1100),
(3, 'Hawaii', 780),
(4, 'Vesuvio', 890),
(5, 'Sorrento', 990);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `prendeles`
--

CREATE TABLE `prendeles` (
  `razon` int(8) NOT NULL DEFAULT '0',
  `vazon` int(6) NOT NULL DEFAULT '0',
  `fazon` int(3) NOT NULL DEFAULT '0',
  `datum` date NOT NULL DEFAULT '2017-01-01',
  `ido` float NOT NULL DEFAULT '0',
  `teljesites` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

--
-- A tábla adatainak kiíratása `prendeles`
--

INSERT INTO `prendeles` (`razon`, `vazon`, `fazon`, `datum`, `ido`, `teljesites`) VALUES
(1, 4, 2, '2010-10-01', 13.15, 1),
(2, 7, 2, '2010-10-01', 14.17, 0),
(3, 1, 1, '2010-10-02', 11.07, 0),
(4, 5, 2, '2010-10-02', 14.55, 0),
(5, 2, 3, '2010-10-02', 15.27, 0),
(6, 4, 2, '2010-10-03', 15.58, 0),
(7, 6, 2, '2010-10-04', 11.44, 0),
(8, 7, 4, '2010-10-04', 12.11, 0),
(9, 1, 5, '2010-10-04', 14.33, 0),
(10, 3, 5, '2010-10-04', 18.04, 0),
(11, 2, 1, '2010-10-05', 16.38, 0),
(12, 5, 2, '2010-10-05', 17.02, 0),
(13, 6, 2, '2010-10-06', 12.17, 0),
(14, 4, 3, '2010-10-06', 13.21, 0),
(15, 1, 4, '2010-10-06', 15.05, 0),
(16, 2, 5, '2010-10-06', 15.59, 0),
(17, 7, 2, '2010-10-06', 18.44, 0),
(18, 3, 2, '2010-10-07', 12.01, 0),
(19, 4, 5, '2010-10-07', 13.44, 0),
(20, 1, 1, '2010-10-07', 17.25, 0),
(21, 5, 3, '2010-10-08', 14.29, 0);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ptetel`
--

CREATE TABLE `ptetel` (
  `razon` int(8) NOT NULL DEFAULT '0',
  `pazon` int(3) NOT NULL DEFAULT '0',
  `db` int(3) NOT NULL DEFAULT '0'
) ENGINE=MyISAM DEFAULT CHARSET=latin2 COLLATE=latin2_hungarian_ci;

--
-- A tábla adatainak kiíratása `ptetel`
--

INSERT INTO `ptetel` (`razon`, `pazon`, `db`) VALUES
(1, 1, 2),
(1, 4, 3),
(2, 2, 1),
(3, 1, 2),
(4, 1, 1),
(4, 4, 1),
(5, 2, 4),
(6, 1, 1),
(6, 4, 1),
(6, 5, 1),
(7, 5, 5),
(8, 4, 3),
(9, 2, 1),
(10, 1, 1),
(10, 4, 1),
(11, 1, 1),
(12, 2, 2),
(12, 4, 2),
(13, 4, 1),
(13, 5, 1),
(13, 2, 1),
(14, 2, 2),
(15, 1, 1),
(16, 2, 1),
(16, 4, 1),
(16, 5, 1),
(17, 1, 2),
(17, 2, 3),
(18, 1, 4),
(18, 5, 1),
(19, 1, 1),
(19, 2, 1),
(19, 4, 1),
(19, 5, 1),
(20, 5, 3),
(21, 2, 2),
(21, 4, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `pvevo`
--

CREATE TABLE `pvevo` (
  `vazon` int(3) NOT NULL DEFAULT '0',
  `vnev` varchar(30) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT '',
  `vcim` varchar(30) CHARACTER SET latin2 COLLATE latin2_hungarian_ci NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `pvevo`
--

INSERT INTO `pvevo` (`vazon`, `vnev`, `vcim`) VALUES
(1, 'Hapci', 'Szeged'),
(2, 'Vidor', 'Hódmezovásárhely'),
(3, 'Tudor', 'Sándorfalva'),
(4, 'Vesuvio', 'Szatymaz'),
(5, 'Sorrento', 'Debrecen');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `pfutar`
--
ALTER TABLE `pfutar`
  ADD PRIMARY KEY (`fazon`);

--
-- A tábla indexei `ppizza`
--
ALTER TABLE `ppizza`
  ADD PRIMARY KEY (`pazon`);

--
-- A tábla indexei `prendeles`
--
ALTER TABLE `prendeles`
  ADD PRIMARY KEY (`razon`);

--
-- A tábla indexei `pvevo`
--
ALTER TABLE `pvevo`
  ADD PRIMARY KEY (`vazon`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
