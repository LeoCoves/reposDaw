##Exceptions   

n1 = 5
n2 = "1"

#Try except
try:
    print(n1 + n2)
    print("Todo correcto")

except:
    print("Se ha producido un error")


n3 = 5
n4 = 1

##Tru except else
print("-------")

try:
    print(n3 + n4)
    print("Todo correcto")

except:
    print("Se ha producido un error")

else:
    print("La ejecucion continua")


print("-------")
#Try except else
try:
    print(n3 + n2)
    print("Todo correcto")

except:
    print("Se ha producido un error")

else:
    print("La ejecucion continua")

finally:
    print("Se hace si o si")


print("------")
##Captura de Excepciones de tipo TypeError o ValueError
try:
    print(n3 + n2)
    print("Todo correcto")

except ValueError:
    print("Se ha producido un error de value")

except TypeError as error: #Variable del error
    print("Se ha producido un error de tipo")
    print(error) #Muestra informacion

except Exception: #Cualquier excepcion
    print("Se ha producido un error de value")
