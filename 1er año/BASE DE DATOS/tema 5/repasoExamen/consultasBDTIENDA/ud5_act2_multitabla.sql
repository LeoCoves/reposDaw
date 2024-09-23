-------------------------------------------------------------------------
-- Ejercicios Refuerzo 2. Obtén las siguientes consultas con funciones --
-------------------------------------------------------------------------

			-----------------------------------------
			--		   CONSULTAS MULTITABLA	       --
			-----------------------------------------

USE TIENDA

-- 1. Devuelve una lista con el nombre del producto, precio y nombre de fabricante de todos los productos de la BD.
SELECT p.nombre, p.precio, f.nombre
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo

-- 2. Devuelve una lista con el nombre del producto, precio y nombre de fabricante de todos los productos de la BD.
--		Ordena el resultado por el nombre del fabricante, por orden alfabético.
SELECT p.nombre, p.precio, f.nombre
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	ORDER BY f.nombre ASC

-- 3. Devuelve una lista con el identificador del producto, nombre del producto, identificador del fabricante y 
--		nombre del fabricante, de todos los productos de la base de datos.
SELECT p.codigo, p.nombre, f.codigo, f.nombre
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo

-- 4. Devuelve el nombre del producto, su precio y el nombre de su fabricante, del producto más barato.
SELECT TOP(1)p.nombre, p.precio, f.nombre
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	ORDER BY p.precio ASC

-- 5. Devuelve el nombre del producto, su precio y el nombre de su fabricante, del producto más caro.
SELECT TOP(1)p.nombre, p.precio, f.nombre
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	ORDER BY p.precio DESC

-- 6. Devuelve una lista de todos los productos del fabricante Lenovo.
SELECT p.nombre, p.precio, f.nombre
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	AND f.nombre = 'Lenovo'

-- 7. Devuelve una lista de todos los productos del fabricante Crucial que tengan un precio mayor que 200€.
SELECT p.codigo, p.nombre, p.precio, f.nombre
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	AND (f.nombre = 'Crucial'
	AND p.precio > 200)

-- 8. Devuelve un listado con todos los productos de los fabricantes Asus, Hewlett-Packardy Seagate. Sin utilizar el operador IN.
SELECT p.nombre, f.nombre
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	AND (f.nombre = 'Asus'
	OR f.nombre = 'Hewlett-Packardy'
	OR f.nombre = 'Seagate')

	SELECT *
	FROM PRODUCTO
-- 9. Devuelve un listado con todos los productos de los fabricantes Asus, Hewlett-Packardy Seagate. Utilizando el operador IN.
SELECT p.nombre, f.nombre
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	AND f.nombre IN ('Asus', 'Hewlett-Packardy', 'Seagate')

-- 10. Devuelve un listado con el nombre y el precio de todos los productos de los fabricantes cuyo nombre termine por la vocal e.
SELECT p.nombre, p.precio
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	AND f.nombre LIKE ('%e')

-- 11. Devuelve un listado con el nombre y el precio de todos los productos cuyo nombre de fabricante contenga el carácter w en su nombre.
SELECT p.nombre, p.precio
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	AND f.nombre LIKE ('%w%')

-- 12. Devuelve un listado con el nombre de producto, precio y nombre de fabricante, de todos los productos
--		que tengan un precio mayor o igual a 180€. Ordene el resultado en primer lugar por el precio (en orden
--		descendente) y en segundo lugar por el nombre (en orden ascendente)
SELECT p.nombre, p.precio, f.nombre
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	AND p.precio >= 180
	ORDER BY p.nombre DESC,
			p.precio ASC

-- 13. Devuelve un listado con el identificador y el nombre de fabricante, solamente de aquellos fabricantes que tienen productos asociados en la BD
SELECT codigo, nombre
	FROM FABRICANTE
	WHERE EXISTS (SELECT codigo_fabricante
					FROM PRODUCTO
					WHERE codigo_fabricante = FABRICANTE.codigo)

								-----------------------------------
								-- Uso de LEFT JOIN / RIGHT JOIN --
								-----------------------------------

-- 14. Devuelve un listado de todos los fabricantes que existen en la base de datos, junto con los productos que
--		tiene cada uno de ellos. El listado deberá mostrar también aquellos fabricantes que no tienen productos asociados.
SELECT f.nombre, p.nombre
	FROM FABRICANTE f RIGHT JOIN PRODUCTO p
		ON f.codigo = p.codigo_fabricante

-- 15. Devuelve un listado donde sólo aparezcan aquellos fabricantes que no tienen ningún producto asociado.
SELECT f.nombre, p.nombre
	FROM FABRICANTE f LEFT JOIN PRODUCTO p
		ON f.codigo = p.codigo_fabricante

-- 16. ¿Pueden existir productos que no estén relacionados con un fabricante? Justifica tu respuesta.
--NO
