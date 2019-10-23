/*
SQLyog Ultimate v12.08 (64 bit)
MySQL - 8.0.17 : Database - purchasing
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`purchasing` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `purchasing`;

/*Table structure for table `procurement_order` */

DROP TABLE IF EXISTS `procurement_order`;

CREATE TABLE `procurement_order` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `order_no` varchar(32) DEFAULT NULL COMMENT '采购单单号',
  `supplier_id` int(11) DEFAULT NULL COMMENT '商品的供应商id',
  `unit_key` int(11) DEFAULT NULL COMMENT '采购的商品的单位id',
  `unit_name` varchar(64) DEFAULT NULL COMMENT '商品单位描述',
  `operator_staff` int(11) DEFAULT NULL COMMENT '最近的操作人id',
  `create_time` datetime DEFAULT NULL COMMENT '入库时间',
  `modify_time` datetime DEFAULT NULL COMMENT '最后一次更正时间',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='采购订单';

/*Data for the table `procurement_order` */

/*Table structure for table `procurement_order_detail` */

DROP TABLE IF EXISTS `procurement_order_detail`;

CREATE TABLE `procurement_order_detail` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `order_no` varchar(32) DEFAULT NULL COMMENT '采购单明细',
  `goods_id` int(11) DEFAULT NULL COMMENT '采购的商品',
  `qty` int(11) DEFAULT NULL COMMENT '采购的数量',
  `price` decimal(10,0) DEFAULT NULL COMMENT '采购的商品单价',
  `unit_key` int(11) DEFAULT NULL COMMENT '采购的商品的单位id',
  `unit_name` varchar(64) DEFAULT NULL COMMENT '商品单位描述',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `procurement_order_detail` */

/*Table structure for table `procurement_plan` */

DROP TABLE IF EXISTS `procurement_plan`;

CREATE TABLE `procurement_plan` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `supplier_id` int(11) DEFAULT NULL COMMENT '供应商编号',
  `good_id` int(11) DEFAULT NULL COMMENT '商品资料Id',
  `qty` int(11) DEFAULT NULL COMMENT '计划采购产品数量',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='采购计划/选购';

/*Data for the table `procurement_plan` */

/*Table structure for table `receiving` */

DROP TABLE IF EXISTS `receiving`;

CREATE TABLE `receiving` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `order_no` varchar(32) DEFAULT NULL COMMENT '采购收料单号',
  `procurement_order_no` varchar(32) DEFAULT NULL COMMENT '采购单id',
  `operator_staff` int(11) DEFAULT NULL COMMENT '收料操作人',
  `create_time` datetime DEFAULT NULL COMMENT '收料时间',
  `status` int(11) DEFAULT NULL COMMENT '收料状态，0=正常，1=有异常，可能退货',
  `remark` varchar(500) DEFAULT NULL COMMENT '收料异常说明/备注',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='采购收料';

/*Data for the table `receiving` */

/*Table structure for table `storage_inspection` */

DROP TABLE IF EXISTS `storage_inspection`;

CREATE TABLE `storage_inspection` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `order_no` varchar(32) DEFAULT NULL COMMENT '验收入库单号',
  `receiving_no` varchar(32) DEFAULT NULL COMMENT '采购收料单号',
  `operator_staff` int(11) DEFAULT NULL COMMENT '验收操作人',
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP COMMENT '记录时间',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='验收入库';

/*Data for the table `storage_inspection` */

/*Table structure for table `stores_returned` */

DROP TABLE IF EXISTS `stores_returned`;

CREATE TABLE `stores_returned` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `order_no` varchar(32) DEFAULT NULL COMMENT '采购退料单号',
  `cause_category` int(11) DEFAULT NULL COMMENT '退料状态，0=验收入库异常，1=采购收料异常',
  `operator_staff` int(11) DEFAULT NULL COMMENT '退料操作人',
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP COMMENT '退料时间',
  `cancel` tinyint(1) DEFAULT '0' COMMENT '是否撤销，0=否，1=撤销退料',
  `modify_time` datetime DEFAULT NULL COMMENT '最后一次操作时间',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='采购退料';

/*Data for the table `stores_returned` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
