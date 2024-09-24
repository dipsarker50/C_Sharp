-- MySQL dump 10.13  Distrib 8.4.0, for macos14 (arm64)
--
-- Host: localhost    Database: HospitalManagement
-- ------------------------------------------------------
-- Server version	8.4.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Admins`
--

DROP TABLE IF EXISTS `Admins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Admins` (
  `AdminID` int NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Email` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `Password` varchar(255) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci NOT NULL,
  `FullName` varchar(100) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  `ImagePath` varchar(1000) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  PRIMARY KEY (`AdminID`),
  UNIQUE KEY `Username` (`Username`),
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Admins`
--

LOCK TABLES `Admins` WRITE;
/*!40000 ALTER TABLE `Admins` DISABLE KEYS */;
INSERT INTO `Admins` VALUES (11,'adminuser','admin@gmail.com','123456789','Dip Sarker','D:\\Project 1\\WinFormsApp1\\images\\AdminPicture\\photo_2023-03-31_17-24-28 (2).jpg'),(13,'admin','admin1@gmail.com','123456789','new admin','D:\\Project 1\\WinFormsApp1\\images\\AdminPicture\\Screenshot 2023-11-29 152605.png');
/*!40000 ALTER TABLE `Admins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Appointments`
--

DROP TABLE IF EXISTS `Appointments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Appointments` (
  `AppointmentID` int NOT NULL AUTO_INCREMENT,
  `PatientID` int NOT NULL,
  `DoctorID` int NOT NULL,
  `AppointmentStatus` enum('Upcoming','Canceled','Done') NOT NULL,
  `AppointmentTime` datetime NOT NULL,
  PRIMARY KEY (`AppointmentID`),
  KEY `FK_Patient` (`PatientID`),
  KEY `FK_Doctor` (`DoctorID`),
  CONSTRAINT `FK_Doctor` FOREIGN KEY (`DoctorID`) REFERENCES `Doctors` (`DoctorId`),
  CONSTRAINT `FK_Patient` FOREIGN KEY (`PatientID`) REFERENCES `Patients` (`PatientId`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Appointments`
--

LOCK TABLES `Appointments` WRITE;
/*!40000 ALTER TABLE `Appointments` DISABLE KEYS */;
INSERT INTO `Appointments` VALUES (2,13,7,'Upcoming','2024-10-15 14:30:00'),(3,13,9,'Upcoming','2024-10-15 15:30:00'),(4,13,7,'Done','2024-09-24 14:00:00'),(5,13,7,'Canceled','2024-09-24 14:00:00'),(6,13,7,'Canceled','2024-09-24 15:00:00'),(7,13,9,'Done','2024-09-24 14:00:00'),(8,13,9,'Canceled','2024-09-24 14:45:00'),(9,13,9,'Done','2024-09-24 15:45:00'),(10,13,9,'Canceled','2024-09-24 17:45:00'),(11,14,7,'Canceled','2024-09-24 16:30:00'),(12,14,9,'Done','2024-09-24 16:30:00'),(13,14,9,'Canceled','2024-09-24 16:45:00'),(14,13,9,'Canceled','2024-09-24 17:00:00'),(15,14,7,'Done','2024-09-24 14:45:00'),(16,14,7,'Done','2024-09-24 18:00:00'),(17,14,7,'Canceled','2024-09-24 20:00:00'),(18,14,9,'Done','2024-09-24 19:15:00'),(19,14,7,'Canceled','2024-09-24 19:45:00'),(20,13,12,'Done','2024-09-24 20:45:00'),(21,13,12,'Done','2024-09-24 14:00:00'),(22,13,12,'Done','2024-09-24 16:15:00'),(23,14,7,'Done','2024-09-24 16:00:00'),(24,14,12,'Done','2024-09-24 14:00:00'),(25,14,10,'Upcoming','2024-09-25 15:00:00'),(26,13,10,'Upcoming','2024-09-24 08:00:00'),(27,13,10,'Upcoming','2024-09-25 16:00:00');
/*!40000 ALTER TABLE `Appointments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Doctors`
--

DROP TABLE IF EXISTS `Doctors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Doctors` (
  `DoctorId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) NOT NULL,
  `Specialty` varchar(100) DEFAULT NULL,
  `PhoneNumber` varchar(15) DEFAULT NULL,
  `ImagePath` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`DoctorId`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Doctors`
--

LOCK TABLES `Doctors` WRITE;
/*!40000 ALTER TABLE `Doctors` DISABLE KEYS */;
INSERT INTO `Doctors` VALUES (7,'Dip Sarker','Cardiac','+8801714416501','D:\\Project 1\\WinFormsApp1\\images\\DoctorPictures\\doctor_7.jpg'),(9,'Dip Roy','Heart','+8801996840101','D:\\Project 1\\WinFormsApp1\\images\\DoctorPictures\\doctor_9.jpg'),(10,'Dr. Jain','Cardiac','01996840101','D:\\Project 1\\WinFormsApp1\\images\\DoctorPictures\\doctor_10.jpg'),(11,'Dr. Jenifer','neurologist','01996840102','D:\\Project 1\\WinFormsApp1\\images\\DoctorPictures\\doctor_11.jpg'),(12,'Dr. Sharmin','Cardiac','01714416509','D:\\Project 1\\WinFormsApp1\\images\\DoctorPictures\\doctor_12.jpg');
/*!40000 ALTER TABLE `Doctors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Patients`
--

DROP TABLE IF EXISTS `Patients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Patients` (
  `PatientId` int NOT NULL AUTO_INCREMENT,
  `FullName` varchar(100) NOT NULL,
  `Age` int DEFAULT NULL,
  `Gender` enum('Male','Female','Other') DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `MedicalCondition` text,
  `PhoneNumber` varchar(15) DEFAULT NULL,
  `EncryptedPassword` varchar(64) DEFAULT NULL,
  PRIMARY KEY (`PatientId`),
  UNIQUE KEY `UC_Patient_PhoneNumber` (`PhoneNumber`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Patients`
--

LOCK TABLES `Patients` WRITE;
/*!40000 ALTER TABLE `Patients` DISABLE KEYS */;
INSERT INTO `Patients` VALUES (13,'Tonmoy kumar Sarker',18,'Male','Bangladesh','Regular Checkup','+8801996840101','123456789'),(14,'Dip Sarker',22,'Male','Netrokona','Cold cough','+8801714416504','123456789'),(15,'Dip Roy',23,'Male','Netrokona','Regular Checkup','+8801996840102','123456789'),(18,'Adi',22,'Male','Dhaka','Fever','+8801816281910','1111111111');
/*!40000 ALTER TABLE `Patients` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-09-25  3:11:08
