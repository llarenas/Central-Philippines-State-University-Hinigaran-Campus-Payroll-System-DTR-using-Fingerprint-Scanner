-- phpMyAdmin SQL Dump
-- version 2.11.6
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Mar 16, 2015 at 03:47 AM
-- Server version: 5.5.29
-- PHP Version: 5.2.6

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

--
-- Database: `system`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `rate` int(255) NOT NULL,
  `tax` varchar(255) NOT NULL,
  `joborderrate` varchar(255) NOT NULL,
  `parttimerate` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`rate`, `tax`, `joborderrate`, `parttimerate`) VALUES
(110, '.05', '200', '100');

-- --------------------------------------------------------

--
-- Table structure for table `dtr`
--

CREATE TABLE `dtr` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `idnum` varchar(255) DEFAULT NULL,
  `fname` varchar(255) DEFAULT NULL,
  `lname` varchar(255) DEFAULT NULL,
  `appointment` varchar(255) DEFAULT NULL,
  `amin` varchar(255) DEFAULT NULL,
  `amout` varchar(255) DEFAULT NULL,
  `amtotal` varchar(255) DEFAULT NULL,
  `pmin` varchar(255) DEFAULT NULL,
  `pmout` varchar(255) DEFAULT NULL,
  `pmtotal` varchar(255) DEFAULT NULL,
  `alltotal` varchar(255) DEFAULT NULL,
  `gp` varchar(255) DEFAULT NULL,
  `date` varchar(255) DEFAULT NULL,
  `nowday` varchar(255) DEFAULT NULL,
  `nowmonth` varchar(255) DEFAULT NULL,
  `nowyear` varchar(255) DEFAULT NULL,
  `halfmonth` varchar(255) DEFAULT NULL,
  `madeduct` varchar(255) DEFAULT NULL,
  `debit` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Dumping data for table `dtr`
--

INSERT INTO `dtr` (`id`, `idnum`, `fname`, `lname`, `appointment`, `amin`, `amout`, `amtotal`, `pmin`, `pmout`, `pmtotal`, `alltotal`, `gp`, `date`, `nowday`, `nowmonth`, `nowyear`, `halfmonth`, `madeduct`, `debit`) VALUES
(4, '01', 'Reymark', 'Tampos', 'Job_Order', '07:07:14', '12:01:02', '4:0', '12:01:43', '17:02:19', '4:0', '08:00:00', '400', '03-16-2015', '16', '3', '2015', 'b', '20', '380'),
(5, '02', 'Tam', 'Reymark', 'Job_Order', '07:13:50', '12:00:54', '4:0', '\0', '\0', '0:0', '4:0', '200', '03-16-2015', '16', '3', '2015', 'b', '10', '190'),
(6, '03', 'Part', 'Employee', 'Part_Time', '07:37:40', '09:38:15', '2:0', '12:04:49', '13:07:10', '1:2', '03:02:00', '303.333333333333', '03-16-2015', '16', '3', '2015', 'b', '15.1666666666667', '288.166666666666'),
(7, '04', 'Ronel', 'Llarenas', 'Contractual', '07:26:23', '09:34:27', '2:8', '\0', '\0', '0:0', '02:08:00', '234.666666666666', '03-16-2015', '16', '3', '2015', 'b', '11.7333333333333', '222.933333333333'),
(8, '05', 'Juan', 'Cruz', 'Contractual', '09:39:24', '11:40:11', '2:0', '12:40:50', '18:41:18', '4:0', '06:00:00', '660', '03-16-2015', '16', '3', '2015', 'b', '33', '627'),
(9, '06', 'Christian', 'Llarenas', 'Contractual', '07:46:19', '11:47:17', '4:0', '\0', '\0', '0:0', '04:00:00', '440', '03-16-2015', '16', '3', '2015', 'b', '22', '418');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `idnum` varchar(255) NOT NULL,
  `fname` varchar(255) NOT NULL,
  `mname` varchar(255) NOT NULL,
  `lname` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  `appointment` varchar(255) NOT NULL,
  `birthday` varchar(255) NOT NULL,
  `address` varchar(255) NOT NULL,
  `gender` varchar(255) NOT NULL,
  `veri` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=35 ;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `idnum`, `fname`, `mname`, `lname`, `status`, `appointment`, `birthday`, `address`, `gender`, `veri`) VALUES
(28, '01', 'Reymark', 'Tampos', 'Tampos', 'Single', 'Job_Order', '01-05-1999', 'Hinigaran', 'Male', 'veri'),
(29, '02', 'Tam', 'Pos', 'Reymark', 'Married', 'Job_Order', '25-12-2000', 'Kabankalan', 'Male', 'veri'),
(30, '03', 'Part', 'Time', 'Employee', 'Single', 'Part_Time', '14-09-1992', 'Negros Occidental', 'Male', 'veri'),
(31, '04', 'Ronel', 'Bugarin', 'Llarenas', 'Single', 'Contractual', '14-09-1992', 'Hinigaran', 'Male', 'veri'),
(33, '05', 'Juan', 'De La', 'Cruz', 'Single', 'Contractual', '22-06-2009', 'Philippines', 'Male', 'veri'),
(34, '06', 'Christian', 'Bugarin', 'Llarenas', 'Single', 'Contractual', '23-11-1997', 'Hinigaran', 'Male', 'veri');
