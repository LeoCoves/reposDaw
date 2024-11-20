## Clases

class MyEmptyPerson:
    pass

print(MyEmptyPerson)

#Definir un constructor de una clase
#Self significa el mismo, es como this, es su propia instancia
class Person:
    def __init__(self, name, surname, age, alias = "Sin alias"):
        self.name = name
        self.surname = surname
        self.age = age

    def walk(self):
        print(f"{self.name} {self.surname} esta caminando")
    
    def birthday(self):
        self.age += 1

    def showInfo(self):
        print(f"{self.name} {self.surname} tiene {self.age} años")

my_person1 = Person("Leo", "Coves", 19)
print(my_person1.name)

print(f"Nombre Completo: {my_person1.name} {my_person1.surname}")
my_person1.walk()
my_person1.birthday()
my_person1.showInfo()

my_person2 = Person("Alejandro", "Gar", 22, "Alex")

