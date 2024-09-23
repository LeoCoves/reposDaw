/*
CREACIÓN / MODIFICACIÓN DE TABLAS
Crea las siguientes tablas:
STREAMERS (codStreamer, nombre, apellidos, pais, edad)
PK: codStreamer (NO se incrementa automáticamente)

TEMATICAS (codTematica, nombre)
PK: codTematica (se incrementa automáticamente)

STREAMERS_TEMATICAS (codStreamer, codTematica, idioma, medio, milesSeguidores)
PK: codStreamer, codTematica
FK: codStreamer  STREAMERS
FK: codTematica  TEMATICAS
*/

CREATE DATABASE INTERNET
GO 
USE INTERNET

DROP DATABASE INTERNET

CREATE TABLE STREAMERS(
codStreamer			INT,
nombre				VARCHAR(100) NOT NULL,
apellidos			VARCHAR(100) NOT NULL,
pais				CHAR(2) DEFAULT 'ES',
edad				TINYINT NOT NULL

CONSTRAINT PK_STREAMERS PRIMARY KEY (codStreamer)
CONSTRAINT CK_STREAMERS CHECK (edad BETWEEN 0 AND 100)
)

CREATE TABLE TEMATICAS(
codTematica			INT IDENTITY,
nombre				VARCHAR(100) NOT NULL

CONSTRAINT PK_TEMATICAS PRIMARY KEY (codTematica)
)

CREATE TABLE CANALES(
codStreamer			INT,
codTematica			INT,
idioma				VARCHAR(50) NOT NULL,
medio				VARCHAR(50) NOT NULL,
milesSeguidores		INT DEFAULT 0

CONSTRAINT PK_CANALES PRIMARY KEY (codStreamer, codTematica),
CONSTRAINT FK_CANALES_STREAMERS FOREIGN KEY (codStreamer) REFERENCES STREAMERS (codStreamer),
CONSTRAINT FK_CANALES_TEMATICAS FOREIGN KEY (codTematica) REFERENCES TEMATICAS (codTematica),
CONSTRAINT CK_CANALES CHECK (medio IN ('Youtube', 'Twitch'))
)

/*
GESTIÓN DE TABLAS
Inserta los siguientes STREAMERS:
-	Ibai Llanos de España
-	AuronPlay de España
-	Nate Gentile de España
-	Linus Tech Tips de Canadá
-	DYI Perks sin ningún país
-	Alexandre Chappel de Noruega
-	Tekendo de España
-	Caddac Tech de ningún país
*/

INSERT INTO STREAMERS
	VALUES	(1, 'Ibai', 'Llanos', 'ES', 25),
			(2, 'Raul', 'Alvarez', 'ES', 30),
			(3, 'Nate', 'Gentile', 'ES', 60)


/*
Inserta los siguientes TEMAS:
-	Informática
-	Tecnología en general
-	Gaming
-	Variado
-	Bricolaje
-	Viajes
-	Humor
*/
INSERT INTO TEMATICAS
	VALUES	('Informatica'),
			('Tecnologia en general'),
			('Gaming'),
			('Variado')

/*
Inserta las siguientes TEMATICAS de STREAMERS:
STREAMER			TEMATICA		idioma		medio		milesSeguidores
AuronPlay			Gaming			Español		YouTube		29200
Ibai Llanos			Variado			Español		Twitch		12800
AuronPlay			Variado			Español		Twitch		14900
Nate Gentile		Informática		Español		YouTube		2450
Linus Tech Tips		Informática		Inglés		YouTube		15200
DYI Perks			Bricolaje		Inglés		YouTube		4140
Alexandre Chappel	Bricolaje		Inglés		YouTube		370
Caddac Tech			Informática		Inglés		YouTube		3
*/

INSERT INTO CANALES
	VALUES	(1, 1, 'Español', 'Youtube', 1000)

INSERT INTO CANALES
	VALUES	(2, 1, 'Español', 'Twitch', 3000)

