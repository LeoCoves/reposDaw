# 30 days with python Github/ Probarlo
string_variable = "My String variable"

print(string_variable)

int_variable = 5
print(int_variable)
print(type(int_variable))

print(string_variable, "deberia ser",int_variable)

int_variable_toString = str(int_variable)
print(type(int_variable_toString))

# Funciones del Sistema
print(len(string_variable))

#Variables en una sola linea (Manera de definir variables peligrosa)
name, surname, age = "Leo", "Coves", 19
print("Hola, me llamo", name, surname, "y tengo", age,  "años")

#No suele usarse a no ser que usemos terminal
""""
name = input("Como te llamas?")
studies = input("Y que estudias?")

print(name, "estudia", studies)
"""
#'Forzar' un tipo de variable
adress: str = "Mi direccion"
adress = 25
print(type(adress)) #Cambia a int automaticamente
adress_float = float(adress)
print(type(adress_float)) 