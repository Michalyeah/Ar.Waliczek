podaj_imie = input('Podaj swoje imie...')
print(podaj_imie)
print(len(podaj_imie))

#Ek = m*v^2 / 2
#Ep = m*h*g [J]


m = float(input("podaj masę:  "))
v = float(input("podaj prędkość: "))
h = float(input("podaj wysokość:  "))
g = 10
print("Ek = ", ( m * v**2) / 2, "[J]")
print("Ep = ", (m * h * g) / 2, "[J]")