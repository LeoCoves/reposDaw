USE JARDINERIA

GO
CREATE OR ALTER PROCEDURE saludo
AS
BEGIN
	PRINT 'Hola mundo'
END 

EXEC saludo
-------------------------
-----------------------------------------
GO
CREATE OR ALTER PROCEDURE dimeNumero (@numero INT)
AS
BEGIN
	PRINT CONCAT('El numero es el: ', @numero)
END 

DECLARE @variable INT = RAND()*100
EXEC dimeNumero @variable
-----------------------------
-------------------------------------------
GO
CREATE OR ALTER PROCEDURE dimeNumeroSaluda (@numero INT, @saludo VARCHAR(20))
AS
BEGIN
	PRINT CONCAT('El numero es el: ', @numero)
	PRINT @saludo
END 

DECLARE @variable INT = 9
DECLARE @cadena VARCHAR(50) = 'Hola mundo'

EXEC dimeNumeroSaluda @variable, @cadena

----------------------------------
-------------------------------------------
GO
CREATE OR ALTER PROCEDURE multiplica (@numero1 INT, @numero2 INT, @resultado INT OUTPUT)
AS
BEGIN
	SET @resultado = @numero1 * @numero2
END

DECLARE @num1 INT = 4, @num2 INT = 3, @res INT
EXEC multiplica @num1, @num2, @res OUTPUT
PRINT @res
---------------------------------
--------------------------------------
--Procedimiento que imprima el nombre del cliente que se le pasa como parametro
GO
CREATE OR ALTER PROCEDURE printNombreCli (@codCliente INT)
AS
BEGIN
	DECLARE @nombreCli VARCHAR(50)
	
	SELECT @nombreCli = nombre_cliente
		FROM CLIENTES
		WHERE codCliente = @codCliente
	IF @nombreCli IS NOT NULL
	BEGIN
		PRINT @nombreCli
	END
	ELSE
	BEGIN
	PRINT 'No existe'
	END
END


EXEC printNombreCli -8798
--------------------------------------
----------------------------------------
GO
CREATE OR ALTER PROCEDURE printNombreCli2 (@codCliente INT)
AS
BEGIN
	DECLARE @nombreCli VARCHAR(50)
	
	SELECT @nombreCli = nombre_cliente
		FROM CLIENTES
		WHERE codCliente = @codCliente
	IF @nombreCli IS NOT NULL
	BEGIN
		PRINT @nombreCli
	END
	ELSE
	BEGIN
		PRINT 'No existe'
		RETURN -1
	END
END

DECLARE @codCli INT = 9
DECLARE @ret INT 

EXEC @ret = printNombreCli2 @codCli

IF @ret <> 0
BEGIN
	RETURN
END

PRINT 'EXEC siguiente PRODECURE'


-----------------------------
--------------------------------------
--Procedimientos
--CRUD create read update delete
USE TIENDA

--Crear fabricante
GO
CREATE OR ALTER PROCEDURE crearFabricante(@nombre VARCHAR(100),
											@codFabricante INT OUTPUT)
AS
BEGIN 
	BEGIN TRY
		IF @nombre IS NULL
		BEGIN
			PRINT 'El parametro nombre es obligatorio'
			RETURN -1
		END

		INSERT INTO FABRICANTE
			VALUES (@nombre)

		SET @codFabricante = SCOPE_IDENTITY()
		

	END TRY

	BEGIN CATCH
		PRINT CONCAT('Error= ', ERROR_NUMBER(),
					'Linea= ', ERROR_LINE(),
					'Desc= ', ERROR_MESSAGE(),
					'Proced= ', ERROR_PROCEDURE())
	END CATCH
END 

--Read fabricante
GO
CREATE OR ALTER PROCEDURE devolverFabricante(@codFabricante INT)
AS
BEGIN 
	BEGIN TRY
		DECLARE @nombre VARCHAR(100)
		IF @codFabricante IS NULL
		BEGIN
			PRINT 'El parametro nombre es obligatorio'
			RETURN -1
		END

		SELECT @nombre = nombre
			FROM FABRICANTE
			WHERE codigo = @codFabricante

		PRINT @nombre
		
	END TRY

	BEGIN CATCH
		PRINT CONCAT('Error= ', ERROR_NUMBER(),
					'Linea= ', ERROR_LINE(),
					'Desc= ', ERROR_MESSAGE(),
					'Proced= ', ERROR_PROCEDURE())
	END CATCH
END 

--Update Fabricante
GO
CREATE OR ALTER PROCEDURE devolverFabricante(@codFabricante INT)
AS
BEGIN 
	BEGIN TRY
		DECLARE @nombre VARCHAR(100)
		IF @codFabricante IS NULL
		BEGIN
			PRINT 'El parametro nombre es obligatorio'
			RETURN -1
		END

		SELECT @nombre = nombre
			FROM FABRICANTE
			WHERE codigo = @codFabricante

		PRINT @nombre
		
	END TRY

	BEGIN CATCH
		PRINT CONCAT('Error= ', ERROR_NUMBER(),
					'Linea= ', ERROR_LINE(),
					'Desc= ', ERROR_MESSAGE(),
					'Proced= ', ERROR_PROCEDURE())
	END CATCH
END 

---Llamando al procedimiento
DECLARE @nombre VARCHAR(100) = 'Apple'
DECLARE @codFabricante INT 
DECLARE @ret INT

