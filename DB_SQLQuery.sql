CREATE DATABASE StudentManagement;

---------------------CREATE TABLE-----------------------------------

CREATE TABLE DB_Account(
	A_UserName nvarchar(50) PRIMARY KEY,
	A_Password nvarchar(50)
);

CREATE TABLE Students(
	Student_ID INT NOT NULL IDENTITY(1,1),
	Student_Code NVARCHAR(30),
	Student_Name NVARCHAR(100),
	Student_Class NVARCHAR(10),
	Student_Point FLOAT,
	Student_Comment NVARCHAR(500),
	Student_Status BIT,
	Student_Address NVARCHAR(100),
	Student_Born NVARCHAR(50),
	Student_IdentityCard INT UNIQUE,
	Student_BirthDay DATETIME,
	Student_Parents NVARCHAR(50),
	PRIMARY KEY (Student_Code)
);

CREATE TABLE Class(
	Class_ID NVARCHAR(10) PRIMARY KEY,
	Class_NumberOfStudents INT,
	Class_Teacher NVARCHAR(50),
	Class_Status BIT,
	Class_Comment NVARCHAR(500)
);

CREATE TABLE Category(
	
);
---------------------ALTER---------------------------------------------------
ALTER TABLE Students ADD Student_Image NVARCHAR(250)
--ALTER TABLE Students ADD PRIMARY KEY (Student_Code, Student_IdentityCard);

ALTER TABLE Students ADD CONSTRAINT Student_FK_ID_Class FOREIGN KEY (Student_Class) REFERENCES Class(Class_ID)

DROP TABLE Class
DROP TABLE Students
--DROP TABLE DB_Account
---------------------INSERT DATABASE-----------------------------------

INSERT INTO DB_Account (A_UserName, A_Password) VALUES ( 'dinhythuc', 'dinhythuc10a9'),
( 'hoangvana', 'vana'), ( 'lenguyenb', 'nguyenb'), ( 'libangiac', 'ligiac')

INSERT INTO Students(Student_Code, Student_Name, Student_Class, Student_Point, Student_Comment, Student_Status, Student_Address, Student_Born, Student_IdentityCard, Student_BirthDay, Student_Parents)
VALUES( 'A001T1', N'Đoàn Văn Long', 'CNTT001', 6.8, '', 1, N'Trương Định, Quận 3, TP. Hồ Chí Minh', N'TP. Hồ Chí Minh', 111123111, 1998/12/10, N''),
( 'A001T4', N'Lương Minh Hữu', 'CNTT003', 7.8, '', 1, N'Ngô Tất Tố, Quận Bình Thạnh, TP. Hồ Chí Minh', N'TP. Hồ Chí Minh', 333123121, 1998/01/14, N''),
( 'A001T3', N'Hoàng Lợi', 'CNTT001', 7.3, '', 1, N'Trần Văn Hân, Quận Bình Thạnh, TP. Hồ Chí Minh', N'TP. Vũng Tàu', 333123677, 1998/01/09, N'')

INSERT INTO Class(Class_ID, Class_NumberOfStudents, Class_Teacher, Class_Status, Class_Comment)
VALUES('CNTT001', 150, N'Dương Văn Hoàng', 1, N''),
('CNTT002', 150, N'Lê Trung Nghĩa', 1, N''),
('CNTT003', 150, N'Nguyễn Minh Trung', 1, N''),
('CNTT004', 130, N'Lí Tô Mậu', 1, N'')
---------------------STORED PROCEDURES-----------------------------------

USE [StudentManagement]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Student_Management_Account]
	@SM_UserName varchar(50),
	@SM_Password varchar(50)
AS
BEGIN
	DECLARE @count int
	DECLARE @res bit
	SELECT @count = COUNT(*) FROM DB_Account WHERE A_UserName = @SM_UserName AND A_Password = @SM_Password
	IF @count > 0
		SET @res = 1
	ELSE 
		SET @res = 0
	
	SELECT @res
END

CREATE PROC Students_ListAll
AS
SELECT * FROM Students WHERE Student_Status=1
ORDER BY Student_ID ASC

CREATE PROC Student_Insert
	@StudentCode NVARCHAR(30),
	@StudentName NVARCHAR(100),
	@StudentClass NVARCHAR(10),
	@StudentPoint FLOAT,
	@StudentComment NVARCHAR(500),
	@StudentStatus BIT,
	@StudentAddress NVARCHAR(100),
	@StudentBorn NVARCHAR(50),
	@StudentIdentityCard INT,
	@StudentBirthDay DATETIME,
	@StudentParents NVARCHAR(50),
	@StudentImage NVARCHAR(250)
AS
BEGIN
	INSERT INTO Students(Student_Code, Student_Name, 
						Student_Class, Student_Point, 
						Student_Comment, Student_Status, 
						Student_Address, Student_Born, 
						Student_IdentityCard, Student_BirthDay, 
						Student_Parents, Student_Image)
			VALUES(@StudentCode, @StudentName, 
					@StudentClass, @StudentPoint,
					@StudentComment, @StudentStatus,
					@StudentAddress, @StudentBorn,
					@StudentIdentityCard, @StudentBirthDay,
					@StudentParents, @StudentImage)
END 
GO

