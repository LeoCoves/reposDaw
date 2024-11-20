# Sets
# Es un tipo de dato
# Un set no es una estructura ordenada
# Al no ser ordenada no se puede acceder a x elemento por su pos
# Otra diferencia es que no admite repetidos. Lo ordena por un hash interno


my_set = set(34, 54, 12, 5)
my_otherset = {}

print(type(my_set))
print(type(my_otherset)) #Inicialmente es un diccionario

my_otherset = {"Leo", "Coves", 19} 
print(type(my_otherset)) #Ahora devuelve un set
print(len(my_otherset))
print(my_otherset)
print("------")

my_otherset.add("Guzman")
print(my_otherset)

my_otherset.add("Coves")
print(my_otherset) #No admite añadir elementos repetidos

print("Coves" in my_otherset)
print("Cove" in my_otherset)

my_otherset.remove("Guzman")
print(my_otherset)

print(my_set.union(my_otherset).union({"Js", "C#"}))