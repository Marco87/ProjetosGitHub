CREATE DATABASE  IF NOT EXISTS `estrelaoriental3` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `estrelaoriental3`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win64 (x86_64)
--
-- Host: 186.202.152.106    Database: estrelaoriental3
-- ------------------------------------------------------
-- Server version	5.1.73-rel14.11-log

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
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  `telefone` varchar(45) DEFAULT NULL,
  `Celular` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `endereco` varchar(45) DEFAULT NULL,
  `tipoCliente` varchar(2) DEFAULT NULL,
  `login` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'MARCO','(21) 5620-9314','(21) 81980-5260','','','PF',NULL),(2,'JOÃO','(21) 9262-5872','(21) 17056-2748','','','PF',NULL),(3,'JOSÉ','(21) 3910-7725','(21) 86231-4872','','','PF',NULL),(4,'SAMIR','(21) 6897-1312','(21) 84894-7831','','','PF',NULL),(5,'PACO','(21) 5864-5385','(21) 36903-4956','','','PF',NULL),(6,'ALLEJO','(21) 5015-8728','(21) 37113-3687','','','PF',NULL),(7,'KIMI','(21) 4582-1360','(21) 73011-5445','','','PF',NULL),(8,'CLODOALDO','(21) 3052-1180','(21) 46979-9910','','','PF',NULL),(9,'MIRO','(21) 6460-1597','(21) 53676-6042','','','PF',NULL),(10,'CECI','(21) 8606-8239','(21) 41053-2402','','','PF',NULL),(12,'JOSE','(21) 1071-7599','(21) 96927-1259','','','PF','JOS-3254'),(13,'FÁBRICA DE SABÃO','(21) 2522-4543','(21) 98760-9877','','','PJ','FSB-3287'),(14,'JOÃO','(21) 2535-3656','(21) 98398-8213','','RUA DO PAO DE QUEIJO, 32 - VILA ISABEL','PF','CCC-1111'),(15,'BOENTE','(21) 3456-7899','(21) 99999-9999','BOENTE@GMAIL.COM','','PF','BOE-1234'),(16,'GUSTAVO','(21) 4783-1118','(21) 72145-2297','','RUA DOS CARROS, 345','PF','GUS-3322'),(17,'MATOS','(43) 2233-2123','(43) 98848-4748','','','PF','MAT-1122'),(18,'SANTOS','(21) 1240-2847','(21) 98409-2314','','','PF','SAN-5454'),(19,'SOUZA','(21) 5380-2180','(21) 20476-3296','','','PF','SOU-2323'),(20,'SILVIO SILVA','(21) 8624-1020','(21) 54609-7571','','','PF','SIL-4321'),(21,'MARIO GOTZE','(21) 9225-3067','(21) 79409-4337','','','PF','GOT-1919'),(22,'MARIO MANDKUKIC','(21) 7658-9089','(21) 78606-6293','','','PF','MAN-1717'),(23,'FÁBRICA DE SAPATO','(31) 4242-2827','(31) 98942-8924','FABSAPATO@GMAIL.COM','','PJ','SAP-5566'),(24,'FÁBRICA DE BISCOITO DE POLVILHO','(21) 2473-5096','(21) 14755-4663','','','PJ','BBB-1234'),(25,'FÁBRICA DE DOCES','(31) 4244-2422','(21) 31498-1988','','','PJ','DOC-1234'),(26,'FÁBRICA DE COLCHAS','(21) 3456-6646','(21) 94092-0429','','','PJ','COL-4321'),(27,'KARIM BENZEMA','(21) 3442-4111','(21) 31489-1841','','','PF','BEN-8899'),(28,'MANUEL NEUER','(21) 3958-3984','(21) 98429-8294','','','PF','NEU-1111'),(29,'DAVID LUIZ','(21) 4249-0191','(21) 84982-9281','','','PF','DAV-4444'),(30,'JAVIER MASCHERANO','(21) 3133-1891','(21) 98139-8139','','','PF','MAS-1414'),(31,'STEVEN GERRARD','(21) 3445-3357','(21) 89383-1931','','','PF','GER-8888'),(32,'ASHLEY COLE','(21) 3263-2242','(21) 83557-7332','','','PF','COL-3333'),(33,'SÉRGIO AGUERO','(21) 3138-4980','(21) 72402-0980','','','PF','AGU-1616'),(34,'MÁRIO BALOTELLI','(21) 3428-9429','(21) 94892-8299','','','PF','BAL-9999'),(35,'IKER CASILLAS','(21) 4428-3989','(21) 99280-8108','','','PF','CAS-1111'),(36,'CARLES PUYOL','(21) 3192-3829','(21) 93824-9289','','','PF','PUY-5555'),(37,'CALÇADOS E CIA.','(21) 8062-5021','(21) 90313-3549','','RUA DOS SAPATOS, 123','PJ','SAP-321'),(38,'VICTOR VALDÉS','(21) 4928-9189','(21) 49020-1910','','','PF','VAL-1111'),(39,'PATRICK EVRA','(21) 3422-9891','(21) 98298-1989','','','PF','EVR-3333'),(40,'MIROSLAV KLOSE','(21) 4240-2202','(21) 94202-9402','','','PF','KLO-1111'),(41,'THIAGO SILVA','(21) 4829-8191','(21) 39829-8199','','','PF','THI-3333'),(42,'CHARLES','(24) 2224-2424','(24) 24222-4242','CHARLESDARABO@DARABO.COM','AV. DA RABO','PF','RAB-1234'),(43,'ARJEN ROBBEN','(21) 3432-4535','(21) 92891-4971','ROBBEN@HOLANDA.COM','RUA LARANJA, N° 11','PF','ROB-1111'),(44,'DE JONG','(21) 4478-2718','(21) 92897-3917','','','PF','JON-5555'),(45,'PLABO ARMERO','(21) 2484-2989','(21) 92039-1090','','','PF','ARM-3333'),(46,'JAVIER HERNANDEZ','(21) 3438-9198','(21) 93109-2092','','','PF','CHI-1414'),(47,'ARTURO VIDAL','(21) 3492-8198','(21) 93198-1987','VIDAL@CHILE.COM','RUA ABCDEF','PF','VID-8888'),(48,'ANDREA PIRLO','(21) 3491-0110','(21) 93928-9189','','','PF','PIR-2121'),(49,'FÁBRICA DE LATA VELHA','(21) 4010-9101','(21) 84918-9189','LATAVELHA@GMAIL.COM','RUA DA LATA VELHA, 45, ACV','PJ','LAT-1234'),(50,'JOAO','(21) 5675-7657','(21) 76868-6868','J@J.COM','RUA DO PÃO DE QUEIJO','PF','ZXC-1234'),(51,'LUIZ OTÁVIO','(21) 2763-8678','(21) 98754-6375','','','PF','HJH-3232'),(52,'MARINA FREITAS','(21) 2763-6900','(21) 97663-4340','MARINAFREITAS.97@GMAIL.COM','RUA DAS AMORAS, 38','PF','HUM-2345'),(53,'JOAO ROTATIVO','(21) 2481-9819','(21) 93819-8197','','','PF','ROT-1111'),(54,'JOAO DIARIO','(21) 3398-1918','(21) 93891-8918','','','PF','DIA-1111'),(55,'JOAO MENSAL','(21) 3819-8191','(21) 94891-8989','','','PF','MEN-1111'),(56,'JOAO ANUAL','(21) 3389-8010','(21) 98980-1813','','','PF','ANU-1111'),(57,'JOAO SEMESTRAL','(21) 3108-3808','(21) 93897-1868','','','PF','SEM-1111'),(58,'JOAO TRIMESTRAL','(21) 3498-9380','(21) 94921-8616','','','PF','TRI-1111'),(59,'GABRIELA BONNIN','(21) 3339-2745','(21) 98858-6523','ANNA_BONNIN@GMAIL.COM','AV. PASSOS DOS SANTOS, N2304','PF','ANN-1234'),(60,'GOMEZ','(21) 3847-1871','(21) 94878-4262','','','PF','GOM-1234'),(61,'PINILLA','(21) 4878-1681','(21) 94782-6818','','','PF','PIN-1234'),(62,'BALÃO','(21) 3997-9279','(21) 93718-6886','','','PF','BAL-1234'),(63,'FÁBRICA DE BOLINHA','(21) 3438-4268','(21) 94718-1909','','','PJ','BOL-4433'),(64,'FRANK DE BOER','(21) 3429-7229','(21) 99427-2862','','','PF','FBO-4444'),(65,'RONALD DE BOER','(21) 3429-8791','(21) 94729-2799','','','PF','RBO-7777'),(66,'REDSOFT','(21) 3339-1127','(21) 98606-0145','REDSOFT@GMAIL.COM','AV. PASSOS DA ALAMEDA','PJ','RED-1111'),(67,'JOÃO DOS SANTOS RIBEIRO','(21) 9865-4543','(21) 34223-4343','JOAO@HOTMAIL.COM','AV ALAMEDA','PF','JOA-2014');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `controle_estacionar`
