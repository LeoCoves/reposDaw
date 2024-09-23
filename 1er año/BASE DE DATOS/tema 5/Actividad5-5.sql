		-----------------------------------------------------
		-- Ejercicio 5.5. Escribe las siguientes consultas
		--					utilizando la BD JARDINERIA
		-----------------------------------------------------

					--------------------------
					--		CONSULTAS	    --
					--------------------------

-----------------------------------
-- A) Consultas de conjuntos (4) --
-----------------------------------

USE JARDINERIA

-- 1. Devuelve los códigos de los clientes que realizaron pedidos en 2022 y los clientes que realizaron pagos por transferencia. Utiliza la unión.
SELECT codCliente
	FROM PEDIDOS 
	WHERE YEAR(fecha_pedido) = 2022
UNION
SELECT codCliente	
	FROM PAGOS
	WHERE codFormaPago = 'T'

-- 2. Devuelve los códigos de los clientes que realizaron pedidos en 2022 y que también realizaron algún pago por transferencia. Utiliza la intersección.
SELECT codCliente
	FROM PEDIDOS p
	WHERE YEAR(fecha_pedido) = 2022
INTERSECT
SELECT codCliente	
	FROM PAGOS
	WHERE codFormaPago = 'T'

-- 3. Devuelve los códigos de los clientes que realizaron pedidos en 2022 PERO QUE NO los clientes que realizaron pagos por transferencia. Utiliza la diferencia.
SELECT codCliente
	FROM PEDIDOS p
	WHERE YEAR(fecha_pedido) = 2022
EXCEPT
SELECT codCliente	
	FROM PAGOS
	WHERE codFormaPago = 'T'

-- 4. Propón el enunciado de una consulta de conjuntos y escribe la consulta SQL.
-- Muestrame todos los clientes que hayan recibido un pedido en 2020 que no hayan realizado pago por Bizum
SELECT codCliente
	FROM PEDIDOS
	WHERE YEAR(fecha_entrega) = 2020
EXCEPT
SELECT codCliente
	FROM PAGOS
	WHERE codFormaPago = 'B'

----------------------------------
--    B) Subconsultas (20)      --
----------------------------------
-- Con operadores básicos de comparación

-- 1. Devuelve el nombre del cliente con mayor límite de crédito.
SELECT nombre_cliente
	FROM CLIENTES
	WHERE limite_credito = (SELECT MAX(limite_credito)
							FROM CLIENTES)

-- 2. Devuelve el nombre del producto que tenga el precio de venta más caro.
SELECT nombre
	FROM PRODUCTOS
	WHERE precio_venta = (SELECT MAX(precio_venta)
							FROM PRODUCTOS)

-- 3. Devuelve el producto que más unidades tiene en stock. Si salen varios, quédate solo con uno.
SELECT TOP(1)codProducto, nombre
	FROM PRODUCTOS
	WHERE cantidad_en_stock = (SELECT MAX(cantidad_en_stock)
								FROM PRODUCTOS)

-- 4. Devuelve el producto que menos unidades tiene en stock.
SELECT TOP(1)codProducto, nombre
	FROM PRODUCTOS
	WHERE cantidad_en_stock = (SELECT MIN(cantidad_en_stock)
								FROM PRODUCTOS)

-- 5. Devuelve el nombre, los apellidos y el email de los empleados que están a cargo de Alberto Soria.
SELECT nombre, apellido1, apellido2, email
	FROM EMPLEADOS
	WHERE codEmplJefe = (SELECT codEmpleado
							FROM EMPLEADOS
							WHERE nombre = 'Alberto'
							AND apellido1 = 'Soria')

-- 6. Propón el enunciado de una consulta de conjuntos y escribe la consulta SQL (puede ser de cualquier tipo, con IN, NOT IN, ALL, ANY, etc).
-- Devuelve el nombre del producto con el precio de venta mas barato
SELECT TOP(1)nombre
	FROM PRODUCTOS
	WHERE precio_venta <= ALL(SELECT precio_venta
								FROM PRODUCTOS)


--------------------------------------------------------------------
--  Subconsultas con ALL y ANY  --
--  IMPORTANTE: NO UTILIZAR MAX o MIN en las subconsultas
--------------------------------------------------------------------

-- 1. Devuelve el nombre del cliente con mayor límite de crédito.
SELECT  nombre_cliente
	FROM CLIENTES
	WHERE limite_credito >= ALL(SELECT limite_credito
								FROM CLIENTES)

