create database company 
use company
create table Employee(
Ssn  int primary key identity (1,1),
Fname nvarchar (20) not null,
Minit nvarchar (1) ,
Lname nvarchar(20)not null ,
Bdate DATE ,
Address nvarchar(100),
Sex BIT DEFAULT 0,
Salary int constraint ck_employee_salary
check (Salary between 500 and 3500 ),
Super_ssn int ,
Dno int ,
constraint fk_employee_super 
foreign key (Super_ssn)
references Employee(Ssn))

select * from Employee

create table Department (
Dname nvarchar (20)not null ,
Dnumber int primary key identity(1,1),
Mgr_ssn int,
mgr_start_date DATE 
)

create table Dept_Locations 
(
Dnumber int ,
Dlocation nvarchar(30),
constraint pk_Dept_Locations primary key (Dnumber,Dlocation)
)

create table project (
Pname nvarchar (30) not null ,
Pnumber int primary key identity(1,1),
Plocation nvarchar(30),
Dnum int 
)

create table Works_on (
Essn int,
Pno int,
Hours decimal (4,1),
constraint pk_Works_on primary key (Essn,Pno )
)

CREATE TABLE Dependent
(
Essn int,
Dependent_name NVARCHAR(30),
Sex BIT DEFAULT 0,
Bdate DATE,
Relationship NVARCHAR(20),

    CONSTRAINT PK_Dependent
        PRIMARY KEY (Essn, Dependent_name)
)

ALTER TABLE Employee
ADD CONSTRAINT FK_Employee_Department
FOREIGN KEY (Dno)
REFERENCES Department(Dnumber);


ALTER TABLE Department
ADD CONSTRAINT FK_Department_Manager
FOREIGN KEY (Mgr_ssn)
REFERENCES Employee(Ssn);

ALTER TABLE Dept_Locations
ADD CONSTRAINT FK_DeptLocations_Department
FOREIGN KEY (Dnumber)
REFERENCES Department(Dnumber);

ALTER TABLE Project
ADD CONSTRAINT FK_Project_Department
FOREIGN KEY (Dnum)
REFERENCES Department(Dnumber);

ALTER TABLE Works_On
ADD CONSTRAINT FK_WorksOn_Employee
FOREIGN KEY (Essn)
REFERENCES Employee(Ssn);

ALTER TABLE Works_On
ADD CONSTRAINT FK_WorksOn_Project
FOREIGN KEY (Pno)
REFERENCES Project(Pnumber);

ALTER TABLE Dependent
ADD CONSTRAINT FK_Dependent_Employee
FOREIGN KEY (Essn)
REFERENCES Employee(Ssn);

SELECT * FROM INFORMATION_SCHEMA.TABLES;

INSERT INTO Employee (Fname, Lname, Bdate, Sex, Salary)
VALUES
('Karim', 'Salah', '2001-10-11', 1, 2300),
('Ali', 'Ahmed', '2000-05-15', 1, 3400),
('Shahad', 'Ali', '2002-03-20', 0, 2500);

INSERT INTO Department (Dname, Mgr_start_date)
VALUES
('HR', '2024-01-01'),
('IT', '2024-02-01');

UPDATE Department
SET Mgr_ssn = 1
WHERE Dnumber = 1;

UPDATE Department
SET Mgr_ssn = 2
WHERE Dnumber = 2;

SELECT * FROM Employee;

UPDATE Employee
SET Salary = 3000
WHERE Ssn = 1;