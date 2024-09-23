USE JARDINERIA

---------------------------
-- Actividad. Jardinería --
---------------------------

-- 1. Inserta una nueva oficina en Alicante.
INSERT INTO OFICINAS (codOficina, ciudad, pais,
						codPostal, telefono, linea_direccion1, linea_direccion2)
			VALUES ('ALI-ES', 'Alicante', 'España',
					'03322', '+34 934564356', 'Avenida San Gabriel', NULL)

-- 2. Inserta un nuevo empleado para la oficina de Alicante que sea representante de ventas.
INSERT INTO EMPLEADOS (codEmpleado, nombre, apellido1,
						apellido2, tlf_extension_ofi, email,
						puesto_cargo, salario, codOficina, codEmplJefe)
			VALUES (32, 'Ivan', 'Rumbeu',
					NULL, 4455, 'rumbeu@gardening.es',
					'Representante de ventas', 1603.00, 'ALI-ES', 25)

--3. Inserta un cliente que tenga como representante de ventas el empleado que creamos en el paso anterior.
INSERT INTO CLIENTES (codCliente, nombre_cliente, nombre_contacto,
						apellido_contacto, telefono, email,
						linea_direccion1, linea_direccion2, ciudad,
						pais, codPostal, codEmpl_ventas, limite_credito)
			VALUES (39, 'Tesla S.A.', 'Karim',
					'Abbou', '657432742', 'k.abbou@jardindeflores.es',
					'C/ San Gabriel 55', NULL, 'Alicante',
					'Spain', '03322', 32, 33000.00)

-- 4. Inserta un pedido que contenga al menos tres productos para el cliente que acabamos de crear.
INSERT INTO PEDIDOS (codPedido, fecha_pedido, fecha_esperada,
						fecha_entrega, codEstado, comentarios, codCliente)
			VALUES (129, GetDate(), '2024-02-20',
					NULL, 'P', NULL, 39)
INSERT INTO DETALLE_PEDIDOS (codPedido, codProducto, cantidad, 
							precio_unidad, numeroLinea)
			VALUES (129, 5, 58,
					8.00, 7),

					(129, 87, 10,
					70.00, 3),

					(129, 251, 4,
					64.00, 1)

SELECT *
	FROM DETALLE_PEDIDOS
SELECT *
	FROM PEDIDOS
--5. Actualiza y/o borra el código del cliente que creamos en el paso anterior. ¿Ha sido posible
--actualizarlo o borrarlo? ¿Por qué? Averigua si hubo cambios en las tablas relacionadas.
UPDATE CLIENTES
	SET codCliente = 40
	WHERE codCliente = 39
--No deja porque al actualizar se crea un conflicto con la FK de Pedidos - Clientes
SELECT * 
	FROM CLIENTES

--6. Actualiza la cantidad de unidades solicitadas en el pedido que has creado del siguiente modo:
-- para el 1er producto serán 3 unidades, para el producto 2 serán 2 unidades y el tercero 1 unidad.
UPDATE DETALLE_PEDIDOS
	SET cantidad = 3
	WHERE codProducto = 5
	AND codPedido = 129
GO
UPDATE DETALLE_PEDIDOS
	SET cantidad = 2
	WHERE codProducto = 87
	AND codPedido = 129
GO
UPDATE DETALLE_PEDIDOS
	SET cantidad = 1
	WHERE codProducto = 251
	AND codPedido = 129
SELECT *
	FROM DETALLE_PEDIDOS
--7. Modifica la fecha del pedido que hemos creado a la fecha y hora actuales.
UPDATE PEDIDOS
	SET fecha_pedido = GetDate()
	WHERE codPedido = 129

--8. Incrementa en un 5% el precio de los productos que están incluidos en el pedido que has creado.
-- Recuerda que puede que tengas que redondear y/o utilizar la función CAST (XXX as FLOAT)
UPDATE DETALLE_PEDIDOS
	SET	precio_unidad = ROUND(precio_unidad*1.05, 2)
	WHERE codPedido = 129

--9. Vuelve a dejar el precio de dichos productos como estaba anteriormente.
UPDATE DETALLE_PEDIDOS
	SET precio_unidad = ROUND(precio_unidad/1.05, 2)
	WHERE codPedido = 129

--10. ¿Cuál sería la secuencia de borrado de registros de tablas hasta que finalmente se pueda borrar la oficina de Alicante que creamos en el ejercicio 1? Una vez tengas el script, comprueba que se puede eliminar.
DELETE FROM DETALLE_PEDIDOS
	WHERE codPedido = 129

DELETE FROM PEDIDOS
	WHERE codPedido = 129

DELETE FROM CLIENTES
	WHERE codCliente = 39

DELETE FROM EMPLEADOS
	WHERE codEmpleado = 32

DELETE FROM OFICINAS
	WHERE codOficina = 'ALI-ES'

SELECT *
	FROM OFICINAS
--11. Incrementa en un 20% el precio de los productos que NO estén incluidos en ningún pedido.
-- Recuerda que puede que tengas que redondear y/o utilizar la función CAST (XXX as FLOAT)
UPDATE PRODUCTOS
	SET precio_venta = ROUND(precio_venta*1.20, 2)
	WHERE codProducto NOT IN (SELECT codProducto
								FROM DETALLE_PEDIDOS)

