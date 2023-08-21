create database HECPortal

use [HECPortal]

CREATE TABLE UserInfo
(
  UserId INT IDENTITY(1,1) NOT NULL,
  FullName VARCHAR(50) NOT NULL,
  Email VARCHAR(50) NOT NULL,
  UserPass VARCHAR(50) NOT NULL,
  Gender VARCHAR(50),
  Phone VARCHAR(11),
  Picture VARBINARY (MAX),
  PRIMARY KEY (UserId),
  UNIQUE (Email),
  UNIQUE (Phone)
);

CREATE TABLE Family
(
  FamilyId INT IDENTITY(1,1) NOT NULL,
  FatherName VARCHAR(50) NOT NULL,
  MotherName VARCHAR(50) NOT NULL,
  Siblings VARCHAR(50) NOT NULL,
  FamilyAddress VARCHAR(100) NOT NULL,
  City VARCHAR(50) NOT NULL,
  Province VARCHAR(50) NOT NULL,
  GrossIncome VARCHAR(50) NOT NULL,
  JobType VARCHAR(50) NOT NULL,
  PRIMARY KEY (FamilyId),
  UserId INT NOT NULL,
  FOREIGN KEY (UserId) REFERENCES UserInfo(UserId)
);

CREATE TABLE Education
(
   EducationId INT IDENTITY(1,1) NOT NULL,
  EducationLevel VARCHAR(50) NOT NULL,
  Board VARCHAR(50) NOT NULL,
  ObtainedMarks VARCHAR(50) NOT NULL,
  TotalMarks VARCHAR(50) NOT NULL,
  Grade VARCHAR(50) NOT NULL,
  UserId INT NOT NULL,
  PRIMARY KEY (EducationId),
  FOREIGN KEY (UserId) REFERENCES UserInfo(UserId)
);


select * from UserInfo
select * from Family
select * from Education

