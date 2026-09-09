class Produkt:
    def __init__(self,nazwa,cena):
        self.nazwa = nazwa
        self.cena = cena
        
class Koszyk:
    def  __init__(self):
        self.produkty = []
    
    def dodaj_produkty(self,produkt):
        self.produkty.append(produkt)

    def pokaz_produkty(self):
        for p in self.produkty:
            print(f"{p.nazwa} - {p.cena} zł")
    def pokaz_wartosc(self):
        suma = 0
        for p in self.produkty:
            suma += p.cena
        return suma

k = Koszyk()
k.dodaj_produkty(Produkt("chleb",10))
k.dodaj_produkty(Produkt("mleko",4)) 
k.dodaj_produkty(Produkt("woda",2)) 
k.pokaz_produkty()
print("Suma: ",k.pokaz_wartosc())
        