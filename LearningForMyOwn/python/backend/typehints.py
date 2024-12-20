# TYPE HINTS

print("-------Tipado Dinamico-------")

textoVar = "My String Variable"
print(textoVar)
print(type(textoVar))

textoVar = 5
print(textoVar)
print(type(textoVar))

print("-------Tipado Debil-------")

textoTypeVar: int = "Hola mundo"
print(textoTypeVar)
print(type(textoTypeVar))

textoTypeVar = 5
print(textoTypeVar)
print(type(textoTypeVar))