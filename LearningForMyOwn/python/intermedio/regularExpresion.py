## Expresiones Regulares

import re

texto1 = "Esta es la leccion de Expresiones Regulares"
texto2 = "Esta no es la leccion de Expresiones Regulares"

match = re.match("Expresiones Regulares", texto1, re.I)

print(re.match("Esta es la leccion", texto1))

start, end = match.span()
print(texto1[start:end])