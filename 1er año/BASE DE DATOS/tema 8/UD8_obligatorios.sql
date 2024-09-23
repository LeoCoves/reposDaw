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
GO
CREATE OR ALTER PROCEDURE getNombreCliente(@codigoCliente INT, 
											@nombreCliente VARCHAR(50) OUTPUT)
AS
BEGIN
	BEGIN TRY
		IF @codigoCliente IS NULL
		BEGIN
			PRINT 'El codigo del cliente es obligatorio'
			RETURN -1
		END

		SELECT @nombreCliente = nombre_cliente 
			FROM CLIENTES
			WHERE codCliente = @codigoCliente

		IF @nombreCliente IS NULL
		BEGIN
			PRINT CONCAT('El codigo ', @codigoCliente, ' no existe')
			RETURN -2
		END
	END TRY
	BEGIN CATCH
		PRINT CONCAT('Error= ', ERROR_NUMBER(),
				'Linea= ', ERROR_LINE(),
				 'Proced= ', ERROR_PROCEDURE())
	END CATCH
END

--------------------------
---Declaramos
GO
DECLARE @codCliente INT = 9
DECLARE @nombre VARCHAR(50)
DECLARE @ret INT

EXEC @ret = getNombreCliente @codCliente, @nombre OUTPUT

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
CREATE OR ALTER PROCEDURE getPedidosPagosClientes (@codCliente INT,
													@numPedidos INT OUTPUT,
													@numPagos INT OUTPUT)
AS
BEGIN
	BEGIN TRY

		IF @codCliente IS NULL
		BEGIN
			PRINT 'El codigo es obligatorio'
			RETURN -1
		END

		SET @numPedidos = 0
		SET @numPagos = 0

		SELECT @numPedidos = COUNT(codCliente)
			FROM PEDIDOS
			WHERE codCliente = @codCliente

		SELECT @numPagos = COUNT(codCliente)
			FROM PAGOS
			WHERE codCliente = @codCliente

	END TRY

	BEGIN CATCH
		PRINT CONCAT('Error= ', ERROR_NUMBER(),
				'Linea= ', ERROR_LINE(),
				 'Proced= ', ERROR_PROCEDURE())
	END CATCH
END

--------------------------
---Declaramos
GO
DECLARE @codigoCliente INT = 7
DECLARE @numeroPedidos INT
DECLARE @numeroPagos INT 
DECLARE @ret INT

EXEC @ret = getPedidosPagosClientes @codigoCliente, @numeroPedidos OUTPUT, @numeroPagos OUTPUT

IF @ret <> 0 
	RETURN

PRINT CONCAT('Ha realizado ', @numeroPedidos, ' pedidos y ', @numeroPagos, ' pagos')

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
CREATE OR ALTER PROCEDURE crearCategoriaProducto (@codCategoria CHAR(2),
													@nombre VARCHAR(50),
													@descripcion_texto VARCHAR(MAX),
													@descripcion_html VARCHAR(MAX),
													@imagen VARCHAR(256))
AS
BEGIN
	BEGIN TRY
		IF @codCategoria IS NULL
		BEGIN
			PRINT 'La categoria es obligatoria'
			RETURN -1
		END

		IF @nombre IS NULL
		BEGIN
			PRINT 'El nombre es obligatorio'
			RETURN -2
		END

		IF @descripcion_texto IS NULL
		BEGIN
			PRINT 'La descripcion del texto es obligatorio'
			RETURN -3
		END

		BEGIN TRANSACTION
			INSERT INTO CATEGORIA_PRODUCTOS
				VALUES (@codCategoria, @nombre, @descripcion_texto,
						@descripcion_html, @imagen)
		COMMIT

	END TRY

	BEGIN CATCH
		ROLLBACK
		PRINT CONCAT('Error= ', ERROR_NUMBER(),
				'Linea= ', ERROR_LINE(),
				 'Proced= ', ERROR_PROCEDURE())
	END CATCH
END

--------------------------
---Declaramos
GO
DECLARE @codCategoria INT = 7
DECLARE @nombre VARCHAR(50) = 'Leo'
DECLARE @descripcionTexto VARCHAR(MAX) = 'Siiiiii'
DECLARE @descripcionHtml VARCHAR(MAX)
DECLARE @imagen VARCHAR(256)
DECLARE @ret INT

