USE JARDINERIA

				---------------------------
				--   UD8  -  PROC & FUNC -- 
				---------------------------
-------------------------------------------------------------------------------------------
-- NOTA: Recuerda cuidar la limpieza del código (tabulaciones, nombres de tablas en mayúscula,
--		nombres de variables en minúscula, poner comentarios sin excederse, código organizado y fácil de seguir, etc.)
-------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------
-- 1. Implementa un procedimiento llamado 'getNombreCliente' que devuelva el nombre de un cliente a partir de su código.
--		Parámetros de entrada:  codCliente INT
--		Parámetros de salida:   nombreCliente VARCHAR(50)
--		Tabla:                  CLIENTES
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--	
--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--      Recuerda utilizar en el script:
--              EXEC @ret = getNombreCliente @codCliente, @nombreCliente OUTPUT
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------
USE JARDINERIA
GO
CREATE OR ALTER PROCEDURE getNombreCliente(@codCliente INT, @nombreCliente VARCHAR(50) OUTPUT)
AS
BEGIN
	BEGIN TRY
		IF @codCliente IS NULL
		BEGIN
			PRINT ('El codigo cliente es obligatorio')
			RETURN -1
		END

		SELECT @nombreCliente = nombre_cliente 
			FROM CLIENTES
			WHERE codCliente = @codCliente

		IF @nombreCliente IS NULL
		BEGIN
			PRINT ('No existe el cliente')
			RETURN -2
		END
	END TRY

	BEGIN CATCH
		PRINT CONCAT('Error: ', ERROR_NUMBER())
	END CATCH
END
---------------------------------------
GO
DECLARE @codigo INT = 9
DECLARE @nombre VARCHAR(50) 
DECLARE @ret INT

EXEC @ret = getNombreCliente @codigo, @nombre OUTPUT

IF @ret <> 0
RETURN

PRINT @nombre


-------------------------------------------------------------------------------------------
-- 2. Implementa un procedimiento llamado 'getPedidosPagosCliente' que devuelva el número de pedidos y de pagos a partir de un código de cliente.
--		Parámetros de entrada:  codCliente INT
--		Parámetros de salida:   numPedidos INT
--                              numPagos INT
--		Tabla:                  CLIENTES
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--	
--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--      Recuerda utilizar en el script:
--              EXEC @ret = getPedidosPagosCliente @codCliente, @numPedidos OUTPUT, @numPagos OUTPUT
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER PROCEDURE getPedidosPagosCliente (@codCliente INT, @numPedidos INT OUTPUT, @numPagos INT OUTPUT)
AS
BEGIN
	BEGIN TRY
		IF @codCliente IS NULL
		BEGIN
			PRINT ('El codigo es obligatorio')
			RETURN -1
		END

		SET @numPedidos = 0
		SET @numPagos = 0

		SELECT @numPedidos = COUNT(codPedido)
			FROM PEDIDOS
			WHERE codCliente = @codCliente

		SELECT @numPagos = COUNT(id_transaccion)
			FROM PAGOS
			WHERE codCliente = @codCliente

	END TRY

	BEGIN CATCH
		PRINT CONCAT('Error: ', ERROR_NUMBER())
	END CATCH
END
--------------------------------
GO
DECLARE @codigo INT = 5
DECLARE @numPedidos INT
DECLARE @numPagos INT
DECLARE @ret INT

EXEC @ret = getPedidosPagosCliente @codigo, @numPedidos OUTPUT, @numPagos OUTPUT

IF @ret <> 0
RETURN

PRINT CONCAT('El cliente ', @codigo, ' ha  realizado ', @numPedidos, ' pedidos y ', @numPagos, ' pagos')
-------------------------------------------------------------------------------------------
-- 3. Implementa un procedimiento llamado 'crearCategoriaProducto' que inserte una nueva categoría de producto en la base de datos JARDINERIA.
--		Parámetros de entrada: codCategoria CHAR(2),
--							   nombre VARCHAR(50),
--                             descripcion_texto VARCHAR(MAX), 
--                             descripcion_html VARCHAR(MAX),
--                             imagen VARCHAR(256)

