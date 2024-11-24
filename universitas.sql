-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 24, 2024 at 07:51 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `universitas`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_kerja`
--

CREATE TABLE `tb_kerja` (
  `id_pekerjaan` int(5) NOT NULL,
  `jenis_pekerjaan` varchar(50) NOT NULL,
  `id_mahasiswa` int(5) NOT NULL,
  `jumlah_poin_req` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_kerja`
--

INSERT INTO `tb_kerja` (`id_pekerjaan`, `jenis_pekerjaan`, `id_mahasiswa`, `jumlah_poin_req`) VALUES
(7, 'Membersihkan Lingkungan', 8757, 20),
(8, 'Membersihkan Lingkungan', 4503, 20),
(9, 'Membersihkan Lingkungan', 9342, 28);

-- --------------------------------------------------------

--
-- Table structure for table `tb_mahasiswa`
--

CREATE TABLE `tb_mahasiswa` (
  `id_pengguna` int(5) NOT NULL,
  `no_regis` varchar(15) NOT NULL,
  `nim` varchar(15) NOT NULL,
  `nama_mahasiswa` text NOT NULL,
  `fakultas` varchar(30) NOT NULL,
  `prodi` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_mahasiswa`
--

INSERT INTO `tb_mahasiswa` (`id_pengguna`, `no_regis`, `nim`, `nama_mahasiswa`, `fakultas`, `prodi`, `password`) VALUES
(4503, 's22310267', '1050342425313', 'steve', 'Pertanian', 'Sistem Informasi', 'steve123'),
(4557, 's22310269', '10504252534124', 'jordan', 'Filsafat', 'Informatika', 'jordan123'),
(5692, 's22310269', '1050235234523', 'jack', 'Filsafat', 'Sekertaris', 'jack123'),
(6153, 's22310269', '105034245235', 'gren', 'Ekonomi dan Bisnis', 'Sekertaris', 'gren123'),
(8310, 's22310269', '105024523253', 'Dion', 'Ekonomi dan Bisnis', 'Akuntansi', 'dion123'),
(8757, 's22310268', '1050425242523', 'miranda', 'Filsafat', 'Sekertaris', 'mira123'),
(9182, 's22310265', '105024252135', 'cinta', 'Pertanian', 'Teknik Informasi', 'cinta'),
(9342, 's22310266', '105042352145', 'halo', 'Ekonomi dan Bisnis', 'Sekertaris', 'halo123'),
(9973, 's22310262', '1050241215325', 'vita', 'Ekonomi dan Bisnis', 'Pendidikan Bahasa Inggris', 'vita123');

-- --------------------------------------------------------

--
-- Table structure for table `tb_monitor`
--

CREATE TABLE `tb_monitor` (
  `id_monitor` int(5) NOT NULL,
  `no_regis` varchar(15) NOT NULL,
  `nim` varchar(15) NOT NULL,
  `nama_monitor` varchar(40) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_monitor`
--

INSERT INTO `tb_monitor` (`id_monitor`, `no_regis`, `nim`, `nama_monitor`, `password`) VALUES
(150, 's22310269', '105024524523', 'Adithia Gunawan', 'adit123'),
(4152, 's22310472', '1050245235234', 'Admin123', 'admin123'),
(5993, 's22310160', '1020304050', 'Dion Kobi', 'admin123'),
(18539, '1050223187', 'S22317699', 'Grantly Sorongan', 'grantlyganteng123');

-- --------------------------------------------------------

--
-- Table structure for table `tb_poin`
--

CREATE TABLE `tb_poin` (
  `id_poin` int(11) NOT NULL,
  `id_mahasiswa` int(5) NOT NULL,
  `jumlah_poin` int(4) NOT NULL,
  `poin_sisa` int(4) NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_poin`
--

INSERT INTO `tb_poin` (`id_poin`, `id_mahasiswa`, `jumlah_poin`, `poin_sisa`, `status`) VALUES
(112234, 8310, 0, 0, 'Ditolak'),
(112235, 6153, 100, 100, 'Ditolak'),
(112236, 4557, 0, 0, 'belum'),
(112237, 5692, 100, 100, 'belum'),
(112238, 8757, 0, 0, 'Menunggu'),
(112239, 4503, 0, 0, 'Menunggu'),
(112240, 9342, 0, 0, 'Menunggu'),
(112241, 9182, 0, 0, 'Berhasil'),
(112242, 9973, 100, 70, 'Berhasil');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_kerja`
--
ALTER TABLE `tb_kerja`
  ADD PRIMARY KEY (`id_pekerjaan`),
  ADD KEY `fk_tb_mahasiswa_tb_kerja` (`id_mahasiswa`);

--
-- Indexes for table `tb_mahasiswa`
--
ALTER TABLE `tb_mahasiswa`
  ADD PRIMARY KEY (`id_pengguna`) USING BTREE;

--
-- Indexes for table `tb_monitor`
--
ALTER TABLE `tb_monitor`
  ADD PRIMARY KEY (`id_monitor`);

--
-- Indexes for table `tb_poin`
--
ALTER TABLE `tb_poin`
  ADD PRIMARY KEY (`id_poin`),
  ADD KEY `fk_tb_mahasiswa_tb_poin` (`id_mahasiswa`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_kerja`
--
ALTER TABLE `tb_kerja`
  MODIFY `id_pekerjaan` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `tb_poin`
--
ALTER TABLE `tb_poin`
  MODIFY `id_poin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=112243;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_kerja`
--
ALTER TABLE `tb_kerja`
  ADD CONSTRAINT `fk_tb_mahasiswa_tb_kerja` FOREIGN KEY (`id_mahasiswa`) REFERENCES `tb_mahasiswa` (`id_pengguna`);

--
-- Constraints for table `tb_poin`
--
ALTER TABLE `tb_poin`
  ADD CONSTRAINT `fk_tb_mahasiswa_tb_poin` FOREIGN KEY (`id_mahasiswa`) REFERENCES `tb_mahasiswa` (`id_pengguna`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
