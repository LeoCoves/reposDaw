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

DECLARE recorrer_Nombre	CURSOR FOR
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
DECLARE @nombre VARCHAR(100)
DECLARE @precio DECIMAL(9,2)

DECLARE recorrer_Nombre	CURSOR FOR
SELECT nombre, precio
	FROM PRODUCTO

OPEN recorrer_Nombre

FETCH NEXT FROM recorrer_Nombre INTO @nombre, @precio

WHILE @@FETCH_STATUS = 0
BEGIN
	PRINT CONCAT('El producto ', @nombre, ' tiene un precio de ', @precio, '€.')
	FETCH NEXT FROM recorrer_Nombre INTO @nombre, @precio

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
DECLARE @codFabricante INT
DECLARE @nombreFabricante VARCHAR(50)

DECLARE Cur_Fabricante CURSOR FOR
SELECT codigo, nombre
	FROM FABRICANTE

OPEN Cur_Fabricante

FETCH NEXT FROM Cur_Fabricante INTO @codFabricante, @nombreFabricante

WHILE @@FETCH_STATUS = 0
BEGIN
	DECLARE Cur_Producto CURSOR FOR
	SELECT precio
		FROM PRODUCTO
		WHERE codigo_fabricante = @codFabricante

	DECLARE @precio DECIMAL(7,2), @acumulado DECIMAL(9,2)
	SET @acumulado = 0

	OPEN Cur_Producto

	FETCH NEXT FROM Cur_Producto INTO @precio

	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @acumulado = @acumulado + @precio
		FETCH NEXT FROM Cur_Producto INTO @precio
	END

	CLOSE Cur_Producto
	DEALLOCATE Cur_Producto

	PRINT CONCAT(@nombreFabricante, ' tiene un total de ', @acumulado, '€ en productos.')
	FETCH NEXT FROM Cur_Fabricante INTO @codFabricante, @nombreFabricante
END

CLOSE Cur_Fabricante
DEALLOCATE Cur_Fabricante


/*4.- Cursor de Empleados en BD JARDINERIA
Crea un script que recorra con cursores la tabla EMPLEADOS y que muestre los siguientes
datos de cada empleado: nombre, apellido1, apellido2 y email. Deberás formatearlos
utilizando la función CONCAT*/
USE JARDINERIA
GO
DECLARE @nombreEmp VARCHAR(50), @apellido1Emp VARCHAR(50), @apellido2Emp VARCHAR(50), @email VARCHAR(50)

DECLARE Cur_Empleados CURSOR FOR
SELECT nombre, apellido1, apellido2, email
FROM EMPLEADOS

OPEN Cur_Empleados
FETCH NEXT FROM Cur_Empleados INTO @nombreEmp, @apellido1Emp, @apellido2Emp, @email

WHILE @@FETCH_STATUS = 0
BEGIN
	PRINT CONCAT(@nombreEmp, ' ', @apellido1Emp, ' ', @apellido2Emp, ' / Email: ', @email)
	FETCH NEXT FROM Cur_Empleados INTO @nombreEmp, @apellido1Emp, @apellido2Emp, @email
END

CLOSE Cur_Empleados
DEALLOCATE Cur_Empleados




/*5.- Cursores anidados en BD JARDINERIA
En este script deberás utilizar un cursor que recorra la tabla PEDIDOS y dentro de éste
cursor otro que recorra la tabla DETALLE_PEDIDOS. El objetivo es que dentro de este
segundo cursor se acumule el total por línea de cada pedido y que finalmente se muestre el
total acumulado para cada pedido.
“Nº Pedido XXXX tiene un coste total de XXXX €”*/
USE JARDINERIA
GO
DECLARE @codPedido INT

DECLARE Cur_Pedidos CURSOR FOR
SELECT codPedido
	FROM PEDIDOS

OPEN Cur_Pedidos
FETCH NEXT FROM Cur_Pedidos INTO @codPedido

WHILE @@FETCH_STATUS = 0
BEGIN
	DECLARE Cur_DetallePedido CURSOR FOR
	SELECT cantidad * precio_unidad
		FROM DETALLE_PEDIDOS
		WHERE codPedido = @codPedido


	DECLARE @total DECIMAL(9,2), @acumulado DECIMAL(9,2)
	SET @acumulado = 0

	OPEN Cur_DetallePedido
	FETCH NEXT FROM Cur_DetallePedido INTO @total

	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @acumulado = @acumulado + @total
		SET @total = 0
		FETCH NEXT FROM Cur_DetallePedido INTO @total
	END

	CLOSE Cur_DetallePedido
	DEALLOCATE Cur_DetallePedido

	PRINT CONCAT('Nº Pedido ', @codPedido, ' tiene un coste total de ', @acumulado, '€.')
	FETCH NEXT FROM Cur_Pedidos INTO @codPedido
END

CLOSE Cur_Pedidos
DEALLOCATE Cur_Pedidos

