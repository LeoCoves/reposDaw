##Tipos de Error

#SyntaxError / Error de Sintaxis

# print "Hola" #SyntaxError
print("Hola")

#NameError

# print(name) #NameError (is not defined)
name = "leo"
print(name)

#IndexError
my_list = ["Python", "Js", "C#", "Kotlin"]
# print(my_list[7]) #IndexError, list index out of range
print(my_list[0])


#ModuleNotFoundError
# import maths #No module name maths
import math

#AttributeError
# print(math.PI) #module math has no attribute PI
print(math.pi)

#KeyError
myDict = {"Nombre":"Leo", "Apellido": "Coves", "Edad":19}
# print(myDict["Apelido"]) #No encuentra esa key
print(myDict["Apellido"])

#ImportError
# from math import PI 
from math import pi