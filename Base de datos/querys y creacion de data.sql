
--Creación de base de datos.
CREATE DATABASE dbpruebaafp

USE dbpruebaafp;

CREATE TABLE Empresa(
	IDEmpresa INT IDENTITY(1,1),
	Nombre VARCHAR(255) NOT NULL,
	RazonSocial VARCHAR(255) NOT NULL,
	FechaRegistro DATETIME
	PRIMARY KEY(IDEmpresa)
);

CREATE TABLE Departamento(
	IDDepartamento INT IDENTITY(1,1),
	Nombres VARCHAR(255) NOT NULL,
	NumeroEmpleados INT NOT NULL,
	NivelOrganizacion VARCHAR(255),
	IDEmpresa INT NOT NULL
	PRIMARY KEY(IDDepartamento)
	FOREIGN KEY (IDEmpresa)
		REFERENCES Empresa
);

-- Insert de data a Empresa
INSERT INTO Empresa VALUES('Empresa 1','Razon social empresa 1','19900101')
INSERT INTO Empresa VALUES('Empresa 2','Razon social empresa 2','19910101')
INSERT INTO Empresa VALUES('Empresa 3','Razon social empresa 3','19920101')
INSERT INTO Empresa VALUES('Empresa 4','Razon social empresa 4','19930101')
INSERT INTO Empresa VALUES('Empresa 5','Razon social empresa 5','19940101')
INSERT INTO Empresa VALUES('Empresa 6','Razon social empresa 6','19950101')
INSERT INTO Empresa VALUES('Empresa 7','Razon social empresa 7','19960101')
INSERT INTO Empresa VALUES('Empresa 8','Razon social empresa 8','19970101')
INSERT INTO Empresa VALUES('Empresa 9','Razon social empresa 9','19980101')
INSERT INTO Empresa VALUES('Empresa 10','Razon social empresa 10','19990101')

-- Insert de data a Departamento
INSERT INTO Departamento VALUES('Ventas',20,'Nivel Ventas',1)
INSERT INTO Departamento VALUES('Ventas de tecnología',50,'Nivel Ventas de tecnología',2)
INSERT INTO Departamento VALUES('Gerencia de sistemas',30,'Nivel Gerencia de sistemas',2)
INSERT INTO Departamento VALUES('Gerencia de tecnologia',30,'Nivel Gerencia de tecnologia',2)
INSERT INTO Departamento VALUES('Power BI',30,'Nivel Power BI',2)
INSERT INTO Departamento VALUES('Taller',100,'Nivel Taller',3)
INSERT INTO Departamento VALUES('Accesorios',25,'Nivel Accesorios',4)
INSERT INTO Departamento VALUES('IT',25,'Nivel IT',5)
INSERT INTO Departamento VALUES('Infraestructura',5,'Nivel Infraestructura',6)
INSERT INTO Departamento VALUES('Servidores',2,'Nivel Servidores',7)
INSERT INTO Departamento VALUES('SeguridadInformatica',3,'Nivel SeguridadInformatica',8)

-- Pruebas para sp's
BEGIN TRAN
	EXEC InfoBasicaEmpresa
	@IdConsultar = 1
ROLLBACK

BEGIN TRAN
	EXEC DepartamentosPorEmpresa
	@IdConsultar = 2
ROLLBACK

BEGIN TRAN
	EXEC DepartamentosEmpresa
ROLLBACK

SELECT * FROM Empresa
SELECT * FROM Departamento
