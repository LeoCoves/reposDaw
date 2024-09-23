/* Obtener la FECHA y HORA actual */
SELECT GETDATE()

/* Añadir 10 días a la FECHA ‘03/05/2023’ */
SELECT DATEADD(DAY, 10, '03-05-2023')

/* Añadir 2 años a la FECHA ‘29/10/2022’ */
SELECT DATEADD(YEAR, 2, '2022-10-29')

/* Diferencia de días entre las FECHAS: 10/02/2023 y 25/03/2023 */
SELECT ABS(DATEDIFF(DAY, '2023-02-10', '2023-03-25'))

/* Obtener el valor del DÍA de la FECHA ACTUAL */
SELECT DATENAME(DAY, GETDATE())

/* Obtener el valor del MES de la FECHA ACTUAL */
SELECT DATENAME(MONTH, GETDATE())

/* Obtener el valor del AÑO de la FECHA ACTUAL */
SELECT DATENAME(YEAR, GETDATE())

 /*Obtener nombre del mes con letras de la fecha 19/03/2023 */
SELECT DATENAME(MONTH, '2023-03-19')

/* Utilizando la función CHARINDEX() obtén la palabra 'news' de la frase 'No news is good news'
    Debes utilizar también la función LEFT y/o RIGHT
    Nota: Su equivalente en Oracle es la función INSTR()
*/
-- Solución utilizando CHARINDEX y LEFT o RIGHT


SELECT  RIGHT(LEFT('No news is good news', CHARINDEX('news', 'No news is good news')+LEN('news')-1), LEN('news'))

SELECT SUBSTRING('No news is good news', CHARINDEX('news', 'No news is good news'), LEN('news'))

/* Supón que tenemos una tabla llamada PIE_FIRMA que consta de dos campos (no se hará con la tabla, sino con strings)
    - fechaFirma DATE
    - lugarFirma VARCHAR(100)

    A partir de la siguiente SELECT, genera el siguiente pie de firma a este:
    'En Alicante, a 8 de junio de 2022'
 */

SELECT CONCAT('En ', ' ', ' lugarFirma', ' ', ' a ', DAY('2022-06-08'), ' de ',
        DATENAME(MONTH, '2022-06-08'), ' de ', DATENAME(YEAR, '2022-06-08'))

 SELECT '08/06/2022', 'Alicante';


/* Utiliza la función ASCII() para obtener el valor ASCII de un carácter
    Para el carácter A debe devolver 65
*/
SELECT ASCII('A')


/* Investiga el uso de la función TRANSLATE() y haz un ejemplo de uso */
SELECT TRANSLATE(' me llamo leo', 'o', 'a')


/* Investiga el uso de la función REPLICATE() y haz un ejemplo de uso */
SELECT REPLICATE('OLE ', 3)


/* Investiga el uso de la función SPACE() y haz un ejemplo de uso */
SELECT CONCAT('Leo', SPACE(2),'CALLLA')

-----5.2-------

-- 1. Lista el nombre de todos los productos que hay en la tabla producto.
SELECT nombre
    FROM PRODUCTO

-- 2. Lista los nombres y los precios de todos los productos de la tabla producto.
SELECT nombre, precio
    FROM PRODUCTO

-- 3. Lista todas las columnas de la tabla producto.
SELECT * 
    FROM PRODUCTO

-- 4. Lista los nombres y los precios de todos los productos de la tabla producto, convirtiendo los nombres a may�scula.
SELECT UPPER(nombre), UPPER(precio)
    FROM PRODUCTO

-- 5. Lista los nombres y los precios de todos los productos de la tabla producto, convirtiendo los nombres a min�scula.
SELECT LOWER(nombre), LOWER(precio)
    FROM PRODUCTO

-- 6. Lista el nombre de todos los fabricantes en una columna, y en otra columna obtenga en may�sculas los dos primeros caracteres del nombre del fabricante.
SELECT nombre AS nombre, UPPER(LEFT(nombre, 2)) AS iniciales
    FROM FABRICANTE

-- 7. Lista los nombres y los precios de todos los productos de la tabla producto, redondeando el valor del precio al primer decimal.
SELECT nombre, ROUND(precio, 1)
    FROM PRODUCTO

-- 8. Lista los nombres y los precios de todos los productos de la tabla producto, truncando el valor del precio para mostrarlo sin ninguna cifra decimal.
SELECT nombre, FLOOR(precio)
    FROM PRODUCTO

