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

Insert into Employee ( JobTitle, FirstName, LastName, Gender, DateOfBirth, DateOfHire, EmployeeDepartmentName)
Values('Director of Marketing', 'John', 'Phoney', 'M', '1/1/1981', '1/4/2020', 'Marketing'),
('Marketing Assistant', 'Jaclyn', 'Jones', 'F', '2/14/1975', '1/7/2020', 'Marketing'),
('Human Resources Manager', 'Jennifer', 'Minks', 'F', '3/7/1978', '6/7/1995', 'Human Resources'),
('CEO', 'Tim', 'Carpet', 'M', '6/14/79', '5/6/95', 'Management'),
('IT Director', 'Dane', 'Cook', 'M', '7/7/77', '1/7/2019', 'Technology')

Insert into Employee(JobTitle, FirstName, LastName, Gender, DateOfBirth, DateOfHire, EmployeeDepartmentName)
Values ('Junior Developer', 'Rachel','F',  'Juch', '12/14/83', '4/17/2020', 'Technology'),
('Senior Developer', 'Daniel', 'Fries', 'M',  '11/14/79', '3/25/2019', 'Technology'), 
('Vice President', 'Michael', 'Minks', 'M', '4/1/1977', '10/11/1999', 'Management'),
('CFO', 'Kevin', 'Stark', '5/5/1965', 'M', '10/10/2010', 'Management')

Insert into Project(ProjectName, ProjectStartDate, NumberOfEmployees, EmployeeDepartmentName, EmployeeNumber)
(
	






   