--		Parámetros de salida: <ninguno>
--		Tabla: CATEGORIA_PRODUCTOS
--		
--		# Se debe comprobar que todos los parámetros obligatorios están informados. Si falta alguno, devolver -1 y finalizar.
--		# Se debe comprobar que la categoría no exista previamente en la tabla. Si ya existe, imprimir mensaje indicándolo, devolver -1 y finalizar.
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--	
--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--      Recuerda utilizar en el script:
--              EXEC @ret = crearCategoriaProducto ...
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER PROCEDURE crearCategoriaProducto (@codCategoria CHAR(2), @nombre VARCHAR(50), @descripcion_texto VARCHAR(MAX), @descripcion_html VARCHAR(MAX), @imagen VARCHAR(256))
AS
BEGIN
	BEGIN TRY
		IF @codCategoria IS NULL
		BEGIN
			PRINT ('El codigo es obligatorio')
			RETURN -1
		END

		IF EXISTS(SELECT codCategoria 
				FROM CATEGORIA_PRODUCTOS
				WHERE codCategoria = @codCategoria)
		BEGIN
			PRINT ('El codigo ya existe')
			RETURN -1
		END

		IF @nombre IS NULL
		BEGIN
			PRINT ('El nombre es obligatorio')
			RETURN -1
		END

		IF @descripcion_texto IS NULL
		BEGIN
			PRINT ('La descripcion es obligatoria')
			RETURN -1
		END

		INSERT INTO CATEGORIA_PRODUCTOS
			VALUES(@codCategoria, @nombre, @descripcion_texto, @descripcion_html, @imagen)


	END TRY
	BEGIN CATCH
		PRINT CONCAT('ERROR: ', ERROR_NUMBER(),
					'Mensaje: ', ERROR_MESSAGE(),
					'Linea: ', ERROR_LINE(),
					'Procedure: ', ERROR_PROCEDURE())
	END CATCH
END

-------------------------------------
DECLARE @codigo CHAR(2) = 'OR'
DECLARE @nombreCat VARCHAR(50) = 'Ornamental'
DECLARE @destexto VARCHAR(MAX) = 'descripcion'
DECLARE @deshtml VARCHAR(MAX)
DECLARE @img VARCHAR(256)
DECLARE @ret INT

EXEC @ret = crearCategoriaProducto @codigo, @nombreCat, @destexto, @deshtml, @img

IF @ret <> 0
RETURN

PRINT ('Categoria creada')

-------------------------------------------------------------------------------------------
-- 4. Implementa un procedimiento llamado 'acuseRecepcionPedidosCliente' que actualice la fecha de entrega de los pedidos
--      a la fecha del momento actual y su estado a 'Entregado' para el codCliente pasado por parámetro y solo para los 
--      pedidos que estén en estado 'Pendiente' y no tengan fecha de entrega.

--		Parámetros de entrada: codCliente INT
--		Parámetros de salida:  numPedidosAct INT
--		Tabla: PEDIDOS

--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--
--      Ayuda: Recuerda utilizar:
--              EXEC @ret = acuseRecepcionPedidosCliente ...
--              IF @ret <> 0 ...
--
--	  * Ayuda para obtener el número de registros actualizados:
--		Se puede hacer una SELECT antes de ejecutar la sentencia de actualización o bien utilizar la variable @@ROWCOUNT
--
-------------------------------------------------------------------------------------------
GO 
CREATE OR ALTER PROCEDURE acuseRecepcionPedidosCliente (@codCliente INT, @numPedidosAct INT OUTPUT)
AS
BEGIN
	BEGIN TRY
		IF @codCliente IS NULL
		BEGIN
			PRINT('El codigo debe ser obligatorio')
			RETURN -1
		END

		IF NOT EXISTS(SELECT codCliente
						FROM CLIENTES
						WHERE codCliente = @codCliente)
		BEGIN
			PRINT('El cliente no existe')
			RETURN -1
		END

		SET @numPedidosAct = 0

		UPDATE PEDIDOS
		SET codEstado = 'E',
		fecha_entrega = GETDATE()
		WHERE codCliente = @codCliente
		AND (fecha_entrega IS NULL AND codEstado = 'P')

		SET @numPedidosAct = @@ROWCOUNT

	END TRY
	BEGIN CATCH
		PRINT CONCAT('Error: ', ERROR_NUMBER(),
						'Mensaje: ', ERROR_MESSAGE(),
						'Linea: ', ERROR_LINE(),
						'Procedure: ', ERROR_PROCEDURE())
	END CATCH
