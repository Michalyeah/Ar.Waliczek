# zad 1 utwórz liste która prezentuje liczby od lewej tylko parzyste oraz od prawej tylko nieparzyste


mylist1 = [5,3,7,3,2,6]
liczbParzysta = [v for v in mylist1 if v % 2 == 0]
liczbParzysta.sort()
mylist2 = [1,6,8,3,4,2,]
liczbNieParzysta = [v for v in mylist1 if v % 2 != 0]
liczbNieParzysta.sort()

jednaLista = liczbParzysta+liczbNieParzysta
print(jednaLista)






















#zad 2 majać wygnerowaną liste liczb pseudo losowych 10 z zakresu od 1 do 100 . Wyznacz średnią, min, max i sume. Posortuj liste rosnąco oraz malejąco .