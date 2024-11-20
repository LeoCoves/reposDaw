## Funciones de orden Superior

from functools import reduce
def sumOne(value):
    return value + 1

def sumTwoValuesandOne(number1, number2):
    return sumOne(number1 + number2)

print(sumTwoValuesandOne(4, 4))


##Clousures
def sum_ten():
    def add(value):
        return value + 10
    return add


addClousure = sum_ten()

print(addClousure(5))


####

numbers = [43, 32, 23, 4, 31]

def multiplicar2(n):
    return n * 2


print(list(map(multiplicar2, numbers)))

print(list(map(lambda value: value / 2, numbers)))


##Filter 

def filtrerTen(n):
    if n > 10:
        return True
    return False

print(list(filter(filtrerTen, numbers)))

print(list(filter(lambda n: n > 10, numbers)))

##Reduce

def sumTwoValues(n1, n2):
    return n1 + n2

print(reduce(sumTwoValues, numbers))
#Reduce es un acumulador, va acumulando el valor en el n1 sumando 
#el siguiente como n2