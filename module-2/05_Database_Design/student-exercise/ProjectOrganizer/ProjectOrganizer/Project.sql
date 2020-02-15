USE master
GO
--Delete the db if it already exists
DROP DATABASE IF EXISTS ProjectOrganizer

--create a new database
CREATE Database ProjectOrganizer;
--Change to the new DB
USE ProjectOrganizer;

Go
CREATE TABLE Employee
(
	[EmployeeNumber] INT NOT NULL PRIMARY KEY Identity, 
    [JobTitle] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Gender] CHAR NOT NULL, 
    [DateOfBirth] NVARCHAR(10) NOT NULL, 
    [DateOfHire] NVARCHAR(10) NOT NULL, 
    [EmployeeDepartmentName] NVARCHAR(50) NULL
	)

CREATE TABLE Project
(
	[ProjectNumber] INT NOT NULL PRIMARY KEY Identity, 
    [ProjectName] NVARCHAR(50) NOT NULL, 
    [ProjectStartDate] NVARCHAR(10) NOT NULL, 
    [NumberOfEmployees] INT NULL, 
    [EmployeeDepartmentName] NVarCHAR(50) NOT NULL, 
	[EmployeeNumber] INT NOT NULL
	Constraint fk_Employee_Department foreign key (EmployeeNumber) references Employee(EmployeeNumber)
)


CREATE TABLE Department
(
	[DepartmentNumber] INT NOT NULL PRIMARY KEY Identity, 
    [DepartmentName] NVARCHAR(50) NOT NULL, 
    [NumberOfEmployees] INT NOT NULL,
	[EmployeeNumber]INT NOT NULL
	Constraint fk_Employee_Department1 foreign key (EmployeeNumber) references Employee(EmployeeNumber)
)