END

--------------------------------
GO
DECLARE @codigo INT = 3
DECLARE @numPedidosAct INT
DECLARE @ret INT

EXEC @ret = acuseRecepcionPedidosCliente @codigo, @numPedidosAct OUTPUT

IF @ret <> 0
RETURN 

PRINT CONCAT('Numero de pedidos actualizados son ', @numPedidosAct)



-------------------------------------------------------------------------------------------
-- 5. Implementa un procedimiento llamado 'crearOficina' que inserte una nueva oficina en JARDINERIA.
--		Parámetros de entrada: codOficina CHAR(6)
--                             ciudad VARCHAR(40)
--                             pais VARCHAR(50)
--                             region VARCHAR(50) (no obligatorio)
--                             codigo_postal CHAR(5)
--                             telefono VARCHAR(15)
--                             linea_direccion1 VARCHAR(100)
--                             linea_direccion2 VARCHAR(100) (no obligatorio)

--		Parámetros de salida: <ninguno>
--		Tabla: OFICINAS
--		
--		# Se debe comprobar que todos los parámetros obligatorios están informados, sino devolver -1 y finalizar
--		# Se debe comprobar que el codOficina no exista previamente en la tabla, y si así fuera, 
--			imprimir un mensaje indicándolo y se devolverá -1
--		
--		El procedimiento devolverá 0 si finaliza correctamente.
--		Debes utilizar TRY/CATCH, validación de parámetros y transacciones si fueran necesarias.
--	
--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--
--      Ayuda: Recuerda utilizar:
--              EXEC @ret = crearOficina ...
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER PROCEDURE crearOficina(@codOficina CHAR(6), 
										@ciudad VARCHAR(40), 
										@pais VARCHAR(50), 
										@region VARCHAR(50) = NULL,
										@codigo_postal CHAR(5),
										@telefono VARCHAR(15),
										@linea_direccion1 VARCHAR(100),
										@linea_direccion2 VARCHAR(100) = NULL)
AS
BEGIN
	BEGIN TRY
		IF @codOficina IS NULL
		BEGIN
			PRINT('Codigo oficina obligatorio')
			RETURN -1
		END

		IF EXISTS(SELECT codOficina
					FROM OFICINAS
					WHERE codOficina = @codOficina)
		BEGIN
			PRINT('La oficina ya existe')
		END

		/* Todas las validaciones */


		INSERT INTO OFICINAS
			VALUES (@codOficina, @ciudad, @pais, @region, @codigo_postal, @telefono, @linea_direccion1, @linea_direccion2)
	END TRY
	BEGIN CATCH
		PRINT CONCAT('Error: ', ERROR_NUMBER(),
						'Linea: ', ERROR_LINE(),
						'Mensaje: ', ERROR_MESSAGE(),
						'Procedure: ', ERROR_PROCEDURE())
	END CATCH
END




-------------------------------------------------------------------------------------------
-- 6. Implementa un procedimiento llamado 'cambioJefes' que actualice el jefe/a de los empleados/as del
--      que tuvieran inicialmente (ant_codEmplJefe) al nuevo/a (des_codEmplJefe)
--    NOTA: Es un proceso que ocurre si alguien asciende de categoría.

--		Parámetros de entrada: ant_codEmplJefe INT
--                             des_codEmplJefe INT

--		Parámetros de salida: numEmpleados INT (número de empleados que han actualizado su jefe)
--		Tabla: EMPLEADOS