-----------------
--  CONSULTAS  --
-----------------
-- 01. Nombre de las temáticas que tenemos almacenadas, ordenadas alfabéticamente.
SELECT *
FROM TEMATICAS
ORDER BY nombre

-- 02. Cantidad de streamers cuyo país es "España".
SELECT COUNT(codStreamer)
FROM STREAMERS
WHERE pais IN ('ES')

-- 03, 04, 05. Nombres de streamers cuya segunda letra no sea una "B" (quizá en minúsculas), de 3 formas distintas.
SELECT nombre
FROM STREAMERS
WHERE RIGHT(LEFT(nombre, 2),1) NOT IN ('b', 'B')

SELECT nombre
  FROM STREAMERS
 WHERE nombre NOT LIKE '_b%'

SELECT nombre
  FROM STREAMERS
 WHERE SUBSTRING(nombre, 2, 1) NOT IN ('b', 'B')

-- 06. Media de suscriptores para los canales cuyo idioma es "Español".
SELECT AVG(milesSeguidores) mediaSeguidores
FROM CANALES
WHERE idioma = 'Español'

-- 07. Media de seguidores para los canales cuyo streamer es del país "España".
SELECT AVG(milesSeguidores)
FROM CANALES
WHERE codStreamer IN (SELECT codStreamer
						FROM STREAMERS
						WHERE pais = 'ES')

-- 08. Nombre de cada streamer y medio en el que habla, para aquellos que tienen entre 5.000 y 15.000 miles de seguidores, usando BETWEEN.
SELECT s.nombre, c.medio
FROM STREAMERS s,
	CANALES c
WHERE s.codStreamer = c.codStreamer
AND milesSeguidores BETWEEN 5000 AND 15000

-- 09. Nombre de cada streamer y medio en el que habla, para aquellos que tienen entre 5.000 y 15.000 miles de seguidores, sin usar BETWEEN.
SELECT s.nombre, c.medio
FROM STREAMERS s,
	CANALES c
WHERE s.codStreamer = c.codStreamer 
	AND milesSeguidores >= 5000 
	AND milesSeguidores <= 15000

-- 10. Nombre de cada temática y nombre de los idiomas en que tenemos canales de esa temática 
--(quizá ninguno), sin duplicados.
SELECT t.nombre, c.idioma
FROM TEMATICAS t,
	CANALES c
WHERE t.codTematica = c.codTematica

-- 11. Nombre de cada streamer, nombre de la temática de la que habla y del medio en el que habla de esa temática, usando INNER JOIN.
SELECT s.nombre, c.medio, t.nombre
FROM STREAMERS s INNER JOIN CANALES c
	ON s.codStreamer = c.codStreamer
	INNER JOIN TEMATICAS t
	ON c.codTematica = t.codTematica

-- 12. Nombre de cada streamer, nombre de la temática de la que habla y del medio en el que habla de esa temática, usando WHERE.
SELECT s.nombre, c.medio, t.nombre
FROM STREAMERS s, 
	CANALES c,
	TEMATICAS t
	WHERE s.codStreamer = c.codStreamer
	AND c.codTematica = t.codTematica

-- 13. Nombre de cada streamer, del medio en el que habla y de la temática de la que habla en ese medio, incluso si de algún streamer no tenemos dato del medio o de la temática.
SELECT s.nombre, c.medio, t.nombre
FROM STREAMERS s LEFT JOIN CANALES c
	ON s.codStreamer = c.codStreamer
	LEFT JOIN TEMATICAS t
	ON c.codTematica = t.codTematica

-- 14. Nombre de cada medio y cantidad de canales que tenemos anotados en él, ordenado alfabéticamente por el nombre del medio.
SELECT medio, COUNT(codStreamer)
 FROM CANALES
 GROUP BY medio
 ORDER BY medio

-- 15, 16, 17, 18. Medio en el que se emite el canal de más seguidores, de 4 formas distintas.
SELECT medio
FROM CANALES
WHERE milesSeguidores >= ALL(SELECT milesSeguidores
								FROM CANALES)

SELECT medio
  FROM CANALES
 WHERE milesSeguidores = (SELECT MAX(milesSeguidores)
							FROM CANALES)

