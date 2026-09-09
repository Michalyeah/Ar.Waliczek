#[]  lista, index - Tak, modyfikacja - mutowalne
#()  tupla, index - Tak, modfikcajca - niemutowalne
#{}  slownik, index - Nie
#set()  zbiór, index - Nie

mojalista = ['aaa', 'bbb', 'ccc']
mojatupla = ('aaa', 'bbb', 'ccc')
mojslownik = {
    'imie':'Michal',
    'nazwisko':'Kula',
    'wiek': 15
}

mojzbior = set('aaa', 'bbb', 'ccc')

print(mojalista[1])
print(mojatupla(1))
print(mojslownik['nazwisko'])
print(mojzbior)