--	  * Comprueba que el funcionamiento es correcto realizando una llamada desde un script y comprobando la finalización del mismo
--
--      Ayuda: Recuerda utilizar:
--              EXEC @ret = cambioJefes ...
--              IF @ret <> 0 ...
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER PROCEDURE cambioJefes(@ant_codEmplJefe INT, @des_codEmplJefe INT, @numEmpleados INT OUTPUT)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			IF @ant_codEmplJefe IS NULL
			BEGIN
				PRINT ('El codigo anterior de empleado jefe es obligatorio')
				RETURN -1
			END

			IF @ant_codEmplJefe <= 0 OR NOT EXISTS(SELECT *
													FROM EMPLEADOS
													WHERE codEmpleado = @ant_codEmplJefe)
			BEGIN
				PRINT('El empleado no existe')
				RETURN -1
			END


			UPDATE EMPLEADOS
				SET codEmplJefe = NULL
				WHERE codEmpleado = @des_codEmplJefe

			UPDATE EMPLEADOS
				SET codEmplJefe = @des_codEmplJefe
				WHERE codEmpleado = @ant_codEmplJefe

			UPDATE EMPLEADOS
				SET codEmplJefe = @des_codEmplJefe
				WHERE codEmplJefe = @ant_codEmplJefe

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT CONCAT('ErrorNum: ', ERROR_NUMBER(),
						'Message ', ERROR_MESSAGE(),
						'Line: ', ERROR_LINE(),
						'Procedure: ', ERROR_PROCEDURE())
	END CATCH

END
---------------------------
DECLARE @jefe_ant INT = 0, @jefe_des INT = NULL, @cont INT, @ret INT
EXEC @ret = cambioJefes @jefe_ant, @jefe_des, @cont OUTPUT

IF @ret <> 0
RETURN
	
PRINT('Update hecha')

-------------------------------------------------------------------------------------------
-- 7. Implementa una función llamada getCostePedidos que reciba como parámetro un codCliente y devuelva
--		el coste de todos los pedidos realizados por dicho cliente.
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------
GO 
CREATE OR ALTER FUNCTION cacularCostePedido(@codPedido INT)
RETURNS DECIMAL(9,2)
AS
BEGIN
	DECLARE @salida DECIMAL(9,2)

	SET @salida = (SELECT ISNULL(SUM(precio_unidad*cantidad),0)
						FROM DETALLE_PEDIDOS
						WHERE codPedido = @codPedido)
	RETURN @salida
END

GO
CREATE OR ALTER FUNCTION getCostePedidos(@codCliente INT)
RETURNS DECIMAL(9,2)
AS
BEGIN
	DECLARE @salida DECIMAL(9,2)

	SET @salida = (SELECT ISNULL(SUM(dbo.cacularCostePedido(codPedido)),0)
					FROM PEDIDOS
					WHERE codCliente = @codCliente)
	RETURN @salida
END

----------------------------
SELECT codCliente, dbo.getCostePedidos(codCliente) AS costePedidos
	FROM CLIENTES
	WHERE codCliente = 5


-------------------------------------------------------------------------------------------
-- 8. Implementa una función llamada numEmpleadosOfic que reciba como parámetro un codOficina y devuelva
--		el número de empleados que trabajan en ella
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER FUNCTION numEmpleadosOfic(@codOficina CHAR(6))
RETURNS INT
AS
BEGIN
	DECLARE @salida INT

	SET @salida = (SELECT COUNT(codEmpleado)
					FROM EMPLEADOS
					WHERE codOficina = @codOficina)

	RETURN @salida
END

-----------------------------------------
SELECT codOficina, dbo.numEmpleadosOfic(codOficina) AS numEmpleados
	FROM OFICINAS
	WHERE codOficina = 'MAD-ES'

-------------------------------------------------------------------------------------------
-- 9. Implementa una función llamada clientePagos_SN que reciba como parámetro un codCliente y devuelva
--		'S' si ha realizado pagos y 'N' si no ha realizado ningún pago.
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER FUNCTION clientesPagos_SN (@codCliente INT)
RETURNS CHAR(1)
AS
BEGIN
	DECLARE @salida CHAR(1)

	DECLARE @numPagos INT = (SELECT ISNULL(COUNT(id_transaccion),0)
								FROM PAGOS
								WHERE codCliente = @codCliente)

	IF @numPagos > 0
	BEGIN
		SET @salida = 'S'
	END
	ELSE
	BEGIN
		SET @salida = 'N'
	END
	RETURN @salida
END

------------------------------
SELECT codCliente, dbo.clientesPagos_SN(codCliente) AS haPagado
	FROM CLIENTES
	WHERE codCliente = 7


-------------------------------------------------------------------------------------------
-- 10. Implementa una función llamada pedidosPendientesAnyo que reciba como parámetros 'estado' y 'anyo'
--	    y devuelva una TABLA con los pedidos pendientes del año 2009 (estos datos deben ponerse directamente en la SELECT, NO son dinámicos)

