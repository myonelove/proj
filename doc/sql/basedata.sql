/*
SQLyog Ultimate v12.08 (64 bit)
MySQL - 8.0.17 : Database - basedata
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`basedata` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `basedata`;

/*Table structure for table `goods` */

DROP TABLE IF EXISTS `goods`;

CREATE TABLE `goods` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `no` varchar(32) DEFAULT NULL COMMENT '货品编号',
  `good_name` varchar(256) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '货品名称',
  `input_time` datetime DEFAULT CURRENT_TIMESTAMP COMMENT '录入时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='货品资料';

/*Data for the table `goods` */

/*Table structure for table `staff` */

DROP TABLE IF EXISTS `staff`;

CREATE TABLE `staff` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `no` varchar(32) DEFAULT NULL COMMENT '员工编号',
  `name` varchar(20) DEFAULT NULL COMMENT '员工名称',
  `lead_no` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0' COMMENT '领导编号，默认0=未分配领导',
  `mobile` varchar(20) DEFAULT NULL COMMENT '员工联系电话',
  `email` varchar(50) DEFAULT NULL COMMENT '员工联系email',
  `hiredate` datetime DEFAULT CURRENT_TIMESTAMP COMMENT '入职时间',
  `is_dimission` tinyint(1) DEFAULT '0' COMMENT '是否离职',
  `departure_time` datetime DEFAULT NULL COMMENT '离职时间',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='员工信息';

/*Data for the table `staff` */

insert  into `staff`(`Id`,`no`,`name`,`lead_no`,`mobile`,`email`,`hiredate`,`is_dimission`,`departure_time`) values (1,'6368399d36fc42bb94624732aa689ec0','mengfengli','','18681081080','855525656@qq.com','2019-10-21 04:18:51',0,NULL),(2,'117e1f96ae844a40a4a4366ac17d015c','liuqiong','','18681081022','434536433@qq.com','2019-10-21 04:25:11',0,NULL),(3,'3a424576f42611e9b40c005056c00001','林三','','18681081033','2874923700@qq.com','2019-10-22 01:21:34',NULL,NULL);

/*Table structure for table `supplier` */

DROP TABLE IF EXISTS `supplier`;

CREATE TABLE `supplier` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `no` varchar(32) DEFAULT NULL COMMENT '供应商编号',
  `supplier_name` varchar(100) DEFAULT NULL COMMENT '供应商名称',
  `mobile` varchar(20) DEFAULT NULL COMMENT '供应商联系点好',
  `contact` varchar(50) DEFAULT NULL COMMENT '供应商联主要系人',
  `address` varchar(200) DEFAULT NULL COMMENT '供应商地址',
  `category` int(11) DEFAULT '0' COMMENT '供应商类型，0=未分类',
  `join_us_time` datetime DEFAULT NULL COMMENT '开始合作时间',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='供应商资料';

/*Data for the table `supplier` */

/*Table structure for table `supplier_category` */

DROP TABLE IF EXISTS `supplier_category`;

CREATE TABLE `supplier_category` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `category_name` varchar(50) DEFAULT NULL COMMENT '供应商分类',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='供应商分类';

/*Data for the table `supplier_category` */

/*Table structure for table `unit` */

DROP TABLE IF EXISTS `unit`;

CREATE TABLE `unit` (
  `Id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'key',
  `unit_key` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '单位键',
  `unit_name` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '单位名称',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='往来单位资料';

/*Data for the table `unit` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
