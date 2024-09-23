/*1.- Disparador BIBILIOTECA
Necesitamos crear un trigger para cuando demos de baja un Socio en la biblioteca.
Deberemos comprobar si éste tiene algún libro sin devolver (fecha devolución nula), en caso
de ser así, que inserte un registro en la tabla LIBROS_PERDIDOS (ISBN, DNI, nombre,
fechaBaja), donde el campo fechaBaja corresponde con la fecha del sistema que tenga en
ese momento el ordenador.
TABLAS NECESARIAS
LIBROS (ISBN, título, precio)
PK: ISBN
SOCIOS (DNI, nombre, ciudad)
PK: DNI
PRESTAMOS (idPrestamo, ISBN, DNI, FechaPrestamo, FechaDevol)
PK: idPrestamo
FK: ISBN → LIBROS
FK: DNI → SOCIOS
*/
CREATE DATABASE BIBLIOTECA
GO
USE BIBLIOTECA
GO
CREATE TABLE LIBROS (
ISBN		CHAR(13),
Titulo		VARCHAR(100) NOT NULL,
Precio		DECIMAL(6,2) NOT NULL

CONSTRAINT PK_LIBROS PRIMARY KEY (ISBN)
)
GO
CREATE TABLE SOCIOS(
DNI			CHAR(9),
Nombre		VARCHAR(100) NOT NULL,
Ciudad		VARCHAR(100) NOT NULL

CONSTRAINT PK_SOCIOS PRIMARY KEY (DNI)
)
GO
CREATE TABLE PRESTAMOS(
idPrestamo		INT IDENTITY,
ISBN			CHAR(13) NOT NULL,
DNI				CHAR(9) NOT NULL,
FechaPrestamo	DATE NOT NULL,
FechaDevol		DATE 

CONSTRAINT PK_PRESTAMOS PRIMARY KEY (idPrestamo),
CONSTRAINT FK_PRESTAMOS_LIBROS FOREIGN KEY (ISBN) REFERENCES LIBROS (ISBN),
CONSTRAINT FK_PRESTAMOS_SOCIOS FOREIGN KEY (DNI) REFERENCES SOCIOS (DNI)
)
GO
CREATE TABLE LIBROS_PERDIDOS(
ISBN		CHAR(13) NOT NULL,
DNI			CHAR(9) NOT NULL,
Nombre		VARCHAR(100) NOT NULL,
fechaBaja	DATE NOT NULL
)
-- Insertar datos en la tabla LIBROS
INSERT INTO LIBROS (ISBN, Titulo, Precio)
VALUES 
    ('9780061123456', 'The Hobbit', 14.99),
    ('9780451524935', 'Pride and Prejudice', 8.50),
    ('9780141439587', 'Jane Eyre', 11.25),
    ('9780743273565', 'Moby-Dick', 9.75),
    ('9780064400012', 'Little Women', 10.99)
GO
-- Insertar datos en la tabla SOCIOS
INSERT INTO SOCIOS (DNI, Nombre, Ciudad)
VALUES 
    ('11122233A', 'Emily', 'Seattle'),
    ('44455566B', 'David', 'Boston'),
    ('77788899C', 'Sophia', 'San Francisco'),
    ('22233344D', 'James', 'Washington, D.C.')
GO
-- Insertar datos en la tabla PRESTAMOS
INSERT INTO PRESTAMOS (ISBN, DNI, FechaPrestamo, FechaDevol)
VALUES 
    ('9780061123456', '11122233A', '2024-04-02', '2024-04-17'),
    ('9780451524935', '44455566B', '2024-04-07', NULL),
    ('9780141439587', '77788899C', '2024-04-12', NULL),
    ('9780743273565', '22233344D', '2024-04-17', '2024-05-02'),
    ('9780064400012', '11122233A', '2024-04-22', NULL)
------------------------------------------------------
----------------------------------------------------------------
GO
CREATE OR ALTER TRIGGER TX_BajaSocio ON SOCIOS
INSTEAD OF DELETE
AS
BEGIN

	INSERT INTO LIBROS_PERDIDOS (ISBN, DNI, Nombre, fechaBaja)
	SELECT p.ISBN, s.DNI, s.Nombre, GETDATE() as fechaBaja
		FROM PRESTAMOS p, 
				SOCIOS s
		WHERE p.DNI = s.DNI
		AND p.DNI IN (SELECT DNI FROM deleted)
		AND p.fechaDevol IS NULL
	
