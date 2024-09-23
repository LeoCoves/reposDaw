USE JARDINERIA
SET IMPLICIT_TRANSACTIONS OFF
						---------------------------
						-- EJERCICIOS UD7 - TSQL -- 
						---------------------------
-------------------------------------------------------------------------------------------
-- NOTA: Recuerda cuidar la limpieza del código (tabulaciones, nombres de tablas en mayúscula,
--		nombres de variables en minúscula, poner comentarios sin excederse, código organizado y fácil de seguir, etc.)
-------------------------------------------------------------------------------------------
-- 1. Crea un script que use un bucle para calcular la potencia de un número.
--		Tendremos dos variables: el número y la potencia
--
--		Ejemplo.
--		Número = 3		Potencia = 4		Resultado = 3*3*3*3 = 81
--
--		Si el número o la potencia son 0 o <0 devolverá el mensaje: “La operación no se puede realizar.
-------------------------------------------------------------------------------------------
DECLARE @numero INT = 3
DECLARE @potencia INT = 4
DECLARE @i INT = 1
DECLARE @resultado INT = 1
DECLARE @texto VARCHAR(50) = ''

BEGIN TRY
	IF(@potencia <= 0)
	BEGIN
		PRINT ('La operacion no se puede realizar')
	END

	ELSE
		BEGIN
			WHILE (@i <= @potencia)
			BEGIN
				SET @resultado *= @numero
				SET @i += 1
				SET @texto += CONCAT(@numero, '*')
			END
		PRINT CONCAT('Resultado = ', @texto, ' = ', @resultado)
		END
END TRY

BEGIN CATCH 
	PRINT ('Error')
END CATCH

-------------------------------------------------------------------------------------------
-- 2. Crea un script que calcule las soluciones de una ecuación de segundo grado ax^2 + bx + c = 0
--
--	Debes crear variables para los valores a, b y c.
--  Al principio debe comprobarse que los tres valores son positivos, en otro caso, 
--		se devolverá el mensaje 'Cálculo no implementado'
--	
--	Consulta esta página para obtener la fórmula a implementar (recuerda que habrá DOS soluciones): 
--		http://recursostic.educacion.es/descartes/web/Descartes1/4a_eso/Ecuacion_de_segundo_grado/Ecua_seg.htm#solgen

--	Salida esperada para los valores: a=3, b=-4, c=1 --> sol1= 1 y sol2= 0.33
--	
--	NOTA: Si no sale lo mismo, te recomiendo revisar bien el orden de prioridad de los operadores... ()
-------------------------------------------------------------------------------------------
DECLARE @a DECIMAL(3,2) = 3 
DECLARE @b DECIMAL(3,2) = -4
DECLARE @c DECIMAL(3,2) = 1
DECLARE @formula DECIMAL(3,2) = @b * @b - 4 * @a * @c
DECLARE @sol1 DECIMAL(3,2), @sol2 DECIMAL(3,2)

BEGIN TRY
	IF(@a >= 0 AND @c >= 0)
	BEGIN
		SET @sol1 = (-@b + SQRT(@formula)) / (2 * @a)
		SET @sol2 = (-@b - SQRT(@formula)) / (2 * @a)
		PRINT CONCAT('Sol1: ', @sol1)
		PRINT CONCAT('Sol1: ', @sol2)
	END

	ELSE
	BEGIN
		PRINT('Calculo implementado')
	END
END TRY

BEGIN CATCH
	PRINT ('Calculo no implementado')
END CATCH


-------------------------------------------------------------------------------------------
-- 3. Crea un script que calcule la serie de Fibonacci para un número dado.

