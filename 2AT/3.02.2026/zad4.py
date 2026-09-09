import random
mylist = []
suma = 0
for v in range(1,10):
    w = random.randint(1,100)
    suma += w
    mylist.append(w)

print(mylist)
print(suma)
print(suma/len(mylist))
