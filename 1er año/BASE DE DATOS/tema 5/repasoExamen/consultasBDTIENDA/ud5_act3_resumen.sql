-------------------------------------------------------------------------
-- Ejercicios Refuerzo 3. Obtén las siguientes consultas con funciones --
-------------------------------------------------------------------------

			-----------------------------------------
			--		   CONSULTAS RESUMEN		   --
			-----------------------------------------
			--     GROUP BY / HAVING			   --
			--	   COUNT, MIN, MAX, AVG, SUM	   --
			-----------------------------------------
USE TIENDA

-- 1. Calcula el número total de productos que hay en la tabla productos.
SELECT COUNT(codigo)numProductos
	FROM PRODUCTO

-- 2. Calcula el número total de fabricantes que hay en la tabla fabricante.
SELECT COUNT(codigo)numFabricantes
	FROM FABRICANTE

-- 3. Calcula el número de valores distintos de identificador de fabricante aparecen en la tabla productos.
SELECT codigo, COUNT(codigo)
	FROM FABRICANTE
	GROUP BY codigo

-- 4. Calcula la media del precio de todos los productos.
SELECT ROUND(AVG(precio), 2)mediaPrecio
	FROM PRODUCTO

-- 5. Calcula el precio más barato de todos los productos.
SELECT MIN(precio)precioMasBarato
	FROM PRODUCTO

-- 6. Calcula el precio más caro de todos los productos.
SELECT MAX(precio)precioMasCaro
	FROM PRODUCTO

-- 7. Lista el nombre y el precio del producto más barato.
SELECT TOP(1)nombre, precio
	FROM PRODUCTO
	ORDER BY precio ASC

-- 8. Lista el nombre y el precio del producto más caro.
SELECT TOP(1)nombre, precio
	FROM PRODUCTO
	ORDER BY precio DESC

-- 9. Calcula la suma de los precios de todos los productos.
SELECT SUM(precio)
	FROM PRODUCTO

-- 10. Calcula el número de productos que tiene el fabricante Asus.
SELECT COUNT(codigo)numProductos
	FROM PRODUCTO
	WHERE codigo_fabricante IN (SELECT codigo
								FROM FABRICANTE
								WHERE nombre = 'Asus')

-- 11. Calcula la media del precio de todos los productos del fabricante Asus.
SELECT AVG(precio)mediaPrecio
	FROM PRODUCTO
	WHERE codigo_fabricante IN (SELECT codigo
								FROM FABRICANTE
								WHERE nombre = 'Asus')

-- 12. Calcula el precio más barato de todos los productos del fabricante Asus.
SELECT MIN(precio)precioMasBarato
	FROM PRODUCTO
	WHERE codigo_fabricante IN (SELECT codigo
								FROM FABRICANTE
								WHERE nombre = 'Asus')

-- 13. Calcula el precio más caro de todos los productos del fabricante Asus.
SELECT MAX(precio)precioMasCaro
	FROM PRODUCTO
	WHERE codigo_fabricante IN (SELECT codigo
								FROM FABRICANTE
								WHERE nombre = 'Asus')

-- 14. Calcula la suma de todos los productos del fabricante Asus.
SELECT SUM(precio)sumasPrecio
	FROM PRODUCTO
	WHERE codigo_fabricante IN (SELECT codigo
								FROM FABRICANTE
								WHERE nombre = 'Asus')

-- 15. Muestra el precio máximo, precio mínimo, precio medio y el número total de productos que tiene el fabricante Crucial.
SELECT MAX(precio)maxPrecio, MIN(precio)minPrecio, AVG(precio)mediaPrecio, COUNT(codigo)numProductos
	FROM PRODUCTO
	WHERE codigo_fabricante IN (SELECT codigo
								FROM FABRICANTE
								WHERE nombre = 'Crucial')

-- 16. Muestra el número total de productos que tiene cada uno de los fabricantes. El listado también debe
--		incluir los fabricantes que no tienen ningún producto. El resultado mostrará dos columnas, una con el
--		nombre del fabricante y otra con el número de productos que tiene. Ordene el resultado descendentemente por el número de productos.
SELECT f.nombre, COUNT(p.codigo) numProd
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	GROUP BY f.nombre
	ORDER BY numProd DESC

-- 17. Muestra el precio máximo, precio mínimo y precio medio de los productos de cada uno de los fabricantes.
--		El resultado mostrará el nombre del fabricante junto con los datos que se solicitan.
SELECT MAX(p.precio)maxPrecio, MIN(p.precio)minPrecio, AVG(p.precio)mediaPrecio, f.nombre
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	GROUP BY f.nombre

-- 18. Muestra el precio máximo, precio mínimo, precio medio y el número total de productos de los fabricantes
--		que tienen un precio medio superior a 200€. No es necesario mostrar el nombre del fabricante, con el
--		identificador del fabricante es suficiente.
SELECT MAX(p.precio)maxPrecio, MIN(p.precio)minPrecio, AVG(p.precio)mediaPrecio, COUNT(p.codigo)numProd, f.codigo
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	GROUP BY f.codigo
	HAVING AVG(p.precio) > 200