-- La sucesión es: 1,1,2,3,5,8,13,21,34,55,89,144,233,377,610,987,1597...
-- Si te fijas, se calcula sumando el número anterior al siguiente:
--	Ejemplo. Si se introduce el numero 3 significa que tendremos que hacer 3 iteraciones:
--			ini = 1
--			0+1 = 1
--			1+1 = 2
--			2+1 = 3
--			3+2 = 5
--			5+3 = 8
--			...
-- 
--	Ayuda: Quizás necesites guardar en algún sitio el valor actual de la serie antes de sumarlo...
-------------------------------------------------------------------------------------------
DECLARE @inicio INT = 1
DECLARE @actual INT = 1
DECLARE @anterior INT = 0
DECLARE @cont INT = 1
DECLARE @sumandos VARCHAR(10) = 'ini'

BEGIN TRY
	WHILE (@cont <= 10)
	BEGIN
		PRINT CONCAT(@sumandos, ' = ', @inicio)
		SET @sumandos = CONCAT(@anterior, ' + ', @inicio)
		SET @inicio = @anterior + @actual
		SET @anterior = @actual
		SET @actual = @inicio
		SET @cont += 1
	END
END TRY

BEGIN CATCH
	PRINT ('Error')
END CATCH


-------------------------------------------------------------------------------------------
-- 4. Utilizando la BD JARDINERIA, crea un script que realice lo siguiente:
--		Obtén el nombre del cliente con código 3 y guárdalo en una variable
--		Obtén el número de pedidos realizados por dicho cliente y guárdalo en una variable
--		Muestra por pantalla el mensaje: 'El cliente XXXX ha realizado YYYY pedidos.'
--		
--		Resultado esperado: El cliente Gardening Associates ha realizado 9 pedidos.
--
--	    Reto opcional: Implementa el script utilizando una única consulta.
-------------------------------------------------------------------------------------------
DECLARE @codCliente INT = 3
DECLARE @nombreCliente VARCHAR(50)
DECLARE @numPedidos INT

SELECT @nombreCliente = nombre_cliente
	FROM CLIENTES
	WHERE codCliente = @codCliente

SELECT @numPedidos = COUNT(codPedido) 
	FROM PEDIDOS
	WHERE codCliente = @codCliente

PRINT CONCAT('El cliente ', @nombreCliente, ' ha realizado ', @numPedidos, ' pedidos')


-------------------------------------------------------------------------------------------
-- 5. Utilizando la BD JARDINERIA, crea un script que realice lo siguiente:
--		Obtén el nombre y los apellidos de todos los empleados de la empresa
--		Deberás mostrar cada uno de ellos línea a línea utilizando PRINT
--		
--		Salida esperada:
--			Magaña Perez, Marcos
--			López Martinez, Ruben
--			Soria Carrasco, Alberto
--			Solís Jerez, Maria
--			...
--
--		Reto opcional: Modifica el script anterior para que muestre sólo los que trabajen en la oficina de Londres
--		Salida esperada:
--			Johnson , Amy
--			Westfalls , Larry
--			Walton , John
-------------------------------------------------------------------------------------------
GO
DECLARE @contador INT = 1
DECLARE @nombre VARCHAR(50)
DECLARE @apellido1 VARCHAR(50)
DECLARE @apellido2 VARCHAR(50)
DECLARE @maxCodEmp INT

SELECT @maxCodEmp = MAX(codEmpleado)
	FROM EMPLEADOS

WHILE (@contador <= @maxCodEmp)
BEGIN
	SELECT @nombre = nombre,
		@apellido1 = apellido1,
		@apellido2 = apellido2
		FROM EMPLEADOS
		WHERE codEmpleado = @contador

	IF (@nombre IS NOT NULL AND @apellido1 IS NOT NULL)
	BEGIN
		PRINT CONCAT(@apellido1, ' ', @apellido2, ', ', @nombre)
	END
	SET @contador += 1
END

--Reto opcional-------------------------
GO
DECLARE @contador INT = 1
DECLARE @nombre VARCHAR(50)
DECLARE @apellido1 VARCHAR(50)
DECLARE @apellido2 VARCHAR(50)
DECLARE @maxCodEmp INT
DECLARE @codOficina CHAR(6)

SELECT @codOficina = codOficina
	FROM OFICINAS
	WHERE ciudad = 'Londres'

