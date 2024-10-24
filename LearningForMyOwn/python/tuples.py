# Tuplas
# Similares a las listas
# La principal diferencia es que las tuplas son inmutables, es decir,
# sus valores son constantes y no dejan cambiar los valores de la tupla
# No existen insert ni remove

#Definir una tupla
my_tuple = tuple()
my_othertuple = ()


my_tuple = (19, 1.73, "Coves", "Leo", "Coves")
my_othertuple = (19, 30, 50, 23, 34)

print(my_tuple)
print(type(my_tuple))

print(my_tuple[0]) # Primera pos 
print(my_tuple[-2]) # Penultima pos

print(my_tuple.index("Leo")) #Devuelve la pos en la tupla
print(my_tuple.count("Coves"))

# my_tuple[1] = 1.80
# print(my_tuple) #Da error porque las tuplas son inmutables

sum_tuple = my_tuple + my_othertuple
print(sum_tuple)

#Solucion para los datos inmutables
my_tuple = list(my_tuple)
print(type(my_tuple))
print("-----")
del my_tuple[4]
my_tuple[3] = "Leonardo"
my_tuple = tuple(my_tuple)
print(type(my_tuple))
print(my_tuple)

del sum_tuple
print(sum_tuple) #Daria error pero no porque no la elimine, sino porque no existe
                    # ya que esta eliminada