-- Switch to the system (aka master) database
USE master;
GO

-- Delete the World Database (IF EXISTS)
DROP DATABASE IF EXISTS ProjectOrganizer

-- Create a new World Database
CREATE DATABASE ProjectOrganizer;
GO

-- Switch to the World Database
USE ProjectOrganizer
GO

-- Begin a TRANSACTION that must complete with no errors
BEGIN TRANSACTION;

CREATE TABLE project_organizer_employee
(
--  column      type            constraint if any identity starts a 1 increments by 1
	employee_number		int				identity(1,1),
	job_title			varchar(50)		NOT NULL,
	first_name			varchar(100)	NOT NULL,
	last_name			varchar(100)	NOT NULL,
	gender				varchar(10)		NOT NULL,
	birth_date			datetime		NOT NULL,
	hire_date			datetime		NOT NULL,
	department_name		varchar(20)		NOT NULL,
	--         name         type        column
	CONSTRAINT pk_project_organizer_employee PRIMARY KEY (employee_number),
);

CREATE TABLE department
(
	department_number	int			identity(100,5),
	department_name		varchar(50)	NOT NULL,
	employee_number		int,

	CONSTRAINT pk_department PRIMARY KEY (department_number),
	CONSTRAINT fk_project_organizer_employee FOREIGN KEY (employee_number) REFERENCES project_organizer_employee(employee_number)
);

CREATE TABLE project
(
	project_number		int				identity(500,5),
	project_name		varchar(100)		NOT NULL,
	start_date			datetime			NOT NULL,
	employee_number		int,

	CONSTRAINT pk_project PRIMARY KEY (project_number),
	CONSTRAINT fk_project_organizer_employee FOREIGN KEY (employee_number) REFERENCES project_organizer_employee(employee_number)
);


COMMIT TRANSACTION;