EXEC @ret = getPedidosPagosClientes @codCategoria, @nombre, @descripcionTexto, @descripcionHtml, @imagen

IF @ret <> 0 
	RETURN

PRINT CONCAT('Creado correctamente')


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
CREATE OR ALTER PROCEDURE acuseRecepcionPedidosCliente(@codCliente INT,
														@numPedidos INT OUTPUT)
AS
BEGIN
	BEGIN TRY
		IF @codCliente IS NULL
		BEGIN
			PRINT 'El campo codCliente es obligatorio'
			RETURN -1
		END

		UPDATE PEDIDOS
		SET codEstado = 'E',
		fecha_entrega = GETDATE()
		WHERE codCliente = @codCliente
		AND fecha_entrega IS NULL AND codEstado = 'P'

		SET @numPedidos = @@ROWCOUNT

		IF @numPedidos IS NULL
		BEGIN
			PRINT 'El cliente no existe'
			RETURN -2
		END
	END TRY

	BEGIN CATCH
		PRINT CONCAT('Error= ', ERROR_NUMBER(),
					'Linea= ', ERROR_LINE(),
					 'Proced= ', ERROR_PROCEDURE())
	END CATCH
END
--------------------------------
--Declaramos
GO
DECLARE @codigoCliente INT = 4
DECLARE @numeroPedidos INT 
DECLARE @ret INT

EXEC @ret = acuseRecepcionPedidosCliente @codigoCliente, @numeroPedidos OUTPUT

IF @ret <> 0 
	RETURN

PRINT CONCAT(@numeroPedidos, ' Pedidos Actualizados correctamente')



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
		IF EXISTS(SELECT codOficina
					FROM OFICINAS
					WHERE codOficina = @codOficina)
		BEGIN
			PRINT 'El codigo de oficina ya existe'
			RETURN -1
		END

		INSERT INTO OFICINAS
			VALUES (@codOficina, @ciudad, @pais, 
					@region, @codigo_postal, @telefono, 
					@linea_direccion1, @linea_direccion2)
	END TRY

	BEGIN CATCH
			PRINT CONCAT('Error= ', ERROR_NUMBER(),
					'Linea= ', ERROR_LINE(),
					 'Proced= ', ERROR_PROCEDURE())
	END CATCH
END
--------------------------------
--Declaramos
GO
DECLARE @codOficina CHAR(6) = 'ELX-ES'
DECLARE @ciudad VARCHAR(40) = 'Elche'
DECLARE @pais VARCHAR(50) = 'España'
DECLARE @region VARCHAR(50) = NULL
DECLARE @codigo_postal CHAR(5) = '04543'
DECLARE @telefono VARCHAR(15) = '+34 954434653'
DECLARE @linea_direccion1 VARCHAR(100) = 'Avenida Libertad, 44'
DECLARE @linea_direccion2 VARCHAR(100) = NULL
DECLARE @ret INT

EXEC @ret = crearOficina @codOficina, @ciudad, @pais, @region, @codigo_postal, @telefono, @linea_direccion1, @linea_direccion2

IF @ret <> 0 
	RETURN

PRINT CONCAT('Oficina creada correctamente')


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
CREATE OR ALTER PROCEDURE cambioJefes (@ant_codEmplJefe INT,
										@des_codEmplJefe INT,
										@numEmpleados INT OUTPUT)
AS
BEGIN
	BEGIN TRY
		IF @ant_codEmplJefe IS NULL
		BEGIN
			PRINT 'El codigo del anterior jefe es obligatorio'
			RETURN -1
		END
		
		IF @des_codEmplJefe IS NULL
		BEGIN
			PRINT 'El codigo de el jefe a actualizar es obligatorio'
			RETURN -2
		END

		BEGIN TRANSACTION
			UPDATE EMPLEADOS
			SET codEmplJefe = @des_codEmplJefe
			WHERE codEmpleado = @ant_codEmplJefe

			UPDATE EMPLEADOS
			SET codEmpleado = NULL
			WHERE codEmpleado = @des_codEmplJefe

			UPDATE EMPLEADOS
			SET codEmplJefe = @des_codEmplJefe
			WHERE codEmpleado <> @des_codEmplJefe
			AND codEmplJefe = @ant_codEmplJefe

			SET @numEmpleados = @@ROWCOUNT

		COMMIT

	END TRY

	BEGIN CATCH
		ROLLBACK 
		PRINT CONCAT('Error= ', ERROR_NUMBER(),
						'Linea= ', ERROR_LINE(),
						 'Proced= ', ERROR_PROCEDURE())
	END CATCH
