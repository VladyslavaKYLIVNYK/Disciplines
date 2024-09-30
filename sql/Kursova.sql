use Kursova


Create table Kafedra(
Kafedra_id int Identity PRIMARY KEY,
Kafedra_name varchar(100),
Kafedra_description varchar(200),
)

Create table Teacher(
Teacher_id int Identity PRIMARY KEY,
Teacher_name varchar(100),
Teacher_surname varchar(100),
Teacher_patronymic varchar(100),
Teacher_adresse varchar(100)
)

Create table Discipline(
Disciplines_id int Identity PRIMARY KEY,
Disciplines_name varchar(200),
Disciplines_description varchar(200),
Kafedra_id INT FOREIGN KEY (Kafedra_id) REFERENCES Kafedra (Kafedra_id),
Teacher_id INT FOREIGN KEY (Teacher_id) REFERENCES Teacher (Teacher_id)
)
ALTER TABLE Discipline
ADD Kafedra_name VARCHAR(255);

ALTER TABLE Discipline
ADD Kafedra_description VARCHAR(255);

ALTER TABLE Discipline
ADD Teacher_pib VARCHAR(255);


Create table Student(
Student_id int Identity PRIMARY KEY,
Disciplines_id int FOREIGN KEY (Disciplines_id) REFERENCES Discipline(Disciplines_id),
Student_name varchar(100),
Student_surname varchar(100),
Student_patronymic varchar(100),
Student_kurs int,
Student_adresse varchar(100),
Student_telefon varchar(100)
)

create table Administrator(
Administrator_id int,
Administrator_name varchar(100),
Administrator_surname varchar(100)
)

Create table Report(
Report_id int Identity PRIMARY KEY,
Report_description varchar(200),
Student_id int FOREIGN KEY (Student_id) REFERENCES Student(Student_id),
Disciplines_id int FOREIGN KEY (Disciplines_id) REFERENCES Discipline(Disciplines_id)
)

--ALTER TABLE Report
--ADD Student_pib VARCHAR(255);

DROP TABLE Person

select*from Discipline
select*from Teacher
select*from Report

