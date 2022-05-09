CREATE DATABASE HighSchool
Go

USE HighSchool
Go

CREATE TABLE LoginFunction
(
	username char(30) PRIMARY KEY,
	pass char(30)
)
GO

CREATE TABLE TimeTable
(
	Class char(10) PRIMARY KEY,
	SchoolYear datetime
)
CREATE TABLE Teacher
(
	IdTeacher INT PRIMARY KEY,
	NameTeacher nvarchar(30),
	GenderTeacher nvarchar(10),
	BirthdayTeacher date,
	SubjectOfTeacher nvarchar(30),
	PhoneTeacher char(10),
	SalaryTeacher int,
	AddressTeacher nvarchar(30)
)
GO

CREATE TABLE Student
(
	IdStudent INT PRIMARY KEY,
	NameStudent nvarchar(30),
	GenderStudent nvarchar(10),
	BirthdayStudent date,
	Class char(10),
	FolkStudent char(10),
	AddressStudent nvarchar(30)
)
GO

ALTER TABLE Student WITH CHECK ADD FOREIGN KEY (Class) REFERENCES TimeTable(Class)
GO

CREATE TABLE ManageLogin
(
	Id INT PRIMARY KEY,
	username char(30),
	pass char(30),
	IdTeacher int,
	Accession nvarchar(30)
)
GO

ALTER TABLE ManageLogin WITH CHECK ADD FOREIGN KEY (username) REFERENCES LoginFunction(username)
GO
ALTER TABLE ManageLogin WITH CHECK ADD FOREIGN KEY (pass) REFERENCES LoginFunction(pass)
GO
ALTER TABLE ManageLogin WITH CHECK ADD FOREIGN KEY (IdTeacher) REFERENCES Teacher(IdTeacher)
GO

CREATE TABLE Teaching
(
	IdTeaching INT PRIMARY KEY,
	NameTeacher nvarchar(30),
	Class char(10),
	DayToLearn date,
	TimeToLearn int
)
GO

ALTER TABLE Teaching WITH CHECK ADD FOREIGN KEY (NameTeacher) REFERENCES Teacher(NameTeacher)
GO
ALTER TABLE Teaching WITH CHECK ADD FOREIGN KEY (Class) REFERENCES TimeTable(Class)
GO