END
--------------------------------
--Declaramos
GO
DECLARE @ant_codEmplJefe INT = 3
DECLARE @des_codEmplJefe INT = 4
DECLARE @numEmpleados INT 
DECLARE @ret INT

EXEC @ret = cambioJefes @ant_codEmplJefe, @des_codEmplJefe, @numEmpleados OUTPUT

IF @ret <> 0 
	RETURN 0

PRINT CONCAT(@numEmpleados, ' empleados cambiados de jefe correctamente')

SELECT *
	FROM EMPLEADOS
-------------------------------------------------------------------------------------------
-- 7. Implementa una función llamada getCostePedidos que reciba como parámetro un codCliente y devuelva
--		el coste de todos los pedidos realizados por dicho cliente.
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------

GO
CREATE OR ALTER FUNCTION calculaCostePedido(@codPedido INT)
RETURNS DECIMAL(9,2)
AS
BEGIN
	DECLARE @salida DECIMAL(9,2)
	
	SET @salida = (SELECT ISNULL(SUM(cantidad * precio_unidad),0)
					FROM DETALLE_PEDIDOS
					WHERE codPedido = @codPedido)
	RETURN @salida
END

GO
CREATE OR ALTER FUNCTION getCostePedidos(@codCliente INT)
RETURNS DECIMAL(7,2)
AS
BEGIN
	DECLARE @salida DECIMAL(9,2)

	SET @salida = (SELECT ISNULL(SUM(dbo.calculaCostePedido(codPedido)),0)
					FROM PEDIDOS
					WHERE codCliente = @codCliente)
	
	RETURN @salida
END

--/////////////////////////////////

SELECT codCliente, dbo.getCostePedidos(codCliente) AS costeTotal
	FROM CLIENTES
	WHERE codCliente = 5


-------------------------------------------------------------------------------------------
-- 8. Implementa una función llamada numEmpleadosOfic que reciba como parámetro un codOficina y devuelva
--		el número de empleados que trabajan en ella
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER FUNCTION numEmpleadosOfic(@codOficina VARCHAR(150))
RETURNS INT
AS
BEGIN
	DECLARE @salida INT 
	SET @salida = (SELECT COUNT(*)
					FROM EMPLEADOS
					WHERE codOficina = @codOficina)
	RETURN @salida
END
--///////////////////////////////////////////////////
GO
SELECT codOficina, dbo. numEmpleadosOfic(codOficina) AS numEmpleados
	FROM OFICINAS
	WHERE codOficina = 'BCN-ES'


-------------------------------------------------------------------------------------------
-- 9. Implementa una función llamada clientePagos_SN que reciba como parámetro un codCliente y devuelva
--		'S' si ha realizado pagos y 'N' si no ha realizado ningún pago.
--	
--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER FUNCTION clientesPagos_SN(@codCliente INT)
RETURNS CHAR(1)
AS
BEGIN
	DECLARE @salida CHAR(1)

	DECLARE @numPagos INT
	SET @numPagos = (SELECT ISNULL(COUNT(id_transaccion),0)
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
--////////////////////
GO
SELECT codCliente, dbo.clientesPagos_SN(codCliente) AS haRealizadoPagos
	FROM CLIENTES
	WHERE codCliente = 5


-------------------------------------------------------------------------------------------
-- 10. Implementa una función llamada pedidosPendientesAnyo que reciba como parámetros 'estado' y 'anyo'
--	    y devuelva una TABLA con los pedidos pendientes del año 2009 (estos datos deben ponerse directamente en la SELECT, NO son dinámicos)

--	Recuerda que debes incluir la SELECT y comprobar el funcionamiento
-------------------------------------------------------------------------------------------
GO
CREATE OR ALTER FUNCTION pedidosPendientesAnyo(@estado VARCHAR(100), @anyo INT)
RETURNS TABLE
AS
	RETURN (SELECT *
				FROM PEDIDOS
				WHERE codEstado = @estado
				AND YEAR(fecha_pedido) = @anyo)

--///////////////////////////
GO
SELECT *
	FROM dbo.pedidosPendientesAnyo('P', 2009)