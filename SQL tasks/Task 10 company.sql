--create file
--now we use that database
USE CompanyDB;
GO
--create department table
CREATE TABLE department(

Name varchar(50) NOT NULL,
Dep_no int PRIMARY KEY,
Num_Of_Employees int ,
Manager_ssn CHAR(11) ,
manager_start_date date


);
--create employee table
CREATE TABLE Employee(

Ssn CHAR(11) PRIMARY KEY,
Fname varchar(50) NOT NULL,
Minit varchar(50) ,
Lname varchar(50) NOT NULL,
Employee_Address varchar(50),
Sex varchar(50) NOT NULL,
Bdate date,
Salary decimal(10,2) Check (Salary >0),
Dep_no int NOT NULL,
Supervisor_snn CHAR(11)

);
--WE ADD Manager_ssn as a fk
ALTER TABLE department
ADD CONSTRAINT Dep_manger_snn
FOREIGN KEY(Manager_ssn)
REFERENCES Employee(Ssn);
--add dep_no as fk  in employees table
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

Pname varchar(50) NOT NULL,
Pnumber int NOT NULL,
Plocation varchar(50) NOT NULL,
PRIMARY KEY (Pnumber,Plocation),
dep_no int NOT NULL,
Constraint dep_number
FOREIGN KEY (dep_no)
REFERENCES department(dep_no)

);

create table Works_on(
E_ssn CHAR(11) NOT NULL,
Project_no int NOT NULL,
PHours decimal(10,2) ,
PRIMARY KEY (E_ssn,Project_no ),
CONSTRAINT E_ssn_work
FOREIGN KEY (E_ssn)
REFERENCES Employee(Ssn),
CONSTRAINT P_no_work
FOREIGN KEY (Project_no)
REFERENCES Project(Pnumber)

);
CREATE TABLE Employees_Dependent(

Essn CHAR(11) NOT NULL,
Dname varchar(50) NOT NULL,
Sex varchar(50) NOT NULL,
Bdate date,
Relationship varchar(50) NOT NULL,
Primary key(Essn,Dname),
Constraint Essn_check
FOREIGN KEY (Essn)
REFERENCES Employee(Ssn)
on delete cascade --baiscally delets all info of dependant once employee ssn gets removed

);