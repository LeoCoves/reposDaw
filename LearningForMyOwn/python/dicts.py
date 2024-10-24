# Diccionarios

#Funciona como una lista pero tiene una arquitectura
# Arquitectura (key:value) que es lo mismo que clave:valor

#Define un diccionario
my_dict = dict()
my_otherdict =  {}

print(type(my_otherdict))

my_otherdict = {1:"Python", "Nombre":"Leo", "Apellido":"Coves", "Edad":35}
print(my_otherdict)

my_dict = {
        "Nombre":"Leo",
        "Apellido":"Coves", 
        "Edad":35,
        "Lenguajes": {"Python", "JS", "Kotlin"},
        1: 1.73
}
print(my_dict)

print(my_dict["Nombre"])

# Añadir un nuevo valor al diccionario
my_dict["Calle"] = "Verdi"
print(my_dict["Calle"])

# Eliminar un elemento en el diccionario
del my_dict["Calle"]
print(my_dict)


print("Coves" in my_dict) # Da false porque busca la clave, no el valor
print("Apellido" in my_dict) #Da true porque es la clave
print("Coves" in my_dict.values()) #Daria true

#Operaciones

print(my_dict.items()) #Retorna el listado del diccionario
print(my_dict.keys()) #Retorna las claves
print(my_dict.values()) #Retorna los valores

x = "Key1", "Key2", "Key3"
my_newdict = my_otherdict.fromkeys(x)
#Crear un diccionario con claves y sin values
print(my_newdict)