SELECT @maxCodEmp = MAX(codEmpleado)
	FROM EMPLEADOS
	WHERE codOficina = @codOficina

WHILE (@contador <= @maxCodEmp)
BEGIN
	SELECT @nombre = nombre,
		@apellido1 = apellido1,
		@apellido2 = apellido2
		FROM EMPLEADOS
		WHERE codEmpleado = @contador
		AND codOficina = @codOficina

	IF (@nombre IS NOT NULL AND @apellido1 IS NOT NULL)
	BEGIN
		PRINT CONCAT(@apellido1, ' ', @apellido2, ', ', @nombre)
	END

	SET @contador += 1
END

-------------------------------------------------------------------------------------------
-- 6. Utilizando la BD JARDINERIA, crea un script que realice lo siguiente:
--		Reutilizando el script del ejercicio 4, agrega la siguiente información a la salida:
--			Número de pedidos realizados por cada cliente
--			NOTA: Realízalo utilizando una consulta específica para obtener el número de pedidos de cada cliente.

--		Salida esperada:
--			El cliente GoldFish Garden ha realizado 11 pedidos.
--			El cliente Gardening Associates ha realizado 9 pedidos.
--			El cliente Gerudo Valley ha realizado 5 pedidos.
--			El cliente Tendo Garden ha realizado 5 pedidos.
--			El cliente Lasas S.A. ha realizado 0 pedidos.
--			...
--
--		Reto opcional:
--		Muestra también el coste total de todos los pedidos para cada cliente.
--
--		Salida esperada:
--			El cliente GoldFish Garden ha realizado 11 pedidos por un coste total de 10365.00.
--			El cliente Gardening Associates ha realizado 9 pedidos por un coste total de 13726.00.
--			El cliente Gerudo Valley ha realizado 5 pedidos por un coste total de 81849.00.
--			El cliente Tendo Garden ha realizado 5 pedidos por un coste total de 23794.00.
--			El cliente Lasas S.A. ha realizado 0 pedidos por un coste total de 0.00.
--			...
-------------------------------------------------------------------------------------------
DECLARE @i INT = 1
DECLARE @codCli INT 
DECLARE @nombreCli VARCHAR(50)
DECLARE @apellidoCli VARCHAR(50)
DECLARE @codCliMax INT
DECLARE @numPedidos INT


SELECT @codCliMax = MAX(codCliente)
	FROM CLIENTES

WHILE (@i <= @codCliMax)
BEGIN
	SET @codCli = @i

	SELECT @nombreCli = nombre_cliente,
			@apellidoCli = apellido_contacto
		FROM CLIENTES
		WHERE codCliente = @codCli

	SELECT @numPedidos = COUNT(codPedido) 
		FROM PEDIDOS
		WHERE codCliente = @codCli



	IF (@nombreCli IS NOT NULL AND @apellidoCli IS NOT NULL)
	BEGIN
		PRINT CONCAT('El cliente ',@nombreCli, ' ', @apellidoCli, ' ha realizado ', @numPedidos, ' pedidos')
	END
	SET @i += 1
END


--Reto Opcional--------------------------
DECLARE @i INT = 1
DECLARE @codCli INT 
DECLARE @nombreCli VARCHAR(50)
DECLARE @apellidoCli VARCHAR(50)
DECLARE @codCliMax INT
DECLARE @numPedidos INT
DECLARE @costeTotal DECIMAL(7,2)

SELECT @codCliMax = MAX(codCliente)
	FROM CLIENTES