END

---------------------------------------------------
------------------------------------
DELETE FROM SOCIOS
WHERE DNI = '44455566B'

SELECT *
	FROM LIBROS_PERDIDOS

SELECT *
	FROM SOCIOS
/*
2.- Disparador SERVICIO TECNICO
Crear un disparador para que cuando demos de baja un Técnico se compruebe si la suma
del importe de las reparaciones de este técnico es mayor que 2500 €, y si lo cumple,
guardaremos sus datos personales en una tabla llamada TECNICOS_RESERVA con la
misma estructura que la tabla TECNICOS más un campo FechaBaja (con la fecha en la que
se realiza la baja, que será la fecha del sistema).
TABLAS NECESARIAS
TECNICOS (DNI, nombre, ciudad, salario)
PK: DNI
REPARACIONES (idReparacion, fecha, DNI_tecnico, concepto, importe)
PK: idReparacion
FK: DNI_tecnico → TECNICOS
*/
CREATE DATABASE SERVICIO_TECNICO
GO
USE SERVICIO_TECNICO
GO
CREATE TABLE TECNICOS (
DNI				CHAR(9),
Nombre			VARCHAR(100) NOT NULL,
Ciudad			VARCHAR(100) NOT NULL,
Salario			VARCHAR(100) NOT NULL

CONSTRAINT PK_TECNICOS PRIMARY KEY (DNI)
)
GO
CREATE TABLE REPARACIONES(
idReparacion	INT,
fecha			DATE NOT NULL,
DNI_tecnico		CHAR(9) NOT NULL,
concepto		VARCHAR(100) NOT NULL,
importe			DECIMAL(7,2) NOT NULL

CONSTRAINT PK_REPARACIONES PRIMARY KEY (idReparacion),
CONSTRAINT FK_REPARACIONES_TECNICOS FOREIGN KEY (DNI_tecnico) REFERENCES TECNICOS (DNI)
)


-- Insertar datos en la tabla TECNICOS
INSERT INTO TECNICOS (DNI, Nombre, Ciudad, Salario)
VALUES 
    ('11122233A', 'Carlos González', 'Madrid', '2500.00'),
    ('44455566B', 'Laura Martínez', 'Barcelona', '2800.00'),
    ('77788899C', 'Pedro López', 'Valencia', '3000.00'),
    ('22233344D', 'Ana Ramírez', 'Sevilla', '2700.00'),
    ('55566677E', 'María Rodríguez', 'Málaga', '2600.00')

-- Insertar datos en la tabla REPARACIONES
INSERT INTO REPARACIONES (idReparacion, fecha, DNI_tecnico, concepto, importe)
VALUES 
    (1, '2024-04-01', '11122233A', 'Reemplazo de pantalla', 1150.00),
    (2, '2024-04-05', '44455566B', 'Reparación de placa base', 2600.00),
    (3, '2024-04-10', '77788899C', 'Cambio de batería', 1000.00),
    (4, '2024-04-15', '22233344D', 'Limpieza interna', 800.00),
    (5, '2024-04-20', '55566677E', 'Actualización de Sistema Operativo', 3120.00)


GO
CREATE TABLE TECNICOS_RESERVA(
DNI				CHAR(9),
Nombre			VARCHAR(100) NOT NULL,
Ciudad			VARCHAR(100) NOT NULL,
Salario			VARCHAR(100) NOT NULL,
fechaBaja		DATE NOT NULL

CONSTRAINT PK_TECNICOS_RESERVA PRIMARY KEY (DNI)
)

----------------------------------------------------
----------------------------------------------------------------------
    GO
    CREATE OR ALTER TRIGGER TX_DarBajaTecnico ON TECNICOS
    INSTEAD OF DELETE
        AS
        BEGIN            

					DECLARE @importe DECIMAL(7,2) = 2500

					INSERT INTO TECNICOS_RESERVA (DNI, nombre, ciudad, salario, FechaBaja)
					SELECT DNI, nombre, ciudad, salario, GETDATE()
					FROM deleted
					WHERE DNI IN (SELECT Dni FROM REPARACIONES
									WHERE importe > @importe)

					-- ELIMINAR REPARACIONES --
					DELETE FROM REPARACIONES
					WHERE DNI_tecnico IN (SELECT DNI FROM DELETED)

					-- ELIMINAR TECNICO --
					DELETE FROM TECNICOS
					WHERE DNI IN (SELECT DNI FROM DELETED)
        END

