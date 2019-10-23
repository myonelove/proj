/*
SQLyog Ultimate v12.08 (64 bit)
MySQL - 8.0.17 : Database - bumblebee
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`bumblebee` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `bumblebee`;

/*Table structure for table `_gateway_log` */

DROP TABLE IF EXISTS `_gateway_log`;

CREATE TABLE `_gateway_log` (
  `ID` varchar(50) NOT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `RemoteIP` varchar(45) DEFAULT NULL,
  `Method` varchar(10) DEFAULT NULL,
  `Path` varchar(45) DEFAULT NULL,
  `Url` varchar(1024) DEFAULT NULL,
  `Server` varchar(45) DEFAULT NULL,
  `Code` int(11) DEFAULT NULL,
  `ProcessTime` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Table structure for table `_users` */

DROP TABLE IF EXISTS `_users`;

CREATE TABLE `_users` (
  `_name` varchar(50) NOT NULL,
  `_password` varchar(45) DEFAULT NULL,
  `_role` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `_users` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