--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER FUNCTION pedidosPendientesAnyo (@estado CHAR(1), @anyo INT)
RETURNS TABLE
AS
BEGIN
	RETURN (SELECT codPedido
			FROM PEDIDOS
			WHERE codEstado = @estado
			AND YEAR(fecha_pedido) = @anyo)
END

-----------------
SELECT *
	FROM  dbo.pedidosPendientesAnyo('P', 2009)

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

CREATE TABLE LIBROS(
ISBN			CHAR(13),
Titulo			VARCHAR(100) NOT NULL,
precio			DECIMAL(7,2) NOT NULL

CONSTRAINT PK_LIBROS PRIMARY KEY (ISBN)
)

CREATE TABLE SOCIOS(
DNI				CHAR(9),
nombre			VARCHAR(100) NOT NULL,
ciudad			VARCHAR(50) NOT NULL

CONSTRAINT PK_SOCIOS PRIMARY KEY (DNI)
)

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
	INSERT INTO LIBROS_PERDIDOS
	SELECT p.ISBN, s.DNI, s.nombre, GETDATE()
		FROM PRESTAMOS p,
			SOCIOS s
		WHERE p.DNI = s.DNI 
		AND p.FechaDevol IS NULL
		AND s.DNI IN (SELECT DNI FROM deleted)
		
	DELETE FROM SOCIOS
	WHERE DNI IN (SELECT DNI FROM DELETED)

END

----------------
DELETE FROM SOCIOS
WHERE DNI = '44455566B'

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

---------------------------------------------
GO
CREATE OR ALTER TRIGGER TX_BajaTecnico ON TECNICOS
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @importe DECIMAL(7,2) = 2500

	INSERT INTO TECNICOS_RESERVA
	SELECT DNI, Nombre, Ciudad, Salario, GETDATE()
		FROM deleted 
		WHERE DNI IN (SELECT Dni_Tecnico 
						FROM REPARACIONES
						WHERE importe > @importe)

END
---------------------
DELETE FROM TECNICOS
WHERE DNI = '11122233A'

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
GO
CREATE OR ALTER TRIGGER TX_BajaProveedor ON PROVEEDORES
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @stock INT = 0

	INSERT INTO ARTICULOS_INEXISTENTES
	SELECT a.codArticulo, a.nombre, a.stock, a.pvp, a.precio_compra, a.codAlmacen, a.codProveedor, GETDATE()
		FROM ARTICULOS a
		WHERE codArticulo IN (SELECT codArticulo 
								FROM deleted
								WHERE stock = @stock)

	DELETE FROM ARTICULOS
	WHERE codArticulo IN (SELECT codArticulo
							FROM inserted)
	DELETE FROM PROVEEDORES
	WHERE codProveedor IN (SELECT codProveedor
							FROM deleted)
END

-------------------------
DELETE FROM ARTICULOS
WHERE codArticulo = 8

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
CREATE OR ALTER TRIGGER TX_ActualizarCliente ON CLIENTES
AFTER UPDATE
AS
BEGIN
	INSERT INTO CLIENTES_HISTORICOS (codcliente, nombre_cliente, nombre_contacto, apellido_contacto, telefono, email, linea_direccion1, linea_direccion2, ciudad, pais, codPostal, codEmpl_ventas, limite_credito, fechaModificacion)
	SELECT codcliente, nombre_cliente, nombre_contacto, apellido_contacto, telefono, email, linea_direccion1, linea_direccion2, ciudad, pais, codPostal, codEmpl_ventas, limite_credito, GETDATE()
		FROM deleted
END

--------------------------
UPDATE CLIENTES
SET nombre_cliente = 'Nuevo Nombre'
WHERE codCliente = 5

/*1.- Nombre de productos en BD TIENDA
Utilizando la BD TIENDA, crea un script que recorra con cursores la tabla PRODUCTO y
que muestre el nombre de cada producto por pantalla.
Ejemplo de salida.
Disco duro SATA3 1TB
Memoria RAM DDR4 8GB
Disco SSD 1 TB*/
USE TIENDA
GO
DECLARE @nombre VARCHAR(100)
DECLARE recorrer_Nombre CURSOR FOR
SELECT nombre	
	FROM PRODUCTO