-----------------------------------------------
--------------------------------------
DELETE FROM TECNICOS
WHERE Dni = '11122233A'
/*
3.- Disparador ALMACENES
Crear un disparador para que cuando demos de baja un Proveedor se realice lo siguiente:
- Comprobar si ese proveedor suministra algún artículo cuyo Stock sea igual a 0, y si
es así, que añada a la tabla ARTICULOS_INEXISTENTES esos artículos (la tabla
ARTICULOS_INEXISTENTES tendrá los mismos campos que la tabla ARTICULOS
más la fecha de inserción (fecha del sistema) y el nombre del proveedor que se da
de baja).
TABLAS NECESARIAS
ALMACENES (codAlmacen, descripción, dirección, ciudad)
PK: codAlmacen
PROVEEDORES (codProveedor, nombe, direccion, ciudad, deuda, tipo)
PK: codProveedor
ARTICULOS (codArticulo, nombre, stock, pvp, precio_compra, codAlmacen, codProveedor)
PK: codArticulo
FK: codAlmacen → ALMACENES
FK: codProveedor → PROVEEDORES
*/

CREATE DATABASE ALMACENESBD
GO
USE ALMACENESBD

CREATE TABLE ALMACENES (
    codAlmacen INT,
    descripcion VARCHAR(100),
    direccion VARCHAR(200) NOT NULL,
    ciudad VARCHAR(50) NOT NULL

	CONSTRAINT PK_ALMACENES PRIMARY KEY (codAlmacen)
)

-- Crear tabla PROVEEDORES
CREATE TABLE PROVEEDORES (
    codProveedor INT,
    nombre VARCHAR(100) NOT NULL,
    direccion VARCHAR(200) NOT NULL,
    ciudad VARCHAR(50) NOT NULL,
    deuda DECIMAL(10, 2) NOT NULL,
    tipo VARCHAR(50) NOT NULL

	CONSTRAINT PK_PROVEEDORES PRIMARY KEY (codProveedor)
)

-- Crear tabla ARTICULOS
CREATE TABLE ARTICULOS (
    codArticulo INT,
    nombre VARCHAR(100) NOT NULL,
    stock INT NOT NULL,
    pvp DECIMAL(10, 2),
    precio_compra DECIMAL(10, 2) NOT NULL,
    codAlmacen INT,
    codProveedor INT

	CONSTRAINT PK_ARTICULOS PRIMARY KEY (codArticulo),
	CONSTRAINT FK_ARTICULOS_ALMACENES FOREIGN KEY (codAlmacen) REFERENCES ALMACENES (codAlmacen),
	CONSTRAINT FK_ARTICULOS_PROVEEDORES FOREIGN KEY (codProveedor) REFERENCES PROVEEDORES (codProveedor)
 )   

 CREATE TABLE ARTICULOS_INEXISTENTES (
    codArticulo INT,
    nombre VARCHAR(100) NOT NULL,
    stock INT NOT NULL,
    pvp DECIMAL(10, 2),
    precio_compra DECIMAL(10, 2) NOT NULL,
    codAlmacen INT,
    codProveedor INT,
	fechaInsercion DATE NOT NULL

	CONSTRAINT PK_ARTICULOS_INEXISTENTES PRIMARY KEY (codArticulo)
 )   

-- Insertar datos en la tabla ALMACENES
INSERT INTO ALMACENES (codAlmacen, descripcion, direccion, ciudad) 
VALUES	(1, 'Almacén Principal', 'Calle Libertad 234', 'Buenos Aires'),
		(2, 'Almacén Central', 'Avenida Norte 789', 'Lima'),
		(3, 'Depósito Sur', 'Calle del Sol 567', 'Santiago')

-- Insertar datos en la tabla PROVEEDORES
INSERT INTO PROVEEDORES (codProveedor, nombre, direccion, ciudad, deuda, tipo) 
VALUES	(1, 'Distribuidora García', 'Av. Industrial 123', 'Guadalajara', 5000.00, 'Alimentos'),
		(2, 'Importadora López', 'Calle Mayor 456', 'Bogotá', 0.00, 'Electrónica'),
		(3, 'Suministros Martínez', 'Av. del Progreso 789', 'Santo Domingo', 3000.00, 'Ferretería')

