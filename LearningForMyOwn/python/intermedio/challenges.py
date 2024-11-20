##Challenges

# Escribe un programa que muestre por consola (con los print)
# los numeros de 1 a 100 (ambos incluidos y con un salto de linea 
# entre cada impresion), sustituyendo los siguientes
# -Multiplos de 3 por la palabra "fizz"
# -Multiplos de 5 por la palabra "buzz"
# -Multiplos de 3 y 5 a la vez por la palabra fizzbuzz

def fizzbuzz():
    for index in range(1,101):
        if(index % 3 == 0 and index % 5 == 0):
            print("fizzbuzz")
        elif(index % 3 == 0):
            print("fizz")
        elif(index % 5 == 0):
            print("buzz")
        else:
            print(index)

fizzbuzz()

#Comprobar si es un anagrama
# Escribe una funcion que reciba dos palabras (String) y retorne
# verdadero o falso segun sean o no anagramas.
# Un anagrama consiste en formar una palabra reordenando Todas
# las letras de otra palabra inicial
# No hace falta comprobar que ambas palabras existan
# Dos palabras exactamente iguales no son anagramas

si = "Hola"
print(sorted(si))

def is_Anagrama(word1, word2):
    if (word1.lower() == word2.lower()):
        return False
    return sorted(word1.lower()) == sorted(word2.lower())


print(is_Anagrama("amor", "Roma"))


# Escribe un programa que imprima los 50 primeros numeros de la sucesion
# de Fibonacci empezando por el 0
# La serie de Fibonacci se compone por una sucesion de numeros en las que
# el siguiente siempre es la suma de los dos anteriores
# 0, 1, 1, 2, 3, 5, 8, 13 ....

def fibonacci():
    anterior = 0
    siguiente = 1

    for index in range(1,51):
        print(index, "->", anterior)
        fib = anterior + siguiente
        anterior = siguiente
        siguiente = fib
        
        

fibonacci()


# ¿Es un num primo?
# Escribe un programa que se encargue de comprobar si un numero es primo o no
# Hecho Esto, imprime los numeros entre 1 y 100


def esPrimo(n):
    if(n <= 2):
        return True
    for index in range(2, n):
        if(n % index == 0):
            return False
        else:
            return True
        
print(esPrimo(3))