-- 9. Lista los nombres de los fabricantes ordenados de forma ascendente.
SELECT nombre 
    FROM FABRICANTE
    ORDER BY nombre ASC

-- 10. Lista los nombres de los fabricantes ordenados de forma descendente.
SELECT nombre
    FROM FABRICANTE
    ORDER BY nombre DESC

-- 11. Lista los nombres de los productos ordenados en primer lugar por el nombre de forma ascendente y en segundo lugar por el precio de forma descendente.
SELECT nombre, precio
    FROM PRODUCTO
    ORDER BY nombre ASC, precio DESC

-- 12. Devuelve una lista con las 5 primeras filas de la tabla fabricante.
SELECT TOP(5) nombre
    FROM FABRICANTE

-- 13. Lista el nombre de todos los productos del fabricante cuyo c�digo de fabricante es igual a 2.
SELECT nombre, codigo
    FROM FABRICANTE
    WHERE codigo IN ('2')

-- 14. Lista el nombre de los productos que tienen un precio menor o igual a 120�.
SELECT nombre, precio
    FROM PRODUCTO
    WHERE precio <= 120

-- 15. Lista el nombre de los productos que tienen un precio mayor o igual a 400�.
SELECT nombre, precio
    FROM PRODUCTO
    WHERE precio >= 400

-- 16. Lista el nombre de los productos que no tienen un precio mayor o igual a 400�.
SELECT nombre, precio
    FROM PRODUCTO
    WHERE NOT(precio >= 400)

-- 17. Lista todos los productos que tengan un precio entre 80� y 300�. Sin utilizar el operador BETWEEN.
SELECT nombre, precio
    FROM PRODUCTO
    WHERE precio >= 80 AND precio <= 300

-- 18. Lista todos los productos que tengan un precio entre 60� y 200�. Utilizando el operador BETWEEN.
SELECT nombre, precio
    FROM PRODUCTO
    WHERE precio BETWEEN 60 AND 200

-- 19. Lista todos los productos donde el c�digo de fabricante sea 1, 3 o 5. Sin utilizar el operador IN.
SELECT nombre
    FROM PRODUCTO
    WHERE codigo_fabricante = 1
    OR codigo_fabricante = 3
    OR codigo_fabricante = 5
    

-- 20. Lista todos los productos donde el c�digo de fabricante sea 1, 3 o 5. Utilizando el operador IN.
SELECT nombre
    FROM PRODUCTO
    WHERE codigo_fabricante IN (1, 3, 5)

-- 21. Lista el nombre y el precio de los productos en c�ntimos (Habr� que multiplicar por 100 el valor del precio).
--		Crea un alias para la columna que contiene el precio que se llame c�ntimos.
SELECT nombre, precio*100 AS centimos
    FROM PRODUCTO
    

-- 22. Lista los nombres de los fabricantes cuyo nombre empiece por la letra S.
SELECT nombre
    FROM FABRICANTE
    WHERE UPPER(nombre) LIKE UPPER('s%')
    

-- 23. Lista los nombres de los fabricantes cuyo nombre termine por la vocal e.
SELECT nombre
    FROM FABRICANTE
    WHERE UPPER(nombre) LIKE UPPER('%e')

-- 24. Lista los nombres de los fabricantes cuyo nombre contenga el car�cter w.
SELECT nombre
    FROM FABRICANTE
    WHERE UPPER(nombre) LIKE UPPER('%w%')

-- 25. Lista los nombres de los fabricantes cuyo nombre sea de 4 caracteres.
SELECT nombre
    FROM FABRICANTE
    WHERE LEN(nombre) = 4

-- 26. Devuelve una lista con el nombre de todos los productos que contienen la cadena Port�til en el nombre.
SELECT nombre
    FROM PRODUCTO
    WHERE UPPER(nombre) LIKE UPPER('%portátil%')

-- 27. Devuelve una lista con el nombre de todos los productos que contienen la cadena Monitor en el nombre y tienen un precio inferior a 215 �.
SELECT nombre, precio
    FROM PRODUCTO
    WHERE UPPER(nombre) LIKE UPPER('%monitor%')
    AND precio < 215

-- 28. Lista el nombre y el precio de todos los productos que tengan un precio mayor o igual a 180�. Ordene el resultado en primer lugar por el precio (en orden descendente) y en segundo lugar por el nombre (en orden ascendente).
SELECT precio, nombre
    FROM PRODUCTO
    WHERE precio >= 180
    ORDER BY precio DESC, nombre ASC