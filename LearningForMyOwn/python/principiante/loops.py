#Loops o bucles
#Los corchetes se usan en py con :

my_condition = 0

while my_condition < 10:
    print(my_condition)
    my_condition += 1

print("##")
#For

my_list = [34, 23, 64, 76, 23]

for element in my_list:
    print(element)

print("##")
##

my_tuple = (19, 1.73, "Coves", "Leo", "Coves")
for element in my_tuple:
    print(element)

print("##")
##
my_set = {34, 54, 12, 5}
for element in my_set:
    print(element)

print("##")
##
my_otherdict = {1:"Python", "Nombre":"Leo", "Apellido":"Coves", "Edad":35}
for element in my_otherdict:
    print(element)
print("---Values:---")
for element in my_otherdict.values():
    print(element)