SELECT TOP(1) medio
FROM CANALES
ORDER BY milesSeguidores DESC

SELECT TOP(1)medio, MAX(milesSeguidores)
FROM CANALES
GROUP BY medio

-- 19. Categorías de las que tenemos 2 o más canales.
SELECT t.nombre
FROM TEMATICAS t,
	CANALES c
WHERE t.codTematica = c.codTematica
GROUP BY t.nombre
HAVING COUNT(c.codTematica) >= 2

-- 20. Categorías de las que no tenemos anotado ningún canal, ordenadas alfabéticamente, empleando COUNT.
SELECT t.nombre
FROM TEMATICAS t,
	CANALES c
WHERE t.codTematica = c.codTematica
GROUP BY t.nombre
HAVING COUNT(c.codTematica) <= 0
ORDER BY t.nombre

-- 21. Categorías de las que no tenemos anotado ningún canal, ordenadas alfabéticamente, empleando IN / NOT IN.
SELECT nombre
FROM TEMATICAS
WHERE codTematica NOT IN (SELECT codTematica
							FROM CANALES)
ORDER BY nombre

-- 22. Categorías de las que no tenemos anotado ningún canal, ordenadas alfabéticamente, empleando ALL / ANY.
SELECT nombre
FROM TEMATICAS 
WHERE codTematica > ALL(SELECT codTematica
							FROM CANALES)
ORDER BY nombre

-- 23. Categorías de las que no tenemos anotado ningún canal, ordenadas alfabéticamente, empleando EXISTS / NOT EXISTS.
SELECT nombre
FROM TEMATICAS 
WHERE NOT EXISTS (SELECT codTematica
					FROM CANALES
					WHERE codTematica = TEMATICAS.codTematica)
ORDER BY nombre

-- 24. Tres primeras letras de cada país y tres primeras letras de cada idioma, en una misma lista.
SELECT LEFT(s.pais, 3)PAIS, LEFT(c.idioma, 3)
FROM STREAMERS s,
	CANALES c
WHERE s.codStreamer = c.codStreamer

-- 25, 26, 27, 28. Tres primeras letras de países que coincidan con las tres primeras letras de un idioma, sin duplicados, de cuatro formas distintas.
SELECT DISTINCT LEFT(s.pais, 3)PAIS, LEFT(c.idioma, 3)
FROM STREAMERS s,
	CANALES c
WHERE s.codStreamer = c.codStreamer

SELECT DISTINCT SUBSTRING(s.pais, 0, 3)PAIS, SUBSTRING(c.idioma, 0, 3)
FROM STREAMERS s,
	CANALES c
WHERE s.codStreamer = c.codStreamer

-- 29. Nombre de streamer, nombre de medio y nombre de temática, para los canales que están por encima de la media de suscriptores.
SELECT s.nombre, c.medio, t.nombre
FROM STREAMERS s,
	CANALES c,
	TEMATICAS t
GROUP BY s.nombre, c.medio, t.nombre, c.milesSeguidores
HAVING c.milesSeguidores > AVG(c.milesSeguidores)


-- 30. Nombre de streamer y medio, para los canales que hablan de la temática "Bricolaje".
SELECT s.nombre, c.medio
	FROM STREAMERS s,
		CANALES c
	WHERE c.medio = 'Bricolaje'

-- 31. Crea una tabla de "juegos". Para cada juego querremos un código (clave primaria), un nombre (hasta 20 letras, no nulo) y una referencia al streamer que más habla de él (clave ajena a la tabla "streamers").
CREATE TABLE JUEGOS(
codJuego		INT,
nombre			VARCHAR(100) NOT NULL,
codStreamer		INT

CONSTRAINT PK_JUEGOS PRIMARY KEY (codJuego),
CONSTRAINT FK_JUEGOS_STREAMERS FOREIGN KEY (codStreamer) REFERENCES STREAMERS (codStreamer)
)

