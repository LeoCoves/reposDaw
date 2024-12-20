## Expresiones Regulares
## Mecanismo para inspeccionar que una cadena de texto tenga un patron
## Importamos re que es libreria de regular expression

import re

texto1 = "Esta es la leccion de Expresiones Regulares: Leccion 7: Expresiones Regulares"
texto2 = "Esta no es la leccion de Expresiones Regulares: Manejo de ficheros"

print(re.match("Esta es la leccion", texto1, re.I))
print(re.match("leccion", texto1)) #Devuelve none porque busca desde el principio de la cadena
print(re.match("Esta es la leccion", texto2))


print("------Match-------")

# Otra manera de comprobar el None con is not
match = re.match("Esta no es la leccion", texto2)
if match is not None:
    print(match)
    start, end = match.span()
    print(texto2[start:end])

print("----------")
# Otra manera de comprobar el None con !=
if match != None:
    print(match)
    start, end = match.span()
    print(texto2[start:end])

print("-------Search------")

# search
# Devuelve donde esta o el string sin que necesariamente este al principio
# Devuelve el primer elemento encontrado

search = re.search("leccion", texto1, re.I)
print(search)
start,end = search.span()
print(texto1[start:end])

print("------Findall------")

# Findall
# Devuelve un array con el texto que busca sin diferenciar mayusculas o minusculas

findall = re.findall("leccion", texto1, re.I)
print(findall)

print("-----Split-------")

#Split
print(re.split(":", texto1))

print("-------Sub-------")

#Sub
print(re.sub("Expresiones", "RegEx", texto1))

print("--------Pattern--------")
##Patterns
pattern = r"[L-l]eccion|[E-e]xpresiones"
print(re.findall(pattern, texto1))

pattern = r"[0-9]"
print(re.search(pattern, texto1))

pattern = r"[l].*"
print(re.findall(pattern, texto1))


print("---------Email-------")
# Email Validation Regular Expresion

pattern = r"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"
email = "l.covesguzman@gmail.com"

print(re.match(pattern, email))
print(re.search(pattern, email))





