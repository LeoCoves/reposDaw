USE JARDINERIA

DECLARE @minCliente INT
DECLARE @maxCliente INT 
DECLARE @nombreCliente VARCHAR(100)

SELECT @minCliente = MIN(codCliente),
		@maxCliente = MAX(codCliente)
	FROM CLIENTES


WHILE (@minCliente <= @maxCliente)
BEGIN 
	--Codigo
	SELECT @nombreCliente = nombre_cliente
		FROM CLIENTES
		WHERE codCliente = @minCliente

	IF @nombreCliente IS NOT NULL
	BEGIN
		PRINT @nombreCliente
	END

	SET @minCliente += 1
END

-------------------------
DECLARE @dividendo INT, @divisor INT, @resultado INT

SET @dividendo = 50

SET @divisor = FLOOR(RAND()*10)

BEGIN TRY
	SET @resultado = @dividendo / @divisor
	PRINT @resultado
END TRY

BEGIN CATCH
	PRINT CONCAT('COD_ERROR: ', ERROR_NUMBER(), CHAR(10),
			'ERROR_MSG: ', ERROR_MESSAGE(), CHAR(10),
			'ERROR_LINE: ', ERROR_LINE())
	RETURN
END CATCH