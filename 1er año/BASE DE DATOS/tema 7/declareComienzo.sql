DECLARE @varPrecio SMALLINT = 75

SELECT *
	FROM PRODUCTOS
	WHERE precio_venta >= @varPrecio

--------------------------------------

DECLARE @codCategoria CHAR(2) = 'FR'
DECLARE @nombre VARCHAR(50) = 'Pera'

SELECT *
	FROM PRODUCTOS
	WHERE codCategoria = @codCategoria
		AND nombre LIKE CONCAT(@nombre, '%')


--------------------------------------
use JARDINERIA

EXEC sp_tables

EXEC sp_columns PRODUCTOS

-------------------------------------
DECLARE @codCategoria CHAR(2) = 'FR'
DECLARE @nombre VARCHAR(70) = 'Pera'

SELECT *
	FROM PRODUCTOS
	WHERE codCategoria = @codCategoria
	AND NOMBRE LIKE CONCAT('%', @nombre, '%')

------------------------------------------
DECLARE @precioMin DECIMAL(9,2), @precioMax DECIMAL(9,2)

SELECT @precioMin = MIN(precio_venta),
		@precioMax = MAX(precio_venta)
	FROM PRODUCTOS

PRINT CONCAT('El precio mas barato es: ', @precioMin, ' y el precio mas caro es: ', @precioMax)

----------------------------------
--Crea una variable codCategoria que devuelva el codigo
--de la categoria que tenga mas productos

--Declaro la variable
DECLARE @codCategoriaMasProductos char(2)
DECLARE @nombreCategoria VARCHAR(50)

--Obtengo el codCategoria con mas Productos
SELECT top(1) @codCategoriaMasProductos = codCategoria
	FROM PRODUCTOS
	GROUP BY codCategoria
	ORDER BY COUNT(codProducto) DESC
	
--Muestro el nombre de codCategoria
SELECT @nombreCategoria = nombre
	FROM CATEGORIA_PRODUCTOS
	WHERE codCategoria = @codCategoriaMasProductos

--Lo muestro por pantalla
PRINT @codCategoriaMasProductos


-----------------------------------------------
DECLARE @precioMin DECIMAL(9,2) 
DECLARE @precioMax DECIMAL(9,2)

SET @precioMin = 8.69

SELECT TOP(1)
		@precioMin = precio_venta
	FROM PRODUCTOS
	ORDER BY precio_venta ASC

-------------------------------------------------
DECLARE @nombre		VARCHAR(50)
DECLARE @apellido1	VARCHAR(50)
DECLARE @apellido2	VARCHAR(50)

SELECT @nombre = nombre,
		@apellido1 = apellido1,
		@apellido2 = apellido2
	FROM EMPLEADOS
	WHERE codEmpleado = 7

--------------------------------------------------

USE JARDINERIA

						---------------------------
						-- EJERCICIOS UD7 - TSQL -- 
						---------------------------
-------------------------------------------------------------------------------------------
-- NOTA: Recuerda cuidar la limpieza del código (tabulaciones, nombres de tablas en mayúscula,
--		nombres de variables en minúscula, poner comentarios sin excederse, código organizado y fácil de seguir, etc.)
-------------------------------------------------------------------------------------------
-- ¡IMPORTANTE! Siempre que sea posible deberás utilizar variables 	(no es correcto indicar directamente el valor en una SELECT)
--  Esta práctica incorrecta se conoce como "hardcoding" y genera muchos problemas en el código y en su depuración
--  Aquí tenéis más información: https://es.wikipedia.org/wiki/Hard_code
-------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------
-- 1. Crea un script que obtenga el nombre de la gama que tenga más cantidad de productos diferentes
--
-- Salida: 'La gama que más productos tiene es Ornamentales'
-------------------------------------------------------------------------------------------
EXEC sp_columns PRODUCTOS
EXEC sp_columns CATEGORIA_PRODUCTOS

DECLARE @codCategoria CHAR(2)
DECLARE @nombreCategoria VARCHAR(50)

--Obtenemos el codCategoria
SELECT TOP(1) 
		@codCategoria = codCategoria
	FROM PRODUCTOS
	GROUP BY codCategoria
	ORDER BY COUNT(codProducto) DESC

--Obtenemos el nombre
SELECT @nombreCategoria = nombre
	FROM CATEGORIA_PRODUCTOS
	WHERE codCategoria = @codCategoria

PRINT CONCAT('La gama que tiene mas productos tiene es ',@nombreCategoria)


-------------------------------------------------------------------------------------------
-- 2. Crea un script que obtenga el nombre del empleado con id 7 y el nombre de su jefe
--
-- Salida: 'El empleado Carlos Soria Jimenez tiene como jefe al empleado Alberto Soria Carrasco'
-------------------------------------------------------------------------------------------
EXEC sp_columns EMPLEADOS

DECLARE @nombreCompletoEmpleado VARCHAR(100)
DECLARE @idJefe			VARCHAR(100)
DECLARE @nombreCompletoJefe		VARCHAR(100)

SELECT @nombreCompletoEmpleado = CONCAT(nombre, ' ', apellido1, ' ', apellido2),
		@idJefe = codEmplJefe
	FROM EMPLEADOS
	WHERE codEmpleado = 7

SELECT @nombreCompletoJefe =  CONCAT(nombre, ' ', apellido1, ' ', apellido2)
	FROM EMPLEADOS
	WHERE codEmpleado = @idJefe

