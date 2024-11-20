##List comprehesion

my_originlist = ["Leo", "Coves", "Guzman"]

my_list = [i for i in my_originlist]

print(my_list)

def sumFive(num):
    return num + 5

my_list = [sumFive(i) for i in range(8)]

print(my_list)