OPEN recorrer_Nombre

FETCH NEXT FROM recorrer_Nombre INTO @nombre

WHILE @@FETCH_STATUS = 0
BEGIN
	PRINT @nombre
	FETCH NEXT FROM recorrer_Nombre INTO @nombre
END
CLOSE recorrer_Nombre
DEALLOCATE recorrer_Nombre


/*2.- Nombre y precio de productos en BD TIENDA
Ampliación del script anterior. Utilizando la BD TIENDA, crea un script que recorra con
cursores la tabla PRODUCTO y que muestre el nombre de cada producto y su precio por
pantalla haciendo uso de la función CONCAT.
Ejemplo de salida.
El producto Disco duro SATA3 1TB tiene un precio de 86.99 €
El producto Memoria RAM DDR4 8GB tiene un precio de 120 €
El producto Disco SSD 1 TB tiene un precio de 150.99 €*/
USE TIENDA 
GO
DECLARE @nombreProd VARCHAR(100)
DECLARE @precio DECIMAL(9,2)
DECLARE recorrer_Nombre CURSOR FOR
SELECT nombre, precio
	FROM PRODUCTO

OPEN recorrer_Nombre 

FETCH NEXT FROM recorrer_Nombre INTO @nombreProd, @precio

WHILE @@FETCH_STATUS = 0
BEGIN
	PRINT CONCAT('El producto ', @nombreProd, ' tiene un precio de ', @precio, '€.')
	FETCH NEXT FROM recorrer_Nombre INTO @nombreProd, @precio
END

CLOSE recorrer_Nombre
DEALLOCATE recorrer_Nombre

/*3.- Cursores anidados en BD TIENDA
En este script deberás utilizar un cursor que recorra la tabla FABRICANTE y dentro de éste
cursor otro que recorra la tabla PRODUCTO. El objetivo es que dentro de este segundo
cursor se acumule el precio de los productos de cada fabricante y que se muestre algo
similar a lo siguiente:
Ejemplo de salida.
“Fabricante: nombreFabricante tiene un total de acumulado € en productos.” (siendo
las palabras resaltadas en rojo variables)*/
USE TIENDA 
GO
DECLARE @codFabricante VARCHAR(100)
DECLARE @nombre VARCHAR(100)

DECLARE recorrer_Fabricante CURSOR FOR
SELECT codigo, nombre
	FROM FABRICANTE

OPEN recorrer_Fabricante
FETCH NEXT FROM recorrer_Fabricante INTO @codFabricante, @nombre

WHILE @@FETCH_STATUS = 0
BEGIN
	DECLARE recorrer_Producto CURSOR FOR
	SELECT precio
		FROM PRODUCTO
		WHERE codigo_fabricante = @codFabricante


	DECLARE @precio DECIMAL(9,2)
	DECLARE @acumulado DECIMAL(9,2)
	SET @acumulado = 0
	
	OPEN recorrer_Producto
	FETCH NEXT FROM recorrer_Producto INTO @precio

	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @acumulado = @acumulado + @precio
		FETCH NEXT FROM recorrer_Producto INTO @precio
	END
	CLOSE recorrer_Producto
	DEALLOCATE recorrer_Producto

	PRINT CONCAT(@nombre, ' tiene un total de ', @acumulado, '€ en productos.')
	FETCH NEXT FROM recorrer_Fabricante INTO @codFabricante, @nombre

END

CLOSE recorrer_Fabricante
DEALLOCATE recorrer_Fabricante

/*4.- Cursor de Empleados en BD JARDINERIA
Crea un script que recorra con cursores la tabla EMPLEADOS y que muestre los siguientes
datos de cada empleado: nombre, apellido1, apellido2 y email. Deberás formatearlos
utilizando la función CONCAT*/
USE JARDINERIA
GO
DECLARE @nombre VARCHAR(50)
DECLARE @apellido1 VARCHAR(50)
DECLARE @apellido2 VARCHAR(50)
DECLARE @email VARCHAR(20)
DECLARE recorrer_Empleado CURSOR FOR
SELECT nombre, apellido1, apellido2, email
	FROM EMPLEADOS