--12. Vuelve a dejar el precio de los productos como estaba anteriormente.
UPDATE PRODUCTOS
	SET precio_venta = ROUND(precio_venta/1.20, 2)
	WHERE codProducto NOT IN (SELECT codProducto
								FROM DETALLE_PEDIDOS)

--13. Elimina los clientes que no hayan realizado ningún pago.
DELETE FROM CLIENTES
 WHERE codCliente NOT IN (SELECT codCliente
							FROM PAGOS)

--14. Elimina los clientes que no hayan realizado un mínimo de 2 pedidos (NOTA: al ejecutar la sentencia fallará por la integridad referencial, es decir, porque hay tablas que tiene relacionado el idCliente como FK).
DELETE FROM CLIENTES
	WHERE codCliente NOT IN (SELECT codCliente
								FROM PEDIDOS
								GROUP BY codCliente
								HAVING COUNT(codCliente) >= 2)

--15. Borra los pagos del cliente con menor límite de crédito.
DELETE FROM CLIENTES
	WHERE limite_credito = (SELECT MIN(limite_credito)
							FROM CLIENTES)

--16. Actualiza la ciudad a Alicante para aquellos clientes que tengan un límite de crédito inferior a TODOS los precios de los productos de la categoría Ornamentales (puede que no haya ninguno).
UPDATE CLIENTES
	SET ciudad = 'Alicante'
	WHERE limite_credito < ALL(SELECT precio_venta
								FROM PRODUCTOS
								WHERE codCategoria = 'OR'

--17. Actualiza la ciudad a Madrid para aquellos clientes que tengan un límite de crédito mensual inferior a ALGUNO de los precios de los productos de la categoría Ornamentales.
UPDATE CLIENTES
	SET ciudad = 'Madrid'
	WHERE limite_credito = ANY(SELECT precio_venta
								FROM PRODUCTOS
								WHERE codCategoria = 'OR')


--18. Establece a 0 el límite de crédito del cliente que menos unidades pedidas del producto OR-179.
UPDATE CLIENTES
	SET limite_credito = 0
	WHERE codCliente = (SELECT TOP(1)pe.codCliente
							FROM PEDIDOS pe,
								DETALLE_PEDIDOS de,
								PRODUCTOS p
							WHERE pe.codPedido = de.codPedido
								AND de.codProducto = p.codProducto
								AND p.refInterna = 'OR-179'
							ORDER BY cantidad ASC)


--19. Modifica la tabla detalle_pedido para insertar un campo numérico llamado IVA. Establece el
--valor de ese campo a 18 para aquellos registros cuyo pedido tenga fecha a partir de Enero de
--2009. A continuación, actualiza el resto de pedidos estableciendo el IVA al 21.
ALTER TABLE DETALLE_PEDIDOS
ADD IVA DECIMAL(3,2)

UPDATE DETALLE_PEDIDOS
	SET IVA = 1.18
	WHERE codPedido IN (SELECT codPedido
						FROM PEDIDOS
						WHERE fecha_pedido >= '2009-01-01')

UPDATE DETALLE_PEDIDOS
	SET IVA = 1.18
	WHERE codPedido NOT IN (SELECT codPedido
						FROM PEDIDOS
						WHERE fecha_pedido >= '2009-01-01')


--20. Modifica la tabla detalle_pedido para incorporar un campo numérico llamado total_linea y
--actualiza todos sus registros para calcular su valor con la fórmula:
--total_linea = precio_unidad*cantidad * (1 + (iva/100));
ALTER TABLE DETALLE_PEDIDOS
ADD total_linea AS (precio_unidad * cantidad * IVA)


--21. Crea una tabla llamada HISTORICO_CLIENTES que tenga la misma estructura que CLIENTES y además un campo llamado fechaAlta de tipo DATE.
--Deberás insertar en una única sentencia los clientes cuyo nombre contenga la letra ‘s’ e informar el campo fechaAlta como la fecha/hora del momento en el que se inserta.
SELECT *
INTO HISTORICO_CLIENTES 
FROM CLIENTES

ALTER TABLE HISTORICO_CLIENTES
ADD fechaAlta DATETIME

INSERT INTO HISTORICO_CLIENTES
SELECT *, GetDate()
FROM CLIENTES
WHERE nombre_cliente LIKE '%s%'


--22. Actualiza a NULL los campos pais y codigo_postal en la tabla CLIENTES para todos los registros. Utiliza una sentencia de actualización en la que se actualicen estos 2 campos 
--a partir de los datos existentes en la tabla HISTORICO_CLIENTES. Comprueba que los datos se han trasladado correctamente.
UPDATE CLIENTES
SET pais = NULL,
	codPostal = NULL

UPDATE cli
 SET cli.pais = his.pais,
 cli.codPostal = his.codPostal
 FROM CLIENTES cli INNER JOIN HISTORICO_CLIENTES his ON cli.codCliente = his.codCliente;

SELECT *
	FROM CLIENTES

