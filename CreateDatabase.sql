
CREATE TABLE `item` (
  `ItemGID` varchar(100) NOT NULL,
  PRIMARY KEY (`ItemGID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8



CREATE TABLE `item_detail` (
  `GUID` varchar(100) NOT NULL,
  `ItemGID` varchar(100) NOT NULL,
  PRIMARY KEY (`GUID`),
  KEY `ItemGID` (`ItemGID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8

