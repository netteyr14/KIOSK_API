/*
SQLyog Community v13.1.7 (64 bit)
MySQL - 8.0.35 : Database - dbcstakiosk
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`dbcstakiosk` /*!40100 DEFAULT CHARACTER SET latin1 */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `dbcstakiosk`;

/*Table structure for table `tbl_admin` */

DROP TABLE IF EXISTS `tbl_admin`;

CREATE TABLE `tbl_admin` (
  `admin_id` int NOT NULL AUTO_INCREMENT,
  `fullname` varchar(100) DEFAULT NULL,
  `uname` varchar(50) NOT NULL,
  `pword` varchar(255) NOT NULL,
  `role` varchar(50) DEFAULT NULL,
  `isactive` int DEFAULT '1',
  `isdeleted` int DEFAULT '0',
  `created_at` datetime DEFAULT NULL,
  PRIMARY KEY (`admin_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_admin` */

LOCK TABLES `tbl_admin` WRITE;

UNLOCK TABLES;

/*Table structure for table `tbl_announcement` */

DROP TABLE IF EXISTS `tbl_announcement`;

CREATE TABLE `tbl_announcement` (
  `announcement_id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(100) DEFAULT NULL,
  `message` text,
  `image_path` text,
  `admin_no` int DEFAULT NULL,
  `created_at` datetime DEFAULT NULL,
  `expire_at` datetime DEFAULT NULL,
  `isdisplay` int DEFAULT '1',
  `isdeleted` int DEFAULT '0',
  PRIMARY KEY (`announcement_id`),
  KEY `fk_announcement_admin` (`admin_no`),
  CONSTRAINT `fk_announcement_admin` FOREIGN KEY (`admin_no`) REFERENCES `tbl_admin` (`admin_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_announcement` */

LOCK TABLES `tbl_announcement` WRITE;

UNLOCK TABLES;

/*Table structure for table `tbl_attendance` */

DROP TABLE IF EXISTS `tbl_attendance`;

CREATE TABLE `tbl_attendance` (
  `attendance_id` int NOT NULL AUTO_INCREMENT,
  `student_no` int DEFAULT NULL,
  `node_no` int DEFAULT NULL,
  `logs` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`attendance_id`),
  KEY `fk_attendance_student` (`student_no`),
  KEY `fk_attendance_node` (`node_no`),
  CONSTRAINT `fk_attendance_node` FOREIGN KEY (`node_no`) REFERENCES `tbl_node` (`node_id`),
  CONSTRAINT `fk_attendance_student` FOREIGN KEY (`student_no`) REFERENCES `tbl_student` (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_attendance` */

LOCK TABLES `tbl_attendance` WRITE;

UNLOCK TABLES;

/*Table structure for table `tbl_class_sched` */

DROP TABLE IF EXISTS `tbl_class_sched`;

CREATE TABLE `tbl_class_sched` (
  `class_sched_id` int NOT NULL AUTO_INCREMENT,
  `year_level` varchar(10) DEFAULT NULL,
  `image_path` text,
  PRIMARY KEY (`class_sched_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_class_sched` */

LOCK TABLES `tbl_class_sched` WRITE;

UNLOCK TABLES;

/*Table structure for table `tbl_course` */

DROP TABLE IF EXISTS `tbl_course`;

CREATE TABLE `tbl_course` (
  `course_id` int NOT NULL AUTO_INCREMENT,
  `course_code` varchar(20) NOT NULL,
  `course_name` varchar(100) NOT NULL,
  `isdeleted` int DEFAULT '0',
  PRIMARY KEY (`course_id`),
  UNIQUE KEY `course_code` (`course_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_course` */

LOCK TABLES `tbl_course` WRITE;

UNLOCK TABLES;

/*Table structure for table `tbl_faculty` */

DROP TABLE IF EXISTS `tbl_faculty`;

CREATE TABLE `tbl_faculty` (
  `faculty_id` int NOT NULL AUTO_INCREMENT,
  `fname` varchar(50) NOT NULL,
  `mname` varchar(50) DEFAULT NULL,
  `lname` varchar(50) NOT NULL,
  `isactive` int DEFAULT '1',
  `isdeleted` int DEFAULT '0',
  PRIMARY KEY (`faculty_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_faculty` */

LOCK TABLES `tbl_faculty` WRITE;

UNLOCK TABLES;

/*Table structure for table `tbl_lostfound` */

DROP TABLE IF EXISTS `tbl_lostfound`;

CREATE TABLE `tbl_lostfound` (
  `lostfound_id` int NOT NULL AUTO_INCREMENT,
  `item_name` varchar(100) DEFAULT NULL,
  `description` text,
  `image_path` text,
  `status` varchar(10) DEFAULT NULL,
  `reported_by` varchar(255) DEFAULT NULL,
  `reported_at` datetime DEFAULT NULL,
  `claimed_by` varchar(255) DEFAULT '---',
  `claimed_at` datetime DEFAULT NULL,
  PRIMARY KEY (`lostfound_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_lostfound` */

LOCK TABLES `tbl_lostfound` WRITE;

UNLOCK TABLES;

/*Table structure for table `tbl_node` */

DROP TABLE IF EXISTS `tbl_node`;

CREATE TABLE `tbl_node` (
  `node_id` int NOT NULL AUTO_INCREMENT,
  `node_name` varchar(50) NOT NULL,
  `location` varchar(100) DEFAULT NULL,
  `device_uid` int DEFAULT NULL,
  PRIMARY KEY (`node_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_node` */

LOCK TABLES `tbl_node` WRITE;

UNLOCK TABLES;

/*Table structure for table `tbl_schedule` */

DROP TABLE IF EXISTS `tbl_schedule`;

CREATE TABLE `tbl_schedule` (
  `schedule_id` int NOT NULL AUTO_INCREMENT,
  `student_no` int DEFAULT NULL,
  `subject_no` int DEFAULT NULL,
  `day_of_week` varchar(25) DEFAULT NULL,
  `time_start` time DEFAULT NULL,
  `time_end` time DEFAULT NULL,
  `room` varchar(20) DEFAULT NULL,
  `faculty_no` int DEFAULT NULL,
  `isdeleted` int DEFAULT '0',
  PRIMARY KEY (`schedule_id`),
  KEY `fk_schedule_student` (`student_no`),
  KEY `fk_schedule_subject` (`subject_no`),
  KEY `fk_schedule_faculty` (`faculty_no`),
  CONSTRAINT `fk_schedule_faculty` FOREIGN KEY (`faculty_no`) REFERENCES `tbl_faculty` (`faculty_id`),
  CONSTRAINT `fk_schedule_student` FOREIGN KEY (`student_no`) REFERENCES `tbl_student` (`student_id`),
  CONSTRAINT `fk_schedule_subject` FOREIGN KEY (`subject_no`) REFERENCES `tbl_subject` (`subject_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_schedule` */

LOCK TABLES `tbl_schedule` WRITE;

UNLOCK TABLES;

/*Table structure for table `tbl_student` */

DROP TABLE IF EXISTS `tbl_student`;

CREATE TABLE `tbl_student` (
  `student_id` int NOT NULL AUTO_INCREMENT,
  `stud_number` varchar(20) NOT NULL,
  `rfid_card` varchar(50) DEFAULT NULL,
  `fname` varchar(50) NOT NULL,
  `mname` varchar(50) DEFAULT '-',
  `lname` varchar(50) NOT NULL,
  `course_no` int DEFAULT NULL,
  `year_level` varchar(10) DEFAULT NULL,
  `section` varchar(20) DEFAULT NULL,
  `isactive` int DEFAULT '1',
  `isdeleted` int DEFAULT '0',
  `created_at` datetime DEFAULT NULL,
  `img_path` text,
  PRIMARY KEY (`student_id`),
  KEY `fk_student_course` (`course_no`),
  CONSTRAINT `fk_student_course` FOREIGN KEY (`course_no`) REFERENCES `tbl_course` (`course_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_student` */

LOCK TABLES `tbl_student` WRITE;

UNLOCK TABLES;

/*Table structure for table `tbl_subject` */

DROP TABLE IF EXISTS `tbl_subject`;

CREATE TABLE `tbl_subject` (
  `subject_id` int NOT NULL AUTO_INCREMENT,
  `subject_code` varchar(20) NOT NULL,
  `subject_name` varchar(100) NOT NULL,
  `isdeleted` int DEFAULT '0',
  PRIMARY KEY (`subject_id`),
  UNIQUE KEY `subject_code` (`subject_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_subject` */

LOCK TABLES `tbl_subject` WRITE;

UNLOCK TABLES;

/*Table structure for table `tbl_suggestion` */

DROP TABLE IF EXISTS `tbl_suggestion`;

CREATE TABLE `tbl_suggestion` (
  `suggestion_id` int NOT NULL AUTO_INCREMENT,
  `message` text,
  `submitted_at` datetime DEFAULT NULL,
  PRIMARY KEY (`suggestion_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_suggestion` */

LOCK TABLES `tbl_suggestion` WRITE;

UNLOCK TABLES;

/*Table structure for table `vw_announcements` */

DROP TABLE IF EXISTS `vw_announcements`;

/*!50001 DROP VIEW IF EXISTS `vw_announcements` */;
/*!50001 DROP TABLE IF EXISTS `vw_announcements` */;

/*!50001 CREATE TABLE  `vw_announcements`(
 `announcement_id` int ,
 `title` varchar(100) ,
 `message` text ,
 `image_path` text ,
 `posted_by` varchar(100) ,
 `created_at` datetime ,
 `expire_at` datetime ,
 `isdisplay` int ,
 `isdeleted` int 
)*/;

/*Table structure for table `vw_attendances` */

DROP TABLE IF EXISTS `vw_attendances`;

/*!50001 DROP VIEW IF EXISTS `vw_attendances` */;
/*!50001 DROP TABLE IF EXISTS `vw_attendances` */;

/*!50001 CREATE TABLE  `vw_attendances`(
 `attendance_id` int ,
 `stud_number` varchar(20) ,
 `fname` varchar(50) ,
 `mname` varchar(50) ,
 `lname` varchar(50) ,
 `course_code` varchar(20) ,
 `course_name` varchar(100) ,
 `year_level` varchar(10) ,
 `section` varchar(20) ,
 `node_name` varchar(50) ,
 `location` varchar(100) ,
 `logs` datetime 
)*/;

/*Table structure for table `vw_schedules` */

DROP TABLE IF EXISTS `vw_schedules`;

/*!50001 DROP VIEW IF EXISTS `vw_schedules` */;
/*!50001 DROP TABLE IF EXISTS `vw_schedules` */;

/*!50001 CREATE TABLE  `vw_schedules`(
 `schedule_id` int ,
 `stud_number` varchar(20) ,
 `fname` varchar(50) ,
 `mname` varchar(50) ,
 `lname` varchar(50) ,
 `course_code` varchar(20) ,
 `course_name` varchar(100) ,
 `year_level` varchar(10) ,
 `section` varchar(20) ,
 `subject_code` varchar(20) ,
 `subject_name` varchar(100) ,
 `day_of_week` varchar(25) ,
 `time_start` time ,
 `time_end` time ,
 `room` varchar(20) ,
 `faculty_name` varchar(152) ,
 `isdeleted` int 
)*/;

/*Table structure for table `vw_students` */

DROP TABLE IF EXISTS `vw_students`;

/*!50001 DROP VIEW IF EXISTS `vw_students` */;
/*!50001 DROP TABLE IF EXISTS `vw_students` */;

/*!50001 CREATE TABLE  `vw_students`(
 `student_id` int ,
 `stud_number` varchar(20) ,
 `rfid_card` varchar(50) ,
 `fname` varchar(50) ,
 `mname` varchar(50) ,
 `lname` varchar(50) ,
 `course_code` varchar(20) ,
 `course_name` varchar(100) ,
 `year_level` varchar(10) ,
 `section` varchar(20) ,
 `isactive` int ,
 `isdeleted` int ,
 `created_at` datetime ,
 `img_path` text 
)*/;

/*View structure for view vw_announcements */

/*!50001 DROP TABLE IF EXISTS `vw_announcements` */;
/*!50001 DROP VIEW IF EXISTS `vw_announcements` */;

/*!50001 CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `vw_announcements` AS select `ann`.`announcement_id` AS `announcement_id`,`ann`.`title` AS `title`,`ann`.`message` AS `message`,`ann`.`image_path` AS `image_path`,`ad`.`fullname` AS `posted_by`,`ann`.`created_at` AS `created_at`,`ann`.`expire_at` AS `expire_at`,`ann`.`isdisplay` AS `isdisplay`,`ann`.`isdeleted` AS `isdeleted` from (`tbl_announcement` `ann` left join `tbl_admin` `ad` on((`ann`.`admin_no` = `ad`.`admin_id`))) */;

/*View structure for view vw_attendances */

/*!50001 DROP TABLE IF EXISTS `vw_attendances` */;
/*!50001 DROP VIEW IF EXISTS `vw_attendances` */;

/*!50001 CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `vw_attendances` AS select `a`.`attendance_id` AS `attendance_id`,`st`.`stud_number` AS `stud_number`,`st`.`fname` AS `fname`,`st`.`mname` AS `mname`,`st`.`lname` AS `lname`,`c`.`course_code` AS `course_code`,`c`.`course_name` AS `course_name`,`st`.`year_level` AS `year_level`,`st`.`section` AS `section`,`n`.`node_name` AS `node_name`,`n`.`location` AS `location`,`a`.`logs` AS `logs` from (((`tbl_attendance` `a` left join `tbl_student` `st` on((`a`.`student_no` = `st`.`student_id`))) left join `tbl_course` `c` on((`st`.`course_no` = `c`.`course_id`))) left join `tbl_node` `n` on((`a`.`node_no` = `n`.`node_id`))) */;

/*View structure for view vw_schedules */

/*!50001 DROP TABLE IF EXISTS `vw_schedules` */;
/*!50001 DROP VIEW IF EXISTS `vw_schedules` */;

/*!50001 CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `vw_schedules` AS select `sch`.`schedule_id` AS `schedule_id`,`st`.`stud_number` AS `stud_number`,`st`.`fname` AS `fname`,`st`.`mname` AS `mname`,`st`.`lname` AS `lname`,`c`.`course_code` AS `course_code`,`c`.`course_name` AS `course_name`,`st`.`year_level` AS `year_level`,`st`.`section` AS `section`,`subj`.`subject_code` AS `subject_code`,`subj`.`subject_name` AS `subject_name`,`sch`.`day_of_week` AS `day_of_week`,`sch`.`time_start` AS `time_start`,`sch`.`time_end` AS `time_end`,`sch`.`room` AS `room`,concat(`f`.`fname`,' ',`f`.`mname`,' ',`f`.`fname`) AS `faculty_name`,`sch`.`isdeleted` AS `isdeleted` from ((((`tbl_schedule` `sch` left join `tbl_student` `st` on((`sch`.`student_no` = `st`.`student_id`))) left join `tbl_course` `c` on((`st`.`course_no` = `c`.`course_id`))) left join `tbl_subject` `subj` on((`sch`.`subject_no` = `subj`.`subject_id`))) left join `tbl_faculty` `f` on((`sch`.`faculty_no` = `f`.`faculty_id`))) */;

/*View structure for view vw_students */

/*!50001 DROP TABLE IF EXISTS `vw_students` */;
/*!50001 DROP VIEW IF EXISTS `vw_students` */;

/*!50001 CREATE ALGORITHM=UNDEFINED SQL SECURITY DEFINER VIEW `vw_students` AS select `s`.`student_id` AS `student_id`,`s`.`stud_number` AS `stud_number`,`s`.`rfid_card` AS `rfid_card`,`s`.`fname` AS `fname`,`s`.`mname` AS `mname`,`s`.`lname` AS `lname`,`c`.`course_code` AS `course_code`,`c`.`course_name` AS `course_name`,`s`.`year_level` AS `year_level`,`s`.`section` AS `section`,`s`.`isactive` AS `isactive`,`s`.`isdeleted` AS `isdeleted`,`s`.`created_at` AS `created_at`,`s`.`img_path` AS `img_path` from (`tbl_student` `s` left join `tbl_course` `c` on((`s`.`course_no` = `c`.`course_id`))) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
