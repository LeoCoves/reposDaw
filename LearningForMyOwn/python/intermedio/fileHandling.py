## File Handling

import os
# .txt file

archivo = open("python/intermedio/file.txt", "r+") # Escribir w+
# print(archivo.read())
# print(archivo.readline())
# print(archivo.readlines())

for line in archivo.readlines():
    print(line)

# os.remove("python/intermedio/file.txt") #Eliminar Fichero