-- 2. Devuelve el nombre del producto que tenga el precio de venta más caro.
SELECT nombre
	FROM PRODUCTOS
	WHERE precio_venta >= ALL(SELECT precio_venta
								FROM PRODUCTOS)

-- 3. Devuelve el producto que menos unidades tiene en stock.
SELECT codProducto, nombre
	FROM PRODUCTOS
	WHERE cantidad_en_stock <= ALL(SELECT cantidad_en_stock
									FROM PRODUCTOS)


----------------------------------
-- Subconsultas con IN y NOT IN --
----------------------------------

-- 1. Devuelve un listado que muestre solamente los clientes que no han realizado ningún pago.
SELECT codCliente, nombre_cliente
	FROM CLIENTES
	WHERE codCliente NOT IN (SELECT codCliente
							FROM PAGOS)

-- 2. Devuelve un listado que muestre solamente los clientes que han realizado algún pago.
SELECT codCliente, nombre_cliente
	FROM CLIENTES
	WHERE codCliente IN (SELECT codCliente
							FROM PAGOS)

-- 3. Devuelve un listado de los productos que nunca han aparecido en un pedido.
SELECT codProducto, nombre
	FROM PRODUCTOS
	WHERE codProducto NOT IN (SELECT codProducto
								FROM DETALLE_PEDIDOS)

-- 4. Devuelve el nombre, apellidos, puesto y teléfono de la oficina de aquellos empleados que no sean representante de ventas de ningún cliente.
SELECT e.nombre, e.apellido1, e.apellido2, e.puesto_cargo, o.telefono
	FROM EMPLEADOS e,
		OFICINAS o
	WHERE codEmpleado NOT IN (SELECT codEmpl_ventas
								FROM CLIENTES)
		AND e.codOficina = o.codOficina

-- 5. Devuelve las oficinas donde trabajan alguno de los empleados.
SELECT *
	FROM OFICINAS
	WHERE codOficina IN (SELECT codOficina	
						FROM EMPLEADOS)
				   
-- 6. Devuelve un listado con los clientes que han realizado algún pedido pero no que hayan realizado ningún pago.
SELECT *
	FROM CLIENTES
	WHERE codCliente IN (SELECT codCliente
						FROM PEDIDOS)
	AND codCliente NOT IN (SELECT codCliente
							FROM PAGOS)

------------------------------------------
-- Subconsultas con EXISTS y NOT EXISTS --
------------------------------------------

-- 1. Devuelve un listado que muestre solamente los clientes que no han realizado ningún pago.
SELECT *
	FROM CLIENTES
	WHERE NOT EXISTS (SELECT codCliente
						FROM PAGOS
						WHERE codCliente = CLIENTES.codCliente)

-- 2. Devuelve un listado que muestre solamente los clientes que han realizado algún pago.
SELECT *
	FROM CLIENTES
	WHERE EXISTS (SELECT codCliente
						FROM PAGOS
						WHERE codCliente = CLIENTES.codCliente)

-- 3. Devuelve un listado de los productos que nunca han aparecido en un pedido.
SELECT *
	FROM PRODUCTOS
	WHERE NOT EXISTS (SELECT codProducto
						FROM DETALLE_PEDIDOS
						WHERE codProducto = PRODUCTOS.codProducto)

-- 4. Devuelve un listado de los productos que han aparecido en un pedido alguna vez.
SELECT *
	FROM PRODUCTOS
	WHERE EXISTS (SELECT codProducto
						FROM DETALLE_PEDIDOS
						WHERE codProducto = PRODUCTOS.codProducto)


---------------------------
--		  Vistas		 --
---------------------------

-- 1. Crea una vista que devuelva los códigos de los clientes que realizaron pedidos en 2009 y los clientes que realizaron pagos por transferencia. Utiliza la unión.
CREATE VIEW VPagosTransferencia2009 AS
SELECT codCliente
	FROM PEDIDOS
	WHERE YEAR(fecha_pedido) = 2009
UNION
SELECT codCliente
	FROM PAGOS
	WHERE codFormaPago = 'T'


-- 2. Escribe el código SQL para realizar una consulta a dicha vista
SELECT * 
	FROM VPagosTransferencia2009

-- 3. Escribe el código SQL para eliminar dicha vista.
DROP VIEW VPagosTransferencia2009