--

DROP TABLE IF EXISTS `controle_estacionar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `controle_estacionar` (
  `idControle_Registro` int(11) NOT NULL AUTO_INCREMENT,
  `dataHoraEntrada` datetime DEFAULT NULL,
  `dataHoraSaida` datetime DEFAULT NULL,
  `valor` float DEFAULT NULL,
  `idVaga` int(11) DEFAULT NULL,
  `idGerenciarSituacaoPagamento` int(11) DEFAULT NULL,
  PRIMARY KEY (`idControle_Registro`),
  KEY `idGerenciarSituacaoPagamento_idx` (`idGerenciarSituacaoPagamento`),
  KEY `id_Vaga_idx` (`idVaga`),
  CONSTRAINT `idGerenciarSituacaoPagamento` FOREIGN KEY (`idGerenciarSituacaoPagamento`) REFERENCES `gerenciar_situacao_pagamento` (`idGerenciarSituacaoPagamento`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `controle_estacionar`
--

LOCK TABLES `controle_estacionar` WRITE;
/*!40000 ALTER TABLE `controle_estacionar` DISABLE KEYS */;
INSERT INTO `controle_estacionar` VALUES (4,'2014-06-21 16:51:41',NULL,NULL,NULL,21),(5,'2014-06-21 18:44:15',NULL,NULL,NULL,1),(6,'2014-06-21 18:57:05','2014-06-21 19:29:04',0,NULL,20),(7,'2014-06-21 20:55:21','2014-06-21 20:55:21',125,NULL,19),(8,'2014-06-21 21:00:11','2014-06-21 21:00:11',1200,NULL,20),(9,'2014-06-21 21:04:41','2014-06-21 21:04:41',125,NULL,19),(10,'2014-06-21 21:07:04','2014-06-21 21:07:04',125,NULL,19),(11,'2014-06-21 21:09:34','2014-06-21 21:09:34',125,NULL,19),(12,'2014-06-21 21:28:06','2014-06-21 21:28:06',125,NULL,4),(13,'2014-06-21 22:14:36','2014-06-21 22:14:36',220,NULL,24),(14,'2014-06-21 22:17:41','2014-06-21 22:17:41',310,NULL,25),(15,'2014-06-21 22:17:59','2014-06-21 22:17:59',310,NULL,25),(16,'2014-06-21 22:25:21','2014-06-21 22:25:21',310,NULL,25),(17,'2014-07-03 10:27:09',NULL,NULL,NULL,26),(18,'2014-07-03 10:29:12',NULL,NULL,NULL,25),(19,'2014-07-03 10:34:44',NULL,NULL,NULL,25),(20,'2014-07-03 10:35:20',NULL,NULL,NULL,25),(21,'2014-07-03 12:25:44','2014-07-03 12:25:44',600,NULL,27),(22,'2014-07-03 14:59:44',NULL,NULL,NULL,27),(23,'2014-07-03 15:06:24',NULL,NULL,135,27),(24,'2014-07-03 15:08:56',NULL,NULL,122,28),(25,'2014-07-03 15:28:48','2014-07-03 15:44:19',0,124,27),(26,'2014-07-03 15:43:24','2014-07-03 15:43:50',15,126,29),(27,'2014-07-03 16:02:06','2014-07-03 16:02:25',15,121,30),(28,'2014-07-03 16:06:06','2014-07-03 16:06:38',15,126,31),(29,'2014-07-04 18:49:17',NULL,NULL,82,9),(30,'2014-07-04 19:50:47','2014-07-04 19:51:25',15,63,34),(31,'2014-07-04 20:34:28','2014-07-04 20:35:17',0.03,43,36),(32,'2014-07-04 20:44:49','2014-07-04 20:44:49',125,NULL,27),(33,'2014-07-04 20:45:10','2014-07-04 20:45:10',125,NULL,27),(34,'2014-07-04 21:06:13','2014-07-04 21:14:59',0,81,37),(35,'2014-07-04 21:20:26','2014-07-04 21:22:21',0.06,81,38),(36,'2014-07-04 23:03:47','2014-07-04 23:03:47',125,NULL,37),(37,'2014-07-04 23:14:38','2014-07-04 23:14:53',0.01,18,36),(38,'2014-07-05 11:35:28','2014-07-05 11:36:17',15,63,40);
/*!40000 ALTER TABLE `controle_estacionar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gerenciar_situacao_pagamento`
--

DROP TABLE IF EXISTS `gerenciar_situacao_pagamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gerenciar_situacao_pagamento` (
  `idGerenciarSituacaoPagamento` int(11) NOT NULL AUTO_INCREMENT,
  `idCliente` int(11) NOT NULL,
  `idVeiculo` int(11) NOT NULL,
  `idTipoPlanoEstacionamento` int(11) NOT NULL,
  `situacaoPagamento` varchar(45) DEFAULT NULL,
  `vencimentoPagamento` datetime DEFAULT NULL,
  `mesesPagos` int(11) DEFAULT NULL,
  PRIMARY KEY (`idGerenciarSituacaoPagamento`),
  KEY `idTipoPlanoEstacionamento_idx` (`idTipoPlanoEstacionamento`),
  KEY `id_Cliente_idx` (`idCliente`),
  KEY `id_Veiculo_idx` (`idVeiculo`),
  CONSTRAINT `idTipoPlanoEstacionamento` FOREIGN KEY (`idTipoPlanoEstacionamento`) REFERENCES `tipo_plano_estacionamento` (`idTipoEstacionamento`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `id_Cliente` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `id_Veiculo` FOREIGN KEY (`idVeiculo`) REFERENCES `veiculo` (`idVeiculo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gerenciar_situacao_pagamento`
--

LOCK TABLES `gerenciar_situacao_pagamento` WRITE;
/*!40000 ALTER TABLE `gerenciar_situacao_pagamento` DISABLE KEYS */;
INSERT INTO `gerenciar_situacao_pagamento` VALUES (1,13,14,2,'NÃO POSSUI PLANO','1800-01-01 00:00:00',NULL),(4,23,21,3,'A PAGAR','2014-06-03 18:38:02',1),(5,12,23,2,NULL,'2014-07-16 22:17:17',NULL),(6,24,24,3,'NÃO POSSUI PLANO','2014-06-27 20:34:20',NULL),(7,24,25,4,NULL,'2014-07-20 09:44:35',NULL),(8,24,26,3,NULL,'2014-07-20 09:52:58',NULL),(9,25,27,3,'A PAGAR','2014-06-28 20:34:20',NULL),(10,26,28,4,'NÃO POSSUI PLANO','2014-06-30 20:34:20',NULL),(11,27,29,1,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(12,28,30,2,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(13,29,31,3,'NÃO POSSUI PLANO','2014-07-02 20:34:20',NULL),(14,30,32,2,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(15,31,33,4,'NÃO POSSUI PLANO','2014-07-04 20:34:20',NULL),(16,32,34,3,'NÃO POSSUI PLANO','2014-07-03 20:34:20',NULL),(17,33,35,1,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(18,34,36,3,'NÃO POSSUI PLANO','2014-07-17 20:34:20',NULL),(19,35,37,3,'NÃO POSSUI PLANO','2014-06-19 20:34:20',2),(20,36,38,4,'A PAGAR','2014-06-25 20:34:20',NULL),(21,37,39,3,'A PAGAR','2014-07-03 20:34:20',1),(22,38,40,1,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(23,39,41,3,'A PAGAR','2014-06-27 21:38:13',NULL),(24,40,42,5,'A PAGAR','2014-06-25 22:13:57',2),(25,41,43,6,'NÃO POSSUI PLANO','2013-08-11 22:16:44',9),(26,42,44,1,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(27,43,45,3,'A PAGAR','2014-06-04 12:24:59',2),(28,44,46,2,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(29,45,47,2,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(30,46,48,2,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(31,47,49,2,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(32,48,50,2,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(34,49,52,2,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(35,49,53,1,NULL,'2014-08-04 19:48:46',NULL),(36,50,54,1,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(37,51,55,3,'NÃO POSSUI PLANO','2014-07-18 21:02:48',1),(38,52,56,1,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(39,53,57,1,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(40,54,58,2,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(41,55,59,3,'NÃO POSSUI PLANO','2014-07-03 00:40:15',NULL),(42,56,60,4,'A PAGAR','2014-07-05 00:40:43',NULL),(43,57,61,7,'A PAGAR','2012-11-07 00:42:23',NULL),(44,58,62,6,'A PAGAR','2014-04-07 00:43:45',NULL),(45,59,63,1,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(46,59,64,2,NULL,'2014-08-05 02:48:58',NULL),(47,60,65,2,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL),(48,61,66,4,'NÃO POSSUI PLANO','2014-07-05 06:46:40',NULL),(49,62,67,5,'A PAGAR','2014-07-05 06:47:32',NULL),(50,63,68,6,'A PAGAR','2014-07-05 06:48:22',NULL),(51,64,69,7,'A PAGAR','2014-07-07 06:49:38',NULL),(52,65,70,5,'A PAGAR','2014-07-01 06:50:21',NULL),(53,66,71,3,'A PAGAR','2014-08-01 09:19:08',NULL),(54,66,72,3,NULL,'2014-08-05 09:20:49',NULL),(55,67,73,2,'NÃO POSSUI PLANO','2099-01-01 00:00:00',NULL);
/*!40000 ALTER TABLE `gerenciar_situacao_pagamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `preco`
--

