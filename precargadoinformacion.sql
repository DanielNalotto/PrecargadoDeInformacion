-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 20, 2023 at 03:45 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `precargadoinformacion`
--

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `tel` int(8) DEFAULT NULL,
  `mail` varchar(50) DEFAULT NULL,
  `calle` varchar(50) DEFAULT NULL,
  `nroPuerta` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`id`, `nombre`, `tel`, `mail`, `calle`, `nroPuerta`) VALUES
(1, 'Jamaico', 98765432, 'jamaico@gmail.com', 'Keteimporta', 1201),
(2, 'Robertina', 12345678, 'robertinaSquad@gmail.com', 'Sufriendopor conectaresto', 666),
(3, 'Bartolo', 12345678, 'asdfsa@vartoclo.csaom', 'Lorenzo peña', 123),
(5, 'Bob Esponja', 56842319, 'pantalones_cuadrados@krustaseokaskarudo.com', 'Piña colada debajo del mar', 1012),
(6, 'Jose Roberto', 89651453, 'jose.robert@gmail.com', '18 de Julio', 1408),
(7, 'Marko Hetalia', 12345678, 'the_islander@gmail.com', 'Nitwish', 12),
(8, 'Ty', 45678920, 'ty_1992@gmail.com', 'Infierno profundo', 106),
(9, 'Blass', 98125463, 'blassrael_friki@hotmail.com', 'Calle otako', 606),
(10, 'Sonya Blade', 59642134, 'sonya.blade@gmail.com', 'Noes favorita denadie', 992),
(13, 'Jotaro', 12130904, 'kujo@jojoreferencias.com', 'Star platinum', 18);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `nombre` (`nombre`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
