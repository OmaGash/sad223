-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: record system
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tblinfo`
--

DROP TABLE IF EXISTS `tblinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblinfo` (
  `year` year NOT NULL,
  `date` datetime NOT NULL,
  `customerid` int NOT NULL AUTO_INCREMENT,
  `surname` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) NOT NULL,
  `number` int NOT NULL,
  `address` varchar(50) NOT NULL,
  `birthday` datetime NOT NULL,
  `birthplace` varchar(50) NOT NULL,
  `sex` varchar(15) NOT NULL,
  `nationality` varchar(20) NOT NULL,
  `civilstatus` varchar(15) NOT NULL,
  `occupation` varchar(30) NOT NULL,
  `course` varchar(20) NOT NULL,
  PRIMARY KEY (`customerid`),
  KEY `customerid` (`customerid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblinfo`
--

LOCK TABLES `tblinfo` WRITE;
/*!40000 ALTER TABLE `tblinfo` DISABLE KEYS */;
INSERT INTO `tblinfo` VALUES (2020,'2020-03-19 16:08:22',1,'uson','catherine mae','castalone',11111,'pampanga','1999-07-11 16:09:09','laguna','female','filipino','single','student','toefls'),(2020,'2020-03-10 16:16:58',2,'gutierrez','michelle','david',12223,'pampanga','2000-02-11 16:22:07','pampanga','female','filipino','single','student','toefls');
/*!40000 ALTER TABLE `tblinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbllog`
--

DROP TABLE IF EXISTS `tbllog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbllog` (
  `id` int NOT NULL AUTO_INCREMENT,
  `uname` varchar(15) NOT NULL,
  `pword` varchar(15) NOT NULL,
  `alevel` varchar(15) NOT NULL,
  `fname` varchar(15) NOT NULL,
  `lname` varchar(15) NOT NULL,
  PRIMARY KEY (`uname`),
  KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbllog`
--

LOCK TABLES `tbllog` WRITE;
/*!40000 ALTER TABLE `tbllog` DISABLE KEYS */;
INSERT INTO `tbllog` VALUES (1,'admin','admin','1','cath','uson'),(3,'chosen','one','1','Null','Void'),(2,'secretary','user','2','rashley','baloyo');
/*!40000 ALTER TABLE `tbllog` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblreceipt`
--

DROP TABLE IF EXISTS `tblreceipt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblreceipt` (
  `year` year NOT NULL,
  `date` datetime NOT NULL,
  `customerid` int NOT NULL AUTO_INCREMENT,
  `payment` varchar(20) NOT NULL,
  `cash` varchar(20) NOT NULL,
  `balance` varchar(20) NOT NULL,
  `remarks` varchar(20) NOT NULL,
  `receipt` varchar(20) NOT NULL,
  PRIMARY KEY (`customerid`),
  KEY `customerid` (`customerid`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblreceipt`
--

LOCK TABLES `tblreceipt` WRITE;
/*!40000 ALTER TABLE `tblreceipt` DISABLE KEYS */;
INSERT INTO `tblreceipt` VALUES (2020,'2020-03-19 16:52:17',1,'fullpayment','10000','0','fullypaid','1010921'),(2020,'2020-03-11 17:05:53',2,'downpayment','10000','5000','unpaid','1010123');
/*!40000 ALTER TABLE `tblreceipt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tblrecord`
--

DROP TABLE IF EXISTS `tblrecord`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tblrecord` (
  `customerid` int NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `surname` varchar(20) NOT NULL,
  `firstname` varchar(20) NOT NULL,
  `middlename` varchar(20) NOT NULL,
  `contact` tinytext NOT NULL,
  `address` varchar(50) NOT NULL,
  `birthdate` date NOT NULL,
  `birthplace` varchar(20) NOT NULL,
  `sex` varchar(10) NOT NULL,
  `nationality` varchar(20) NOT NULL,
  `status` varchar(20) NOT NULL,
  `occupation` varchar(20) NOT NULL,
  `course` varchar(20) NOT NULL,
  `cash` double NOT NULL,
  `balance` double NOT NULL,
  `remarks` varchar(20) DEFAULT '',
  PRIMARY KEY (`customerid`)
) ENGINE=InnoDB AUTO_INCREMENT=123456790 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblrecord`
--

LOCK TABLES `tblrecord` WRITE;
/*!40000 ALTER TABLE `tblrecord` DISABLE KEYS */;
INSERT INTO `tblrecord` VALUES (3,'2020-03-21','s','ljlj','ljlk','jlk','jlk','2020-03-21','jlkj','lj','lkj','lkj','lkjlk','jlk',1234,0,'sda'),(4,'2020-03-21','lkj','ljlj','ljlk','jlk','jlk','2020-03-21','jlkj','lj','lkj','lkj','lkjlk','jlk',1234,0,'sda'),(5,'2020-03-21','lkj','ljlj','ljlk','jlk','jlk','2020-03-21','jlkj','lj','lkj','lkj','lkjlk','jlk',1234,0,'sda');
/*!40000 ALTER TABLE `tblrecord` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-22 13:46:36
