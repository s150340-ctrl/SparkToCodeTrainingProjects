--create file
--now we use that database
USE CompanyDB;
GO

--create department table
CREATE TABLE department(
Name varchar(50) NOT NULL UNIQUE,
Dep_no int PRIMARY KEY,
Num_Of_Employees int DEFAULT 0,
Manager_ssn CHAR(11),
manager_start_date date
);

--create employee table
CREATE TABLE Employee(
Ssn CHAR(11) PRIMARY KEY,
Fname varchar(50) NOT NULL,
Minit CHAR(1),
Lname varchar(50) NOT NULL,
Employee_Address varchar(50),
Sex CHAR(1) NOT NULL CHECK (Sex IN ('M', 'F')),
Bdate date,
Salary decimal(10,2) CHECK (Salary > 0),
Dep_no int NOT NULL,
Supervisor_snn CHAR(11)
);

--WE ADD Manager_ssn as a fk
ALTER TABLE department
ADD CONSTRAINT Dep_manger_snn
FOREIGN KEY(Manager_ssn)
REFERENCES Employee(Ssn);

--add dep_no as fk in employees table
ALTER TABLE Employee
ADD CONSTRAINT Dep_no_check
FOREIGN KEY(Dep_no)
REFERENCES department(Dep_no);

--add another one to employees table
ALTER TABLE Employee
ADD CONSTRAINT supervise_ssn
FOREIGN KEY(Supervisor_snn)
REFERENCES Employee(Ssn);

--create location table
CREATE TABLE department_locations(
dep_no int NOT NULL,
DLocation varchar(50) NOT NULL,
PRIMARY KEY (dep_no, DLocation),
CONSTRAINT dep_and_loc
FOREIGN KEY (dep_no)
REFERENCES department(dep_no)
);

--entity project
CREATE TABLE Project(
Pname varchar(50) NOT NULL UNIQUE,
Pnumber int PRIMARY KEY,
Plocation varchar(50) NOT NULL,
dep_no int NOT NULL,
Constraint dep_number
FOREIGN KEY (dep_no)
REFERENCES department(dep_no)
);

--create works_on table
CREATE TABLE Works_on(
E_ssn CHAR(11) NOT NULL,
Project_no int NOT NULL,
PHours decimal(10,2) CHECK (PHours >= 0),
PRIMARY KEY (E_ssn, Project_no),
CONSTRAINT E_ssn_work
FOREIGN KEY (E_ssn)
REFERENCES Employee(Ssn),
CONSTRAINT P_no_work
FOREIGN KEY (Project_no)
REFERENCES Project(Pnumber)
);

--create dependent table
CREATE TABLE Employees_Dependent(
Essn CHAR(11) NOT NULL,
Dname varchar(50) NOT NULL,
Sex CHAR(1) NOT NULL CHECK (Sex IN ('M', 'F')),
Bdate date,
Relationship varchar(50) NOT NULL,
Primary key(Essn, Dname),
Constraint Essn_check
FOREIGN KEY (Essn)
REFERENCES Employee(Ssn)
ON DELETE CASCADE --baiscally delets all info of dependant once employee ssn gets removed
);

--part 3 CRUD operations
INSERT INTO department(Dep_no,Name)
values(3,'Computer');
INSERT INTO department(Dep_no,Name)
values(1,'Science');
INSERT INTO department(Dep_no,Name)
values(2,'Math');
INSERT INTO Employee(Ssn,Fname, Lname,Sex, Salary,Dep_no)
values('11111111111','Sarah','Al-Hosni','f',1000,3);
INSERT INTO Employee(Ssn,Fname, Lname,Sex, Salary,Dep_no,Supervisor_snn)
values('12345678910','Reem','Al-Hosni','f',10000.34,2,'11111111111');
INSERT INTO Employee(Ssn,Fname, Lname,Sex, Salary,Dep_no,Supervisor_snn)
values('22222211111','Mariyam','Al-Hosni','f',2345,2,'11111111111');
INSERT INTO Employee(Ssn,Fname,Minit, Lname,Sex, Salary,Dep_no,Supervisor_snn)
values('22222222222','Abdullah','T','Al-Hosni','m',2.5,1,'12345678910');
INSERT INTO department(Dep_no,Name,Manager_ssn,manager_start_date)
values(4,'English','11111111111', '01-11-2020');
INSERT INTO Employees_Dependent (Essn, Dname, Sex, Bdate, Relationship)
VALUES ('11111111111', 'Tommy', 'M', '2015-08-10', 'Son');
INSERT INTO Employees_Dependent (Essn, Dname, Sex, Bdate, Relationship)
values('22222222222' , 'Ahmed','m', '11-11-2011','Brother');

--add project
INSERT INTO Project(Pname, dep_no, Plocation, Pnumber)
Values('Adding 1+1', 2, 'China',300);


--add someone to work on project
INSERT INTO Works_on(E_ssn, Project_no, PHours)
values('12345678910',300,200)
INSERT INTO Works_on(E_ssn, Project_no, PHours)
values('22222211111',300,24)
--give emplyee reem a raise for working for 200 hours
UPDATE Employee SET Salary = Salary + 999999.1 WHERE Ssn='12345678910';
UPDATE  Employee SET Employee_Address ='MUSCAT' WHERE Sex='f';
--change employee to another dep
UPDATE Employee SET Dep_no=4 WHERE Fname='Abdullah';
UPDATE Employees_Dependent SET Relationship='co-worker' WHERE Essn='11111111111';
UPDATE Project SET Plocation='America';
UPDATE Works_on SET PHours =5;


--DELETE abdullah to see what happens to his dependent
DELETE FROM Employee WHERE Fname='Abdullah';
--delete mariyam to see what happens to her work
DELETE FROM Works_on WHERE E_ssn='22222211111';
--then we delete her safley from the employees
DELETE FROM Employee WHERE Ssn='22222211111';
-- i shouldved added delete on cascade to the ssn on work_on for automatic clean up 
--at least i know the diffrences now between deleting immediatly the whol data and manually removing it step by step so no error shows