-- 32. Añade a la tabla de juegos la restricción de que el código debe ser 1000 o superior.
ALTER TABLE JUEGOS
ADD CONSTRAINT CK_JUEGOS_CODIGO CHECK (codJuego >= 1000)

-- 33. Añade 3 datos de ejemplo en la tabla de juegos. Para uno indicarás todos los campos, para otro no indicarás el streamer, ayudándote de NULL, y para el tercero no indicarás el streamer porque no detallarás todos los nombres de los campos.
INSERT INTO JUEGOS (codJuego, nombre, codStreamer)
	VALUES	(1000, 'FC24', 1)

INSERT INTO JUEGOS (codJuego, nombre, codStreamer)
	VALUES	(1001, 'FC24', NULL)

INSERT INTO JUEGOS (codJuego, nombre)
	VALUES	(1002, 'FC24')

SELECT *
	FROM JUEGOS


-- 34. Borra el segundo dato de ejemplo que has añadido en la tabla de juegos, a partir de su código.
DELETE FROM JUEGOS
	WHERE codJuego = 1001

-- 35. Muestra el nombre de cada juego junto al nombre del streamer que más habla de él, si existe. Los datos aparecerán ordenados por nombre de juego y, en caso de coincidir éste, por nombre de streamer.
SELECT j.nombre, CONCAT(s.nombre, ' ', s.apellidos)nombreCompleto
	FROM JUEGOS j,
		STREAMERS s
	WHERE j.codStreamer = s.codStreamer
	ORDER BY j.nombre, s.nombre

-- 36. Modifica el último dato de ejemplo que has añadido en la tabla de juegos, para que sí tenga asociado un streamer que hable de él.
UPDATE JUEGOS
SET codStreamer = 3
WHERE codJuego = 1002

-- 37. Crea una tabla "juegosStreamers", volcando en ella el nombre de cada juego (con el alias "juego") y el nombre del streamer que habla de él (con el alias "streamer").
CREATE TABLE JUEGOS_STREAMERS(
codJuego			INT NOT NULL,
codStreamer			INT NOT NULL
)

-- 38. Añade a la tabla "juegosStreamers" un campo "fechaPrueba".
ALTER TABLE JUEGOS_STREAMERS
ADD fechaPrueba DATE

-- 39. Pon la fecha de hoy (prefijada, sin usar GetDate) en el campo "fechaPrueba" de todos los registros de la tabla "juegosStreamers".
INSERT INTO JUEGOS_STREAMERS
	VALUES (1, 1, '2024-02-21')

-- 40. Muestra juego, streamer y fecha de ayer (día anterior al valor del campo "fechaPrueba") para todos los registros de la tabla "juegosStreamers".
SELECT codJuego, codStreamer, DATEADD(DAY, -1, fechaPrueba) 
	FROM JUEGOS_STREAMERS

-- 41. Muestra todos los datos de los registros de la tabla "juegosStreamers" que sean del año actual de 2 formas distintas (por ejemplo, usando comodines o funciones de cadenas).
SELECT *
FROM JUEGOS_STREAMERS
WHERE YEAR(fechaPrueba) = 2024

-- 42. Elimina la columna "streamer" de la tabla "juegosStreamers".
ALTER TABLE JUEGOS_STREAMERS
DROP COLUMN codStreamer

-- 43. Vacía la tabla de "juegosStreamers", conservando su estructura.
DELETE FROM JUEGOS_STREAMERS

-- 44. Elimina por completo la tabla de "juegosStreamers".
DROP TABLE JUEGOS_STREAMERS

-- 45. Borra los canales del streamer "Caddac Tech".
DELETE FROM STREAMERS
WHERE nombre = 'Caddac Tech'

-- 46. Muestra la diferencia entre el canal con más seguidores y la media, mostrada en millones de seguidores. Usa el alias "diferenciaMillones".
SELECT TOP(1)codStreamer, ABS(AVG(milesSeguidores) - milesSeguidores)diferenciaMillones
FROM CANALES
GROUP BY codStreamer, milesSeguidores
ORDER BY milesSeguidores DESC