WHILE (@i <= @codCliMax)
BEGIN
	SET @codCli = @i

	SELECT @nombreCli = nombre_cliente,
			@apellidoCli = apellido_contacto
		FROM CLIENTES
		WHERE codCliente = @codCli

	SELECT @numPedidos = COUNT(codPedido) 
		FROM PEDIDOS
		WHERE codCliente = @codCli

	SELECT @costeTotal = SUM(total_linea)
		FROM DETALLE_PEDIDOS
		WHERE codPedido IN (SELECT codPedido
								FROM PEDIDOS
								WHERE codCliente = @codCli
								GROUP BY codPedido)

	IF (@nombreCli IS NOT NULL AND @apellidoCli IS NOT NULL)
	BEGIN
		IF (@costeTotal IS NULL)
		BEGIN
			SET @costeTotal = 0.00
		END

		PRINT CONCAT('El cliente ', @nombreCli, ' ', @apellidoCli, ' ha realizado ', @numPedidos, ' pedidos por un coste total de ', @costeTotal)
	END
	SET @i += 1
END

-------------------------------------------------------------------------------------------
-- 7. Utilizando la BD JARDINERIA, crea un script que realice las siguientes operaciones:
--	Importante: debes utilizar TRY/CATCH y Transacciones si fueran necesarias.

--		Crea una nueva oficina (datos inventados)
--		Crea un nuevo empleado con datos inventados (el codEmpleado a insertar debes obtenerlo automáticamente)
--		Crea un nuevo cliente (datos inventados) (el codCliente a insertar debes obtenerlo automáticamente)
--		Asigna como representante de ventas el cliente anterior
-------------------------------------------------------------------------------------------
DECLARE @codOfi CHAR(6)
DECLARE @codEmp INT
DECLARE @codCliente INT

BEGIN TRY
	BEGIN TRAN
		SET @codOfi = 'ALC-ES'
		IF (@codOfi IS NOT NULL)
		BEGIN
			INSERT INTO OFICINAS
				VALUES(@codOfi, 'Alicante', 'España', '03001',
						'+34 93 4932048', 'Avenida España, 44', NULL)

			SELECT @codEmp = MAX(codEmpleado) + 1
				FROM EMPLEADOS

			INSERT INTO EMPLEADOS
				VALUES(@codEmp, 'Ivan', 'Rumbeu', NULL,
						'3345', 'r.ivan@jardineria.es', 'Representante Ventas',
						1300.00, @codOfi, 29)

			SELECT @codCliente = MAX(codCliente) + 1
				FROM CLIENTES

			INSERT INTO CLIENTES
				VALUES(@codCliente, 'Karim Abbou', 'Karim', 'Abbou',
						'655555555', 'karim@jardineria.es', 'calle street',
						NULL, 'Alicante', 'Spain',
						'03222', @codEmp, 1000.00)
			
		END

		RAISERROR(50001, 11, 1)

	COMMIT
END TRY

BEGIN CATCH	
	ROLLBACK 
	PRINT CONCAT('CodError: ', ERROR_NUMBER(),
				', Descripcion: ', ERROR_MESSAGE(),
				', Linea: ', ERROR_LINE())
END CATCH

SELECT * 
FROM OFICINAS

-------------------------------------------------------------------------------------------
-- 8. Utilizando la BD JARDINERIA, crea un script que realice las siguientes operaciones:
--	Importante: debes utilizar TRY/CATCH y Transacciones si fueran necesarias.
--
--		Debes eliminar la oficina, el empleado y el cliente creados en el apartado anterior.
--		Debes crear variables con los identificadores de clave primaria para eliminar
--			todos los datos de cada una de las tablas en una sola ejecución
-------------------------------------------------------------------------------------------
DECLARE @codOfi CHAR(6) = 'ALC-ES'
DECLARE @codEmp INT
DECLARE @codCliente INT

BEGIN TRY
	BEGIN TRAN

		SELECT @codCliente = MAX(codCliente)
			FROM CLIENTES

		DELETE FROM CLIENTES
		WHERE codCliente = @codCliente

		SELECT @codEmp = MAX(codEmpleado)
			FROM EMPLEADOS

		DELETE FROM EMPLEADOS
		WHERE codEmpleado = @codEmp

		DELETE FROM OFICINAS
		WHERE codOficina = @codOfi

		RAISERROR(50001, 11, 1)

	COMMIT
END TRY

