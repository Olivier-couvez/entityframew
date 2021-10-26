-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 26 oct. 2021 à 10:32
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `formations`
--

-- --------------------------------------------------------

--
-- Structure de la table `formation`
--

DROP TABLE IF EXISTS `formation`;
CREATE TABLE IF NOT EXISTS `formation` (
  `idFormation` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(45) COLLATE utf16_unicode_ci NOT NULL,
  `niveau` varchar(45) COLLATE utf16_unicode_ci NOT NULL,
  `nbStagiaire` int(11) NOT NULL,
  PRIMARY KEY (`idFormation`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf16 COLLATE=utf16_unicode_ci;

--
-- Déchargement des données de la table `formation`
--

INSERT INTO `formation` (`idFormation`, `nom`, `niveau`, `nbStagiaire`) VALUES
(1, 'TPCDA', '6', 12),
(2, 'TPWEB', '5', 12),
(3, 'TPSSR', '5', 11),
(4, 'TPLUI', '8', 15);

-- --------------------------------------------------------

--
-- Structure de la table `stagiaire`
--

DROP TABLE IF EXISTS `stagiaire`;
CREATE TABLE IF NOT EXISTS `stagiaire` (
  `idStagiaire` int(11) NOT NULL AUTO_INCREMENT,
  `nom` varchar(45) COLLATE utf16_unicode_ci NOT NULL,
  `prenom` varchar(45) COLLATE utf16_unicode_ci NOT NULL,
  `age` int(11) NOT NULL,
  `idFormation` int(11) NOT NULL,
  PRIMARY KEY (`idStagiaire`),
  KEY `idformation` (`idFormation`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf16 COLLATE=utf16_unicode_ci;

--
-- Déchargement des données de la table `stagiaire`
--

INSERT INTO `stagiaire` (`idStagiaire`, `nom`, `prenom`, `age`, `idFormation`) VALUES
(1, 'Stagiaire1', 'prenom1', 23, 1),
(2, 'Stagiaire2', 'prenom2', 45, 2),
(3, 'Stagiaire3', 'prenom3', 32, 1),
(4, 'Stagiaire4', 'prenom4', 25, 2),
(5, 'Stagiaire5', 'prenom5', 31, 3),
(6, 'Stagiaire6', 'prenom6', 57, 3);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `stagiaire`
--
ALTER TABLE `stagiaire`
  ADD CONSTRAINT `stagiaire_ibfk_1` FOREIGN KEY (`idFormation`) REFERENCES `formation` (`idFormation`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
