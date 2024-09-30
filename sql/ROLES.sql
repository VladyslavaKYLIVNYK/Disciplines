use kursova

CREATE TABLE USERS(
id_users int identity primary key,
username varchar(50),
password varchar(50),
id_role int foreign key references ROLES(id_role)
)
insert into USERS (username, password) values(
'student','student'),
('teacher','teacher')