-- Insertar datos en la tabla ARTICULOS
INSERT INTO ARTICULOS (codArticulo, nombre, stock, pvp, precio_compra, codAlmacen, codProveedor) 
VALUES	(1, 'Cámara Digital', 50, 199.99, 150.00, 2, 2),
		(2, 'Lámpara LED', 100, 15.99, 10.00, 1, 3),
		(3, 'Aceite de Oliva', 200, 7.50, 5.00, 1, 1),
		(4, 'Martillo de Carpintero', 0, 12.75, 9.50, 3, 3),
		(5, 'Teclado Inalámbrico', 80, 29.99, 20.00, 2, 1)


--Creacion del Trigger
------------------------------------------------
USE ALMACENESBD
GO
CREATE OR ALTER TRIGGER TX_BajaProveedor ON PROVEEDORES
INSTEAD OF DELETE
AS
BEGIN

			INSERT INTO ARTICULOS_INEXISTENTES (codArticulo, nombre, stock, pvp, precio_compra, codAlmacen, codProveedor, fechaInsercion)
			SELECT codArticulo, nombre, stock, pvp, precio_compra, codAlmacen, codProveedor, GETDATE()
				FROM ARTICULOS
				WHERE codProveedor IN (SELECT codProveedor FROM deleted)
				AND stock = 0


	DELETE FROM ARTICULOS
	WHERE codArticulo = (SELECT codArticulo FROM inserted)

	DELETE FROM PROVEEDORES
	WHERE codProveedor = (SELECT codProveedor FROM deleted)
	
END

---------------------------------------------------------------
--------------------------------------------------------------------------

DELETE FROM PROVEEDORES
WHERE codProveedor = 4

/*
4.- Auditoría de usuarios en la tabla CLIENTES de la BD JARDINERIA.
Por motivos legales, cada vez que se realiza la actualización de un cliente en la tabla
CLIENTES queremos que se almacenen todos sus datos en la tabla
CLIENTES_HISTORICO (tendrá la misma estructura que la tabla CLIENTES más un campo
con la fecha en la que se realiza la modificación).
NOTA: La fechaModificacion deberá formar parte de la PK de la tabla para permitir que
puedan realizarse varias actualizaciones de un mismo Cliente.*/
USE JARDINERIA
GO
CREATE TABLE CLIENTES_HISTORICOS(
codCliente			INT NOT NULL,
nombre_cliente		VARCHAR(50) NOT NULL,
nombre_contacto		VARCHAR(50) NOT NULL,
apellido_contacto	VARCHAR(50) NOT NULL,
telefono			VARCHAR(15) NOT NULL,
email				VARCHAR(100) NOT NULL,
linea_direccion1	VARCHAR(100) NOT NULL,
linea_direccion2	VARCHAR(100) NOT NULL,
ciudad				VARCHAR(50) NOT NULL,
pais				VARCHAR(50) NOT NULL,
codPostal			CHAR(5) NOT NULL,
codEmpl_ventas		INT NOT NULL,
limite_credito		DECIMAL(9,2) NOT NULL,
fechaModificacion	DATETIME

CONSTRAINT PK_CLIENTES_HISTORICOS PRIMARY KEY (fechaModificacion)
)

---------------------------------------------------------------------------------
---------------------------------------------
GO
CREATE OR ALTER TRIGGER TX_updateClientes ON CLIENTES
AFTER UPDATE 
AS
BEGIN
	INSERT INTO CLIENTES_HISTORICOS (codcliente, nombre_cliente, nombre_contacto, apellido_contacto, telefono, email, linea_direccion1, linea_direccion2, ciudad, pais, codPostal, codEmpl_ventas, limite_credito, fechaModificacion)
    SELECT codcliente, nombre_cliente, nombre_contacto, apellido_contacto, telefono, email, linea_direccion1, linea_direccion2, ciudad, pais, codPostal, codEmpl_ventas, limite_credito, GETDATE()
				FROM deleted


END


----------------------
UPDATE CLIENTES
SET nombre_cliente = 'Nuevo Nombre'
WHERE codCliente = 7

SELECT *
	FROM CLIENTES_HISTORICOS