DROP TABLE IF EXISTS `preco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `preco` (
  `idPreco` int(11) NOT NULL AUTO_INCREMENT,
  `valor` float DEFAULT NULL,
  `descricao` varchar(45) DEFAULT NULL,
  `idControleEstacionamento` int(11) DEFAULT NULL,
  PRIMARY KEY (`idPreco`),
  KEY `idControleEstacionamento_idx` (`idControleEstacionamento`),
  CONSTRAINT `idControleEstacionamento` FOREIGN KEY (`idControleEstacionamento`) REFERENCES `controle_estacionar` (`idControle_Registro`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `preco`
--

LOCK TABLES `preco` WRITE;
/*!40000 ALTER TABLE `preco` DISABLE KEYS */;
/*!40000 ALTER TABLE `preco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_plano_estacionamento`
--

DROP TABLE IF EXISTS `tipo_plano_estacionamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_plano_estacionamento` (
  `idTipoEstacionamento` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(45) DEFAULT NULL,
  `valor` float DEFAULT NULL,
  `mesesPlano` int(11) DEFAULT NULL,
  PRIMARY KEY (`idTipoEstacionamento`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_plano_estacionamento`
--

LOCK TABLES `tipo_plano_estacionamento` WRITE;
/*!40000 ALTER TABLE `tipo_plano_estacionamento` DISABLE KEYS */;
INSERT INTO `tipo_plano_estacionamento` VALUES (1,'ROTATIVO',2,NULL),(2,'DIÁRIO',15,NULL),(3,'MENSAL',125,1),(4,'ANUAL',1200,12),(5,'BIMESTRAL',220,2),(6,'TRIMESTRAL',310,3),(7,'SEMESTRAL',600,6),(8,'QUADRIMESTRAL',550,4),(9,'TESTE',50,3);
/*!40000 ALTER TABLE `tipo_plano_estacionamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `idusuario` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  `telefone` varchar(45) DEFAULT NULL,
  `celular` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `endereco` varchar(45) DEFAULT NULL,
  `tipoUsuario` varchar(45) DEFAULT NULL,
  `login` varchar(45) DEFAULT NULL,
  `senha` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idusuario`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (3,'ADMINISTRADOR','(21) 2233-1122','(21) 98398-2989','ADMINISTRADOR@HOTMAIL.COM','RUA DOS ADMINISTRADORES, 77, RJ','ADM','ADM','ADM'),(4,'VALMIR','(21)99992-3232',NULL,NULL,NULL,'OPE','OPE01','OPE01'),(6,'MARCO AURÉLIO','(21) 3402-9019','(21) 94289-1899','MARCO@YAHOO.COM.BR','RUA 456','OPE','MARCOOPE','123'),(7,'OPERADOR','(21) 3190-4920','(21) 94919-8989','','','OPE','OPERADORADOR','12345'),(11,'RENDSON','(21) 2324-3556','(21) 98566-3556','RED@HOTMAIL.COM','','OPE','REDCDC','12345'),(13,'LILIAN FREITAS','(21) 2374-8354','(21) 99146-9445','','','ADM','LFREITAS','123'),(14,'MARCO 123','(  )     -','(  )      -','','','OPE','MARCOPERADOR1234','123');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vaga`
--

DROP TABLE IF EXISTS `vaga`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vaga` (
  `idVaga` int(11) NOT NULL AUTO_INCREMENT,
  `andar` int(45) DEFAULT NULL,
  `vaga` varchar(45) DEFAULT NULL,
  `tipo` int(11) DEFAULT NULL,
  `situacao` varchar(45) DEFAULT NULL,
  `posicao_x` int(11) DEFAULT NULL,
  `posicao_y` int(11) DEFAULT NULL,
  `angulo` int(11) DEFAULT NULL,
  `remove` int(11) DEFAULT NULL,
  PRIMARY KEY (`idVaga`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vaga`
--

LOCK TABLES `vaga` WRITE;
/*!40000 ALTER TABLE `vaga` DISABLE KEYS */;
/*!40000 ALTER TABLE `vaga` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `veiculo`
--

DROP TABLE IF EXISTS `veiculo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `veiculo` (
  `idVeiculo` int(11) NOT NULL AUTO_INCREMENT,
  `placa` varchar(45) DEFAULT NULL,
  `marca` varchar(45) DEFAULT NULL,
  `modelo` varchar(45) DEFAULT NULL,
  `ano` varchar(6) DEFAULT NULL,
  `idCliente` int(11) NOT NULL,
  `tipo` int(11) DEFAULT NULL,
  PRIMARY KEY (`idVeiculo`),
  KEY `idCliente_idx` (`idCliente`),
  CONSTRAINT `idCliente` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=74 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `veiculo`
--

LOCK TABLES `veiculo` WRITE;
/*!40000 ALTER TABLE `veiculo` DISABLE KEYS */;
INSERT INTO `veiculo` VALUES (7,'HHH-7755','FORD','FIESTA','',10,NULL),(9,'GGG-5454','CHEVROLET','MONZA','',12,NULL),(10,'JKJ-9876','CHEVROLET','CORSA','',13,NULL),(13,'CCC-1111','HONDA','CIVIC','2000',16,NULL),(14,'FAF-1999','FORD','KA','1999',13,NULL),(15,'MAT-1122','','','',17,NULL),(16,'SAN-5454','','','',18,NULL),(17,'SOU-2323','','','',19,NULL),(18,'SIL-4321','','','2000',20,NULL),(19,'TZE-1919','FORD','FOCUS','2013',21,NULL),(20,'CHE-1717','CHEVROLET','CORSA','',22,NULL),(21,'XXX-9900','KIA','SORENTO','2012',23,NULL),(22,'CCC-1122','HONDA','FIT','2001',16,NULL),(23,'GUS-1234','FIAT','UNO','1980',12,NULL),(24,'BBB-1234','','FERRARI','',24,NULL),(25,'BBB-1233','','FUSCA','',24,NULL),(26,'BBB-1232','','HARLEY D.','2015',24,NULL),(27,'DOC-1234','','SAVEIRO','2000',25,NULL),(28,'COL-4321','','FOX','2003',26,NULL),(29,'BEN-8899','RENAULT','206','',27,NULL),(30,'NEU-1111','','FOX','2015',28,NULL),(31,'DAV-4444','','FUSCA','1977',29,NULL),(32,'JAV-1414','FIAT','SIENA','2004',30,NULL),(33,'GER-4444','','BRASÍLIA','1960',31,NULL),(34,'COL-3333','FIAT','PALIO','2000',32,NULL),(35,'AGU-1616','CHEVROLET','OPALA','1985',33,NULL),(36,'BAL-9999','RENAULT','206','2010',34,NULL),(37,'CAS-1111','CHEVROLET','CAMARO','2016',35,NULL),(38,'PUY-5555','FERRARI','F430','2017',36,NULL),(39,'CHE-9090','CHEVROLET','CHEVETE','1990',37,NULL),(40,'VAL-1111','','ECLIPSE','2012',38,NULL),(41,'EVR-3333','','FOX','2011',39,NULL),(42,'KLO-1111','FORD','FIESTA','1989',40,NULL),(43,'THI-3333','FIAT','UNO','1997',41,NULL),(44,'KOL-2822','FIAT','SIENA ELX 1.4','2009',42,NULL),(45,'ROB-1111','CHEVROLET','CELTA','2011',43,NULL),(46,'JON-5555','CHEVROLET','CELTA','2000',44,NULL),(47,'ARM-3333','FIAT','SIENA','2001',45,NULL),(48,'CHI-1414','RENAULT','206','2014',46,NULL),(49,'VID-8888','CHEVROLET','OPALA','1987',47,NULL),(50,'PIR-2121','VOLKSWAGEN','FOX','2005',48,NULL),(52,'LAT-1234','VOLKSWAGEN','FUSCA','1965',49,NULL),(53,'LAT-4321','CHEVROLET','CORCEL','1977',49,NULL),(54,'ZXC-1234','CHEVROLET','CORSA','2013',50,NULL),(55,'HJH-3232','FIAT','UNO ADVENTURE','2013',51,NULL),(56,'HUM-2345','FIAT','UNO','2011',52,NULL),(57,'ROT-1111','VOLKSWAGEN','FUSCA','1977',53,NULL),(58,'DIA-1111','VOLKSWAGEN','BRASILIA','1980',54,NULL),(59,'MEN-1111','VOLKSWAGEN','SAVEIRO','2000',55,NULL),(60,'ANU-1111','VOLKSWAGEN','FOX','2001',56,NULL),(61,'SEM-1111','CHEVROLET','CAMARO','2001',57,NULL),(62,'TRI-1111','VOLKSWAGEN','FUSCA','1988',58,NULL),(63,'KOL-2811','FIAT','SIENA ELX 1.4','2009',59,NULL),(64,'KOL-2812','FIAT','GRAND SIENA','2013',59,NULL),(65,'GOM-1234','VOLKSWAGEN','FOX','2000',60,NULL),(66,'PIN-1234','VOLKSWAGEN','FOX','2004',61,NULL),(67,'BAL-1234','VOLKSWAGEN','FUSCA','1987',62,NULL),(68,'BOL-4433','VOLKSWAGEN','GOL','1999',63,NULL),(69,'FBO-4444','VOLKSWAGEN','FUSCA','1977',64,NULL),(70,'FBO-7777','VOLKSWAGEN','GOL','2000',65,NULL),(71,'KBL-3811','HYUNDAI','IX35','2013',66,NULL),(72,'KKL-2231','FIAT','GRAND SIENA','2014',66,NULL),(73,'KBL-2211','FIAT','FIAT UNO','2006',67,NULL);
/*!40000 ALTER TABLE `veiculo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-10-30 18:15:18