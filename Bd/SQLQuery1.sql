CREATE DATABASE tarea1

Use tarea1


CREATE TABLE Ingreso(
Usuario varchar(150), 
contraseña varchar(150),
rol varchar(150)
)

INSERT INTO Ingreso VALUES('Melvin','1234A','Secretario')
INSERT INTO Ingreso VALUES('Anthony','1234B','Administrador')
INSERT INTO Ingreso VALUES('Henrry','1234C','cliente')

SELECT *FROM Ingreso

DROP DATABASE tarea1

