#list comprehension
zasieg = int(input("Podaj ilosc elementow"))
mylist = [ v for v in range(zasieg)]
print(mylist)

mylist2 = [v for v in range (9,27) if v % 2 == 0]

print(mylist2)