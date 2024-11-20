# Listas

# Definir una lista
my_list = list()
my_otherlist = [19, 1.77, "Coves", "Leo"]

print(type(my_list))
print(type(my_otherlist))

my_list = ["leo", 1, 10, 11, 100, 101, 110, 111, "leo"]

pos = len(my_list) #Para contar caracteres o longitud

print(my_list[pos - 1])

print(my_list.count("leo")) #Hay dos leo // Para contar elementos

age, height, name, surname = my_otherlist

print(age)

print(my_otherlist)

my_otherlist.append("DAW")


print(my_otherlist)

my_otherlist.insert(2, "Lista:")

print(my_otherlist)

my_otherlist.remove("Lista:")

print(my_otherlist)

my_otherlist.pop() #Quita el ultimo elemento de la lista
my_otherlist.pop(1) #Quita el elemento en la posicion que le mandas

print(my_otherlist)

print("---------")
print(my_list)

my_newlist = my_list.copy() ###############

del my_list[2] #Borraria la tercera posicion (10)
print(my_list)

my_list[0] = "Lista Primera pos" #Cambia la primera pos
print(my_list)

my_list.clear() #Borra toda la lista
print(my_list) #Lista vacia
print(my_newlist) ##################

my_newlist.reverse()
print(my_newlist)


# my_newlist.sort()
# print(my_newlist)
# Daria error porque hay strings y int en la misma lista

del my_newlist[0]
my_newlist.pop()

my_newlist.sort()
print(my_newlist) #Ordena por int de menor a mayor

print("-----------------")
print(my_newlist[1:3]) # Desde la segunda posicion hasta la cuarta
# Lo mismo que en los strings usabamos slice (string[1:3] Del segundo caracter al tercero)