-- 47. Medios en los que tienen canales los creadores de código "ill", "ng" y "ltt", sin duplicados, usando IN (pero no en una subconsulta).
-- 48. Medios en los que tienen canales los creadores de código "ill", "ng" y "ltt", sin duplicados, sin usar IN.
-- 49. Nombre de streamer y nombre del medio en el que habla, para aquellos de los que no conocemos el país.
SELECT s.nombre, c.medio
	FROM STREAMERS s,
		CANALES c
	WHERE c.codStreamer = c.codStreamer
		AND (s.pais IS NULL
		OR s.pais = '')

-- 50. Nombre del streamer y medio de los canales que sean del mismo medio que el canal de Ibai Llanos que tiene 12800 miles de seguidores (puede aparecer el propio Ibai Llanos).
SELECT s.nombre, c.medio
	FROM STREAMERS s,
		CANALES c
	WHERE s.codStreamer = c.codStreamer
		AND medio IN (SELECT medio
						FROM STREAMERS
						WHERE nombre = 'Ibai')

-- 51. Nombre del streamer y medio de los canales que sean del mismo medio que el canal de Ibai Llanos que tiene 12800 miles de seguidores (sin incluir a Ibai Llanos).
SELECT s.nombre, c.medio
	FROM STREAMERS s,
		CANALES c
	WHERE s.codStreamer = c.codStreamer
		AND medio IN (SELECT medio
						FROM STREAMERS
						WHERE nombre = 'Ibai')
		AND s.nombre NOT IN ('Ibai')

-- 52. Nombre de cada streamer, medio y temática, incluso si para algún streamer no aparece ningún canal o para alguna temática no aparece ningún canal.
SELECT s.nombre, c.medio, t.nombre
  FROM STREAMERS s LEFT JOIN CANALES c
	ON s.codStreamer = c.codStreamer
	LEFT JOIN TEMATICAS t
	ON c.codTematica = t.codTematica

-- 53. Nombre de medio y nombre de cada temática, como parte de una única lista (quizá desordenada).
SELECT c.medio, t.nombre
  FROM CANALES c,
	TEMATICAS t
 WHERE c.codTematica = t.codTematica


-- 54. Nombre de medio y nombre de cada temática, como parte de una única lista ordenada alfabéticamente.
 SELECT c.medio, t.nombre
  FROM CANALES c,
	TEMATICAS t
 WHERE c.codTematica = t.codTematica
 ORDER BY c.medio, t.nombre

-- 55. Nombre de medio y cantidad media de suscriptores en ese medio, para los que están por encima de la media de suscriptores de los canales.
SELECT medio, AVG(milesSeguidores)
  FROM CANALES 
  GROUP BY medio, milesSeguidores
  HAVING milesSeguidores > AVG(milesSeguidores)
	 

-- 56. Nombre de los streamers que emiten en YouTube y que o bien hablan en español o bien sus miles de seguidores están por encima de 12.000.
SELECT s.nombre
  FROM STREAMERS s,
	CANALES c
 WHERE s.codStreamer = c.codStreamer
 AND c.medio IN ('Youtube')
 AND (c.idioma = 'Español' OR c.milesSeguidores > 12000)

-- 57. Añade información ficticia sobre ti: datos como streamer, temática sobre la que supuestamente y medio en el que hablas sobre ella, sin indicar cantidad de seguidores. Crea una consulta que muestre todos esos datos a partir de tu código.
 INSERT INTO STREAMERS (codStreamer, nombre, apellidos, pais, edad)
		VALUES	(4, 'Isodoro', 'Navarro', 'ES', 19),
				(5, 'Leonardo', 'Coves', 'ES', 33)

-- 58. Muestra el nombre de cada streamer, medio en el que emite y cantidad de seguidores, en millones, redondeados a 1 decimal.

-- 59. Muestra el nombre de cada streamer y el país de origen. Si no se sabe este dato, deberá aparecer "(País desconocido)".

-- 60. Muestra, para cada streamer, su nombre, el medio en el que emite (precedido por "Emite en: ") y el idioma de su canal (precedido por "Idioma: ")