BEGIN CATCH	
	ROLLBACK 
	PRINT CONCAT('CodError: ', ERROR_NUMBER(),
				', Descripcion: ', ERROR_MESSAGE(),
				', Linea: ', ERROR_LINE())
END CATCH



-------------------------------------------------------------------------------------------
-- 9. Utilizando la BD JARDINERIA, crea un script que realice lo siguiente:
--		Crea un nuevo cliente (invéntate los datos). No debes indicar directamente el código, 
--			sino buscar cuál le tocaría con una SELECT y guardarlo en una variable.

--		Crea un nuevo pedido para dicho cliente (fechaPedido será la fecha actual, fecha esperada 10 días 
--				después de la fecha de pedido, fecha entrega y comentarios a NULL y estado PENDIENTE)
--			Dicho pedido debe constar de dos productos (los códigos de producto se declaran como variables y se utilizan después)
--			El precio de cada producto debes obtenerlo utilizando SELECT antes de insertarlo en DETALLE_PEDIDOS,
--			de tal manera que, si modificamos los códigos de producto, el script seguirá funcionando.
--			La cantidad de los productos comprados puede ser la que tú quieras.

--		Recuerda que debes utilizar TRANSACCIONES (si fueran necesarias) y TRY/CATCH

--		Reto opcional:
--			Crea también un nuevo pago para dicho cliente cuyo importe coincida con lo que cuesta el pedido completo
--				Puedes indicar directamente el idtransaccion como 'ak-std-000026', aunque es mejor que lo obtengas dinámicante
--				utilizando funciones de SQL Server (piensa que los 6 últimos caracteres son números...)
--				Forma de pago debe ser: 'PayPal' y Fechapago la del día
-------------------------------------------------------------------------------------------
DECLARE @codCliente INT
DECLARE @codPedido INT
DECLARE @fechaPedido DATE
DECLARE @codProd INT 
DECLARE @iva DECIMAL(3,2) = 1.18
DECLARE @precio_unidad DECIMAL(9,2)
DECLARE @cantidad INT


BEGIN TRY
	BEGIN TRAN

		--insertar Cliente
		SELECT @codCliente = MAX(codCliente) + 1
			FROM CLIENTES

		INSERT INTO CLIENTES
			VALUES(@codCliente, 'Leo Coves', 'Leonardo', 'Coves',
					'55245454656', 'leocoves@jardindeflores.com', 'Mozart 54',
					NULL, 'Tarragona', 'Spain',
					'05421', 19, 12000.00)

		--insertar Pedido en PEDIDOS
		SELECT @codPedido = MAX(codPedido) + 1
			FROM PEDIDOS

		SET @fechaPedido = GETDATE()

		INSERT INTO PEDIDOS
			VALUES(@codPedido, @fechaPedido, DATEADD(DAY, 10, @fechaPedido), 
					NULL, 'P', NULL, @codCliente)


		--insertar pedido en DETALLE PEDIDOS con el primer producto
		SET @codProd = 1
		SET @cantidad = 44

		SELECT @precio_unidad = precio_unidad
			FROM DETALLE_PEDIDOS
			WHERE codProducto = @codProd

		INSERT INTO DETALLE_PEDIDOS
			VALUES(@codPedido, @codProd, @cantidad,
					@precio_unidad, 1, @iva)

		--insertar pedido en DETALLE PEDIDOS con el segundo producto
		SET @codProd = 2
		SET @cantidad = 6

		SELECT @precio_unidad = precio_unidad
			FROM DETALLE_PEDIDOS
			WHERE codProducto = @codProd

		INSERT INTO DETALLE_PEDIDOS
			VALUES(@codPedido, @codProd, @cantidad,
					@precio_unidad, 2, @iva)



		RAISERROR(50001, 11, 1)
	COMMIT
END TRY

BEGIN CATCH
	ROLLBACK
	PRINT CONCAT('CodError: ', ERROR_NUMBER(),
				', Descripcion: ', ERROR_MESSAGE(),
				', Linea: ', ERROR_LINE())
END CATCH