EXEC @ret = crearFabricante @nombre, @codFabricante OUTPUT
IF @ret <> 0
	RETURN

PRINT CONCAT('El nuevo fabricante es el: ', @codFabricante)


----------------------------------------
---------------------------
USE TIENDA
GO
CREATE OR ALTER PROCEDURE ModificarFabricante(@codigoFabricante INT, @nombre VARCHAR(100))
AS
BEGIN
	BEGIN TRY
		DECLARE @salida VARCHAR(200)

		IF @codigoFabricante IS NULL 
			BEGIN
				SET @salida = @salida + 'CodFabricante, '
			END

		IF @nombre IS NULL
			BEGIN
				SET @SALIDA = @salida + 'nombre, '
			END

		IF @salida <> ''
			BEGIN
				SET @salida = 'Faltan los parametros: ' + @salida
				PRINT @salida
				RETURN -1
			END

		UPDATE FABRICANTE
			SET nombre = @nombre
			WHERE codigo = @codigoFabricante

		IF @@ROWCOUNT = 1
			BEGIN
				PRINT 'Se ha actualizado el fabricante correctamente'
			END
		ELSE
			BEGIN
				PRINT 'No se ha actualizado niguna fila'
				RETURN -2
			END

	END TRY

	BEGIN CATCH
		PRINT CONCAT('Error= ', ERROR_NUMBER(),
					'Linea= ', ERROR_LINE(),
					'Proced= ', ERROR_PROCEDURE())
	END CATCH
END

-----declararlo
GO
DECLARE @codFabricante INT = 9
DECLARE @nombre VARCHAR(100) = 'Pepe'
DECLARE @ret INT

EXEC @ret = ModificarFabricante @codFabricante, @nombre

IF @ret <> 0
	RETURN


--------------------------------------------------
----------------------------------------
--Eliminar Fabricante

--Update Fabricante
GO
CREATE OR ALTER PROCEDURE devolverFabricante(@codFabricante INT)
AS
BEGIN 
	BEGIN TRY
		DECLARE @nombre VARCHAR(100)
		IF @codFabricante IS NULL
		BEGIN
			PRINT 'El parametro nombre es obligatorio'
			RETURN -1
		END

		SELECT @nombre = nombre
			FROM FABRICANTE
			WHERE codigo = @codFabricante

		PRINT @nombre
		
	END TRY

	BEGIN CATCH
		PRINT CONCAT('Error= ', ERROR_NUMBER(),
					'Linea= ', ERROR_LINE(),
					'Desc= ', ERROR_MESSAGE(),
					'Proced= ', ERROR_PROCEDURE())
	END CATCH
END 

---Llamando al procedimiento
DECLARE @nombre VARCHAR(100) = 'Apple'
DECLARE @codFabricante INT 
DECLARE @ret INT

EXEC @ret = crearFabricante @nombre, @codFabricante OUTPUT
IF @ret <> 0
	RETURN

PRINT CONCAT('El nuevo fabricante es el: ', @codFabricante)


----------------------------------------
---------------------------
USE TIENDA
GO
CREATE OR ALTER PROCEDURE EliminarFabricante(@codigoFabricante INT)
AS
BEGIN
	BEGIN TRY
		DECLARE @salida VARCHAR(200)

		IF @codigoFabricante IS NULL 
			BEGIN
				SET @salida = @salida + 'CodFabricante, '
			END

		IF @salida <> ''
			BEGIN
				SET @salida = 'Faltan los parametros: ' + @salida
				PRINT @salida
				RETURN -1
			END

		DELETE FROM FABRICANTE
			WHERE codigo = @codigoFabricante

		IF @@ROWCOUNT = 1
			BEGIN
				PRINT 'Se ha liminado el fabricante correctamente'
			END
		ELSE
			BEGIN
				PRINT 'No se ha eliminado niguna fila'
				RETURN -2
			END

	END TRY

	BEGIN CATCH
		PRINT CONCAT('Error= ', ERROR_NUMBER(),
					'Linea= ', ERROR_LINE(),
					'Proced= ', ERROR_PROCEDURE())
	END CATCH
END

-----declararlo
GO
DECLARE @codFabricante INT = 1002
DECLARE @ret INT

EXEC @ret = EliminarFabricante @codFabricante

IF @ret <> 0
	RETURN

PRINT 'Procedimiento finalizado correctamente'
-------------------------------------
---------------------------------
--Read
GO
CREATE OR ALTER PROCEDURE devolverFabricante(@codFabricante INT, 
											@nombre VARCHAR(100) OUTPUT)
AS
BEGIN
	BEGIN TRY
		IF @codFabricante IS NULL
		BEGIN
			PRINT 'El codigo fabricante es obligatorio'
			RETURN -1
		END

		SELECT @nombre = nombre
			FROM FABRICANTE
			WHERE codigo = @codFabricante

		IF @nombre IS NULL
		BEGIN
			PRINT CONCAT('El fabricante ', @codFabricante, ' no existe.')
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
---dECLARLA
DECLARE @codFabricante INT = 99
DECLARE @nombre VARCHAR(100)
DECLARE @ret

EXEC @ret = devolverFabricante @codFabricante, @nombre OUTPUT

IF @ret <> 0 
	RETURN

PRINT @nombre

