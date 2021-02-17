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

CREATE TABLE department (

	department_id	 integer identity(100,1)  NOT NULL,
	name			 varchar(40)			  NOT NULL,

	CONSTRAINT pk_department_department_id PRIMARY KEY (department_id),
);

CREATE TABLE employee (

	employee_id integer identity(1,1) NOT NULL,
	first_name varchar(20) NOT NULL,
	last_name varchar(30) NOT NULL,
	job_title varchar(50) NOT NULL,
	birth_date datetime NOT NULL,
	gender char(1) NOT NULL,
	hire_date date NOT NULL,
	department_id integer,

	CONSTRAINT pk_employee_employee_id PRIMARY KEY (employee_id),
	CONSTRAINT fk_department FOREIGN KEY (department_id) REFERENCES department(department_id),
);

CREATE TABLE project (
	project_id integer identity(1,1)  NOT NULL,
	name varchar(40) NOT NULL,
	from_date date NOT NULL,
	to_date date NOT NULL,
	CONSTRAINT pk_project_project_id PRIMARY KEY (project_id),
);

CREATE TABLE project_employee (	
	project_id integer,
	employee_id integer,
	
	CONSTRAINT fk_employee FOREIGN KEY (employee_id) REFERENCES employee(employee_id),
	CONSTRAINT fk_project FOREIGN KEY (project_id) REFERENCES project(project_id)
);

COMMIT TRANSACTION;