# Za pomocą comprehension list utwórz liste liczb podzielnych przez 5 z zakresu od 1 do 1000. Wyświetl z listy 
# co 3 element jej podnieśc do potegi drugiej i wszystkie te liczby zapisz do tupli

mylist = [v for v in range(1,1000)if v % 5 == 0]