PRINT CONCAT('El empleado ', @nombreCompletoEmpleado, ' tiene como jefe al empleado ', @nombreCompletoJefe)

------Otra manera----------------------------------------------------
DECLARE @nombreCompletoEmpleado VARCHAR(100)
DECLARE @nombreCompletoJefe		VARCHAR(100)
DECLARE @codEmpleado INT = 7

SELECT @nombreCompletoEmpleado = CONCAT(e.nombre, ' ', e.apellido1, ' ', e.apellido2),
		@nombreCompletoJefe =  CONCAT(j.nombre, ' ', j.apellido1, ' ', j.apellido2)
	FROM EMPLEADOS e,
		EMPLEADOS j
	WHERE e.codEmpleado = @codEmpleado
	AND e.codEmplJefe = j.codEmpleado

PRINT CONCAT('El empleado ', @nombreCompletoEmpleado, ' tiene como jefe al empleado ', @nombreCompletoJefe)

-------------------------------------------------------------------------------------------
-- 3. Crea un script que devuelva el número de pedidos realizados por el cliente 9
--
-- Salida: 'El cliente Naturagua ha realizado 5 pedido/s'
-------------------------------------------------------------------------------------------
DECLARE @codCliente INT = 9
DECLARE @numPedidos INT
DECLARE @nombreCliente VARCHAR(100)

SELECT @nombreCliente = nombre_cliente
	FROM CLIENTES
	WHERE codCliente = @codCliente

SELECT @numPedidos = COUNT(codPedido)
	FROM PEDIDOS
	WHERE codCliente = @codCliente

PRINT CONCAT('El cliente ', @nombreCliente, ' ha realizado ', @numPedidos, ' pedido/s')


-------------------------------------------------------------------------------------------
-- 4. Crea un script que dado un codPedido en una variable, obtenga la siguiente información:
--		nombre_cliente, Fecha pedido, estado
--
-- Salida: 'El pedido XXXX realizado por el cliente YYYYYYY se realizó el ZZ/ZZ/ZZZZ y su estado es EEEEEEEE
-------------------------------------------------------------------------------------------
DECLARE @codPedido INT
DECLARE @codCliente INT
DECLARE @nombre_cliente VARCHAR(100)
DECLARE @fecha_pedido DATE
DECLARE @codEstado CHAR(1)
DECLARE @estadoPedido VARCHAR(50)

SELECT TOP(1)@codPedido = codPedido,
		@codCliente = codCliente,
		@fecha_pedido = fecha_pedido,
		@codEstado = codEstado
	FROM PEDIDOS
	ORDER BY NEWID()

SELECT @nombre_cliente = nombre_cliente
	FROM CLIENTES
	WHERE codCliente = @codCliente

SELECT @estadoPedido = descripcion
	FROM ESTADOS_PEDIDO
	WHERE codEstado = @codEstado

PRINT CONCAT('El pedido ', @codPedido, ' realizado por el cliente ', @nombre_cliente, ' se realizo el ', @fecha_pedido, ' y su estado es ', @estadoPedido)


-------------------------------------------------------------------------------------------
-- 5. Crea un script que dadas dos variables: porcentaje y gama
--		Incremente el precio de los productos de dicha gama en el porcentaje que se le pasa
--
-- Salida: 'Se ha aumentado el precio un XXXX% de la gama YYYY'
-------------------------------------------------------------------------------------------

EXEC sp_columns PRODUCTOS

DECLARE @porcentaje DECIMAL(3,2) = 2.21
DECLARE @codCategoria CHAR(1)
DECLARE @nombreCategoria VARCHAR(100)




UPDATE PRODUCTOS
SET precio_venta = precio_venta * (1+(@porcentaje/100))
WHERE codCategoria = @codCategoria

SELECT @nombreCategoria = nombre
	FROM CATEGORIA_PRODUCTOS
	WHERE codCategoria = @codCategoria

PRINT CONCAT('Se ha aumentado el precio un ', @porcentaje , '% de la gama ', @nombreCategoria)

-------------------------------------------------------------------------------------------
-- 6. Crea un script que devuelva cuántos clientes han realizado algún pedido de
--   al menos 3 productos (siendo el número de productos una variable).
--	
-- Salida: 'Existen XXXX clientes en la BD que han realizado pedidos de al menos YYYY productos'
-------------------------------------------------------------------------------------------
EXEC sp_columns PEDIDOS
EXEC sp_columns DETALLE_PEDIDOS

DECLARE @numClientes INT
DECLARE @codPedido INT
DECLARE @numProductos INT = 3



SELECT DISTINCT codCliente
	FROM PEDIDOS
	WHERE codPedido IN 	(SELECT codPedido
							FROM DETALLE_PEDIDOS
							GROUP BY codPedido
							HAVING COUNT(*) >= 3) 



PRINT CONCAT('Existen ', @numClientes, ' clientes en la BD que han realizado pedidos de al menos ', @numProductos, ' productos')




-------------------------------------------------------------------------------------------
-- 7. Crea un script que a partir de una variable codCliente devuelva el nombre completo de su
-- 		representante de ventas y la ciudad de la oficina en la que trabaja.
--	
-- Salida: 'El cliente XXXX tiene como representante a YYYY y trabaja en la ciudad de ZZZZ'
-------------------------------------------------------------------------------------------