OPEN recorrer_Empleado
FETCH NEXT FROM recorrer_Empleado INTO @nombre, @apellido1, @apellido2, @email

WHILE @@FETCH_STATUS = 0
BEGIN
	PRINT CONCAT(@nombre, ' ', @apellido1, ' ', @apellido2, ' ', @email)
	FETCH NEXT FROM recorrer_Empleado INTO @nombre, @apellido1, @apellido2, @email
END

/*5.- Cursores anidados en BD JARDINERIA
En este script deberás utilizar un cursor que recorra la tabla PEDIDOS y dentro de éste
cursor otro que recorra la tabla DETALLE_PEDIDOS. El objetivo es que dentro de este
segundo cursor se acumule el total por línea de cada pedido y que finalmente se muestre el
total acumulado para cada pedido.
“Nº Pedido XXXX tiene un coste total de XXXX €”*/
USE JARDINERIA
GO
DECLARE @codPedido INT
DECLARE recorrer_Pedidos CURSOR FOR
SELECT codPedido
	FROM PEDIDOS

OPEN recorrer_Pedidos
FETCH NEXT FROM recorrer_Pedidos INTO @codPedido

WHILE @@FETCH_STATUS = 0
BEGIN
	DECLARE @coste DECIMAL(9,2)
	DECLARE @acumulado DECIMAL(9,2)
	SET @acumulado = 0

	DECLARE recorrer_CostePedido CURSOR FOR
	SELECT precio_unidad * cantidad
		FROM DETALLE_PEDIDOS
		WHERE codPedido = @codPedido

	OPEN recorrer_CostePedido
	FETCH NEXT FROM recorrer_CostePedido INTO @coste

	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @acumulado = @acumulado + @coste
		PRINT CONCAT('El pedido ', @codPedido, 'tiene acumulado ', @acumulado, '€.')
	END
	CLOSE recorrer_CostePedido
	DEALLOCATE recorrer_CostePedido
END

CLOSE recorrer_Pedidos
DEALLOCATE recorrer_Pedidos

/*PROCEDIMIENTOS*/
CREATE OR ALTER PROCEDURE getNombreClientes (@codCliente INT, @nombreCliente VARCHAR(50) OUTPUT)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
		/*Validaciones primero*/
		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		/*eRRORES*/
	END CATCH
END
-------------
DECLARE @codCliente INT = 9
DECLARE @nombreCliente VARCHAR(50)
DECLARE @ret INT

EXEC @ret = getNombreClientes @codCliente, @nombreCliente OUTPUT

IF @ret <> 0
RETURN

PRINT @nombreCliente

/*FUNCIONES*/
CREATE OR ALTER FUNCTION clientesPagos_SN(@codCliente INT)
RETURNS CHAR(1)
AS
BEGIN
	DECLARE @salida CHAR(1)

	SET @salida = 'S'

	RETURN @salida
END
-----------------------------
SELECT codCliente, dbo.clientesPagos_SN(codCliente)
	FROM CLIENTES

/*TRIGGERS*/
CREATE OR ALTER TRIGGER TX_BajaSocio ON SOCIOS
INSTEAD OF DELETE /*AFTER DELETE*/
AS 
BEGIN
	INSERT INTO TABLE
	SELECT *
		FROM deleted

	DELETE FROM SOCIOS
	WHERE codCliente IN (SELECT codCliente FROM deleted)
END

/*CURSORES*/
DECLARE @variable
DECLARE cursor_tabla CURSOR FOR
SELECT nombre	
	FROM PRODUCTO

FETCH NEXT FROM cursor_tabla INTO @variable

WHILE @@FETCH_STATUS = 0
BEGIN
	PRINT @variable
	FETCH NEXT FROM cursor_tabla INTO @variable
END

OPEN cursor_tabla
DEALLOCATE cursor_tabla


/* A) Crea un procedimiento llamado crearPedidoActualizaPago que reciba como parámetros de entrada:
 fecha_esperada, fecha_entrega, codEstado, comentarios, codCliente, id_transaccion
 
 1º Validar los parámetros de entrada
 2º Insertar un nuevo pedido en la tabla PEDIDOS con los parámetros de entrada
 3º Actualizar los PAGOS del cliente, para aquellos que NO tengan codPedido (NULL), se actualizarán
	con el nuevo que acabamos de crear. */

