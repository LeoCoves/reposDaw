#strings 
name, surname, age = "Leo", "Coves", 19
print("Mi nombre es {} {} y mi edad es {}".format(name, surname, age))
print("Mi nombre es %s %s y mi edad es %d" %(name, surname, age))
#La mejor manera
print(f"Mi nombre es {name} {surname} y mi edad es de {age}")

print("Mi nombre es " + name + " " + surname) #Incorrecto


#Desempaquetado de caracteres
language = "Python"
a, b, c, d, e, f = language
print(a)
print(b)

#Division
language_slice = language[0:3]
print(language_slice) # Pyt

language_slice = language[2:5]
print(language_slice) # tho

language_slice = language[-2]
print(language_slice) #o

language_slice = language[0:6:2] #Coge del car 0 al 6 y cada 2, evita un caracter
print(language_slice) #Pto

language_reversed = language[::-1]
print(language_reversed) #nohtyP


print("-------------------")
print(language.capitalize()) #Primera letra mayuscula
print(language.upper()) #Todas las letras mayusculas
print(language.count("t")) #Cuenta cuantas t tengo
print(language.isnumeric()) #False porque es string
print(language.lower()) #Todas minusculas
print(language.lower().isupper()) #Todas Minusculas y comprueba si son todas mayusculas
print(language.lower().islower()) #Devuelve true
print(language.startswith("Py")) # Empieza por Py? Sensible a minusculas y mayusculas
