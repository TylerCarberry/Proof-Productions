-- MySQL dump 10.13  Distrib 5.7.17, for macos10.12 (x86_64)
--
-- Host: elvis.rowan.edu    Database: caow2
-- ------------------------------------------------------
-- Server version	5.7.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cue`
--

DROP TABLE IF EXISTS `cue`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cue` (
  `CueID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Description` varchar(45) NOT NULL DEFAULT 'No Description',
  PRIMARY KEY (`CueID`),
  UNIQUE KEY `Name_UNIQUE` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cue`
--

LOCK TABLES `cue` WRITE;
/*!40000 ALTER TABLE `cue` DISABLE KEYS */;
INSERT INTO `cue` VALUES (16,'Test Cue 1','Test 1.'),(17,'Test Cue 2','Test 2'),(23,'New Cue','Cue description');
/*!40000 ALTER TABLE `cue` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cueitem`
--

DROP TABLE IF EXISTS `cueitem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cueitem` (
  `CueItemID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Number` int(11) NOT NULL,
  `DelayBefore` decimal(10,2) NOT NULL,
  `RunTime` decimal(10,2) NOT NULL,
  `SetVelocity` int(11) NOT NULL,
  `SetAcceleration` int(11) NOT NULL,
  `SetDeceleration` int(11) NOT NULL,
  `SetPosition` int(11) NOT NULL,
  `CounterClockwise` tinyint(1) NOT NULL,
  `Clockwise` tinyint(1) NOT NULL,
  `Running` tinyint(1) NOT NULL DEFAULT '0',
  `Stopping` tinyint(1) NOT NULL DEFAULT '0',
  `CueID` int(11) NOT NULL,
  `MotorID` int(11) NOT NULL,
  PRIMARY KEY (`CueItemID`),
  UNIQUE KEY `Name_UNIQUE` (`Name`),
  KEY `fk_cueitem_motor_idx` (`MotorID`),
  KEY `fk_cueitem_cue_idx` (`CueID`),
  CONSTRAINT `fk_cueitem_cue` FOREIGN KEY (`CueID`) REFERENCES `cue` (`CueID`) ON DELETE CASCADE ON UPDATE NO ACTION,
  CONSTRAINT `fk_cueitem_motor` FOREIGN KEY (`MotorID`) REFERENCES `motor` (`MotorID`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cueitem`
--

LOCK TABLES `cueitem` WRITE;
/*!40000 ALTER TABLE `cueitem` DISABLE KEYS */;
INSERT INTO `cueitem` VALUES (10,'Open Curtain Call',1,2.00,10.00,400,100,100,0,1,0,0,0,16,12),(11,'Close Curtain Call',2,15.00,6.00,500,150,150,0,0,1,0,0,16,12),(12,'CCW1',1,2.00,7.00,400,200,200,0,1,0,0,0,17,12),(13,'CC1',1,11.00,7.00,200,100,100,0,0,1,0,0,17,12),(23,'Item1',123,2.00,13.00,400,50,100,0,0,1,0,0,23,12);
/*!40000 ALTER TABLE `cueitem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `motor`
--

DROP TABLE IF EXISTS `motor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `motor` (
  `MotorID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `IPAddress` varchar(45) NOT NULL,
  `Description` varchar(45) NOT NULL DEFAULT 'No description',
  `PLCID` int(11) NOT NULL,
  `LimitMaxVelocity` int(11) NOT NULL,
  `LimitMaxAcceleration` int(11) NOT NULL,
  `LimitMaxDeceleration` int(11) NOT NULL,
  `LimitMaxNegPosition` int(11) NOT NULL,
  `LimitMaxPosPosition` int(11) NOT NULL,
  PRIMARY KEY (`MotorID`),
  UNIQUE KEY `Name_UNIQUE` (`Name`),
  KEY `fk_motor_plc_idx` (`PLCID`),
  CONSTRAINT `fk_motor_plc` FOREIGN KEY (`PLCID`) REFERENCES `plc` (`PLCID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `motor`
--

LOCK TABLES `motor` WRITE;
/*!40000 ALTER TABLE `motor` DISABLE KEYS */;
INSERT INTO `motor` VALUES (12,'Lab Motor','192.168.10.4','Motor in the lab room.',2,1700,500,500,-2000000000,2000000000),(13,'Lab Motor2','192.168.10.4','Motor in the lab room. Limit 1000.',2,1700,1000,1000,-2000000000,2000000000),(18,'Test','192.131','rerer',2,1500,100,100,200000000,200000000);
/*!40000 ALTER TABLE `motor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `plc`
--

DROP TABLE IF EXISTS `plc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `plc` (
  `PLCID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`PLCID`),
  UNIQUE KEY `Name_UNIQUE` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `plc`
--

LOCK TABLES `plc` WRITE;
/*!40000 ALTER TABLE `plc` DISABLE KEYS */;
INSERT INTO `plc` VALUES (2,'PLC1'),(5,'PLC1000'),(7,'PLC2'),(1,'PLC3'),(3,'PLC52'),(4,'PLC74');
/*!40000 ALTER TABLE `plc` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-12-16 23:06:46