GO
CREATE OR ALTER PROCEDURE crearPedidosActualizaPago (@fecha_esperada DATE, @fecha_entrega DATE, @codEstado CHAR(1), @comentarios VARCHAR(500), @codCliente INT, @id_transaccion CHAR(15))
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN

			IF @fecha_esperada IS NULL
			BEGIN
				PRINT('Error')
				RETURN -1
			END

			IF @fecha_entrega IS NULL
			BEGIN
				PRINT('Error')
				RETURN -1
			END

			IF @codEstado IS NULL
			BEGIN
				PRINT('Error')
				RETURN -1
			END

			IF @codCliente IS NULL
			BEGIN
				PRINT('Error')
				RETURN -1
			END

			IF @id_transaccion IS NULL
			BEGIN
				PRINT('ERROR')
				RETURN -1
			END

			INSERT INTO PEDIDOS (fecha_pedido, fecha_esperada, fecha_entrega, comentarios, codCliente)
			VALUES(GETDATE(), @fecha_esperada, @fecha_entrega, @comentarios, @codCliente)

			DECLARE @codPedido INT
			SET @codPedido = (SELECT TOP(1)codPedido
									FROM PEDIDOS
									WHERE codCliente = @codCliente
									ORDER BY codPedido DESC)


			UPDATE PAGOS
			SET codPedido = @codPedido
			WHERE id_transaccion = @id_transaccion

		COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
		PRINT CONCAT('ERROR: ', ERROR_NUMBER())
	END CATCH
END

--------------------------
DECLARE @ret INT

EXEC @ret = crearPedidosActualizaPago

/* B) Crea una función llamada importePagosCliente que devuelva el importe de los pagos
	de un cliente pasado como parámetro. Llama a la función con la tabla CLIENTES.

   Crea otra función que devuelva los PAGOS cuyo importe sea inferior al importe de 
	los pagos del cliente.

   Crea otra función que devuelva cuánto suma el importe total vendido para un producto.
	Debes comprobarlo en la tabla DETALLE_PEDIDOS (cantidad y precio). */

	GO
	CREATE OR ALTER FUNCTION importePagosClientes(@codCliente INT)
	RETURNS DECIMAL(9,2)
	AS
	BEGIN
		DECLARE @salida DECIMAL(9,2)
		
		SET @salida = (SELECT ISNULL(SUM(importe_pago),0)
							FROM PAGOS
							WHERE codCliente = @codCliente)

		RETURN @salida
	END
	---------------------------
	SELECT codCliente, dbo.importePagosClientes(codCliente) as IMPORTE
		FROM CLIENTES

/* C) Crea un cursor que itere por la tabla EMPLEADOS, muestre su código, nombre y el 
	número de clientes que tienen a su cargo (con doble cursor o con SELECT).

   Crea un cursor que itere por la tabla PRODUCTOS e indique la siguiente información:
	El producto XXX con referencia YYY aparece ZZZ veces en la tabla DETALLE_PEDIDOS. */

	DECLARE @empleado

/*
D) Crea un trigger que se active cuando se inserte un nuevo cliente y que en caso 
	de no tener un limite_credito > 10000 se impida su inserción.

   Crea un trigger que haga una copia de seguridad de la tabla FORMA_PAGO en la tabla
	HIST_FORMA_PAGO cuando se actualice o borre algún registro de esta tabla.
	La tabla HIST_FORMA_PAGO tendrá además la fecha de operación que corresponderá
	con la fecha en la que se ejecute el trigger. */
	GO
	CREATE OR ALTER TRIGGER TX_InsertarCliente ON CLIENTES
	INSTEAD OF INSERT
	AS 
	BEGIN
		DECLARE @limite DECIMAL(9,2)
		SET @limite = (SELECT limite_credito
						FROM inserted)
		IF(@limite < 10000)
		BEGIN
			INSERT INTO CLIENTES
			SELECT *
				FROM inserted
		END
	END

	GO
	CREATE OR ALTER TRIGGER TX_CopiaSeguridad ON FORMA_PAGO
	AFTER UPDATE 
	AS
	BEGIN
		INSERT INTO HIST_FORMA_PAGO
		SELECT * FROM deleted
	
	END