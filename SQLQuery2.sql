
CREATE DATABASE PRO2;
 CREATE TABLE LIBROS
 (
	ID int  primary key identity(1,1),
	ISBN int  unique not null,
	TITULO varchar(45) not null,
	NUMERODEEDICION int not null,
	NOMBREAUTORES varchar (75) not null,
	PAISPUBLICACION varchar (30) not null,
	SINOPSIS text,
	CARRERA varchar(45) not null,
	MATERIA varchar(35) NOT NULL,
	ANIOPUBLICACION INT NOT NULL
);
SELECT * FROM LIBROS;

 