-- 19. Muestra el nombre de cada fabricante, junto con el precio máximo, precio mínimo, precio medio y el
--		número total de productos de los fabricantes que tienen un precio medio superior a 200€. Es necesario
--		mostrar el nombre del fabricante
SELECT MAX(p.precio)maxPrecio, MIN(p.precio)minPrecio, AVG(p.precio)mediaPrecio, COUNT(p.codigo)numProd, f.nombre
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	GROUP BY f.nombre
	HAVING AVG(p.precio) > 200

-- 20. Calcula el número de productos que tienen un precio mayor o igual a 180€.
SELECT COUNT(precio) numProd
	FROM PRODUCTO
	WHERE precio >= 180

-- 21. Calcula el número de productos que tiene cada fabricante con un precio mayor o igual a 180€.
SELECT codigo_fabricante, COUNT(codigo)numProd
	FROM PRODUCTO
	WHERE precio >= 180
	GROUP BY codigo_fabricante

-- 22. Lista el precio medio los productos de cada fabricante, mostrando solamente el identificador del fabricante.
SELECT codigo_fabricante, AVG(precio)numProd
	FROM PRODUCTO
	GROUP BY codigo_fabricante

-- 23. Lista el precio medio los productos de cada fabricante, mostrando solamente el nombre del fabricante.
SELECT f.nombre, AVG(p.precio)numProd
	FROM PRODUCTO p,
		FABRICANTE f
	WHERE p.codigo_fabricante = f.codigo
	GROUP BY f.nombre

-- 24. Lista los nombres de los fabricantes cuyos productos tienen un precio medio mayor o igual a 150€.
SELECT nombre
	FROM FABRICANTE
	WHERE codigo IN (SELECT codigo_fabricante
						FROM PRODUCTO
						GROUP BY codigo_fabricante
						HAVING AVG(precio) >= 150)

-- 25. Devuelve un listado con los nombres de los fabricantes que tienen 2 o más productos.
SELECT nombre
	FROM FABRICANTE
	WHERE codigo IN (SELECT codigo_fabricante
						FROM PRODUCTO
						GROUP BY codigo_fabricante
						HAVING COUNT(codigo) >= 2)

-- 26. Devuelve un listado con los nombres de los fabricantes y el número de productos que tiene cada uno con
--		un precio superior o igual a 220 €. No es necesario mostrar el nombre de los fabricantes que no tienen
--		productos que cumplan la condición
SELECT f.nombre, COUNT(p.codigo)
	FROM FABRICANTE f LEFT JOIN PRODUCTO p
		ON f.codigo = p.codigo_fabricante
	WHERE precio >= 220
	GROUP BY f.nombre
	

-- Resultado esperado:
-- -------------------
--	nombre   | total
-- -------------------
--  Lenovo   |   2
--  Asus     |   1
--  Crucial  |   1
-- -------------------
--

-- 27. Devuelve un listado con los nombres de los fabricantes y el número de productos que tiene cada uno con
--		un precio superior o igual a 220 €. El listado debe mostrar el nombre de todos los fabricantes, es decir, si
--		hay algún fabricante que no tiene productos con un precio superior o igual a 220€ deberá aparecer en el
--		listado con un valor igual a 0 en el número de productos
SELECT f.nombre, COUNT(p.codigo)
	FROM FABRICANTE f LEFT JOIN PRODUCTO p
	ON f.codigo = p.codigo_fabricante
	WHERE p.precio >= 220
	GROUP BY f.nombre

-- Resultado esperado:
-- ----------------------------
--	nombre				| total
-- ----------------------------
--  Lenovo				|  2
--  Crucial				|  1
--  Asus				|  1
--  Huawei				|  0
--  Samsung				|  0
--  Gigabyte			|  0
--  Hewlett-Packard		|  0
--  Xiaomi				|  0
--  Seagate				|  0


-- 28. Devuelve un listado con los nombres de los fabricantes donde la suma del precio de todos sus productos sea superior a 1000 €
SELECT nombre
	FROM FABRICANTE
	WHERE codigo IN (SELECT codigo_fabricante
						FROM PRODUCTO
						GROUP BY codigo_fabricante
						HAVING SUM(precio) > 1000)

-- 29. Devuelve un listado con el nombre del producto más caro que tiene cada fabricante. El resultado debe
--		tener tres columnas: nombre del producto, precio y nombre del fabricante. El resultado tiene que estar
--		ordenado alfabéticamente de menor a mayor por el nombre del fabricante
SELECT f.nombre, p.nombre, p.precio
	FROM PRODUCTO p LEFT JOIN FABRICANTE f
		ON p.codigo_fabricante = f.codigo
	WHERE p.precio >= ALL(SELECT codigo
						FROM PRODUCTO
						HAVING MAX(p.precio) = p.precio)
	GROUP BY f.nombre, p.nombre, p.precio



