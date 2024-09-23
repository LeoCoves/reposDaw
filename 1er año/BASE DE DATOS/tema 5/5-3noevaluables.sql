USE TIENDA
-----------------------------------------------------
		-- Ejercicio 5.3. Escribe las siguientes consultas
		--					utilizando la BD TIENDA
		-----------------------------------------------------

					--------------------------
					--		CONSULTAS	    --
					--------------------------

-- 1. Calcula el n�mero total de productos que hay en la tabla productos.
SELECT COUNT(codigo) AS numProductos
	FROM PRODUCTO

-- 2. Calcula el n�mero de valores distintos de c�digo de fabricante aparecen en la tabla productos.
SELECT COUNT(DISTINCT codigo_fabricante)
	FROM PRODUCTO

-- 3. Calcula la media del precio de todos los productos.
SELECT ROUND(AVG(precio), 2)
	FROM PRODUCTO

-- 4. Calcula el precio m�s barato de todos los productos.
SELECT MIN(precio)
	FROM PRODUCTO
	

-- 5. Calcula el precio m�s caro de todos los productos.
SELECT MAX(precio)
	FROM PRODUCTO

-- 6. Calcula la suma de los precios de todos los productos.
SELECT SUM(precio) sumaPrecio
	FROM PRODUCTO

-- 7. Calcula el precio m�s barato de todos los productos del fabricante Asus.
SELECT MIN(precio)
	FROM PRODUCTO
	WHERE codigo_fabricante = (SELECT codigo FROM FABRICANTE WHERE nombre IN ('Asus'))

-- 8. Calcula la suma de todos los productos del fabricante Asus.
SELECT SUM(precio)
	FROM PRODUCTO
	WHERE codigo_fabricante = (SELECT codigo FROM FABRICANTE WHERE nombre = 'Asus')

-- 9. Muestra el precio m�ximo, precio m�nimo, precio medio y el n�mero total de productos que tiene el fabricante Crucial.
SELECT MAX(precio) AS maxPrecio,
		MIN(precio) AS minPrecio,
		AVG(precio) AS mediaPrecio,
		COUNT(codigo) AS numero
		FROM PRODUCTO
		WHERE codigo_fabricante = (SELECT codigo FROM FABRICANTE WHERE nombre = 'Crucial')

-- 10. Calcula el n�mero de productos que tienen un precio mayor o igual a 180�.
SELECT COUNT(codigo) numProducto
	FROM PRODUCTO
	WHERE precio >= 180

-- 11. Calcula el n�mero de productos que tiene cada fabricante con un precio mayor o igual a 180�.
SELECT p.codigo_fabricante, f.nombre, COUNT(p.codigo) AS numProductos
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.precio >= 180
	AND p.codigo_fabricante = f.codigo
	GROUP BY p.codigo_fabricante, f.nombre

--Juntar dos tablas

SELECT p.codigo,
		p.nombre,
		p.precio,
		p.codigo_fabricante,
		f.nombre
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo

-- 12. Lista el precio medio los productos de cada fabricante.
SELECT f.nombre, p.codigo_fabricante, AVG(p.precio) precioMedio
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	GROUP BY codigo_fabricante, f.nombre

-- 13. Lista el c�digo de los fabricantes cuyos productos tienen un precio medio mayor o igual a 150�.
SELECT codigo_fabricante, AVG(precio) precioMedio
	FROM PRODUCTO
	GROUP BY codigo_fabricante
	HAVING AVG(precio) >= 150

-- 14. Devuelve un listado con los c�digos de los fabricantes que tienen 2 o m�s productos.
SELECT codigo_fabricante, COUNT(codigo) numProd
	FROM PRODUCTO
	GROUP BY codigo_fabricante
	HAVING COUNT(codigo) >= 2

-- 15. Devuelve un listado con los c�digos de los fabricantes y el n�mero de productos que tiene cada uno con un precio superior o igual a 220 �. No es necesario mostrar el nombre de los fabricantes que no tienen productos que cumplan la condici�n.
-- Ejemplo del resultado esperado.
/*	codFabricante | NumProductos
	1				1
	2				2
	6				1			*/

SELECT codigo_fabricante, COUNT(codigo) numProd
	FROM PRODUCTO
	WHERE precio >= 220
	GROUP BY codigo_fabricante

-- 16. Devuelve un listado con los c�digos de los fabricantes donde la suma del precio de todos sus productos es superior a 1000 �.
SELECT codigo_fabricante, SUM(precio) sumaPrecio
	FROM PRODUCTO
	GROUP BY codigo_fabricante
	HAVING SUM(precio) > 1000