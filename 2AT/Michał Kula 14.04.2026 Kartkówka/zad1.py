"""
class Fabryka: własćiwośći: nazwa, lokalizacja,asortyment
class Tokarka,Frezarka,Wiertarka: materiał, ilość, cena_jednostkowa
metody: opis_produkcji, pokaz_ilosc_wyprodukowanych_detali(tablica)
"""

class Fabryka:
    def __init__(self,nazwa,lokalizacja,asortyment):
        self.nazwa = nazwa
        self.lokalizacja = lokalizacja
        self.asortyment = asortyment
        self.produkt = []
       
class Tokarka(Fabryka):
    def __init__(self, nazwa, lokalizacja, asortyment,material,ilosc,cena_jednostkowa):
        super().__init__(nazwa, lokalizacja, asortyment)
        self.material = material
        self.ilosc = ilosc
        self.cena_jednostkowa = cena_jednostkowa
        
    def opis_produkcji(self):
        print(f"{self.nazwa} wyprodukwane w {self.lokalizacja} w fabryce zajmującej się produkcją {self.asortyment}. Wyprodukwane są one z {self.material} w ilosc {self.ilosc} na palete w cenie za sztuke {self.cena_jednostkowa}.")
    def pokaz_ilosc_wyprodukowanych_detali(self,produkt):
        self.produkt.append(produkt)
        
class Frezerka(Tokarka):
    def __init__(self, nazwa, lokalizacja, asortyment, material, ilosc, cena_jednostkowa):
        super().__init__(nazwa, lokalizacja, asortyment, material, ilosc, cena_jednostkowa)
    def pokaz_ilosc_wyprodukowanych_detali(self,produkt):
        self.produkt.append(produkt)

class Wiertarka(Tokarka):
    def pokaz_ilosc_wyprodukowanych_detali(self,produkt):
        self.produkt.append(produkt)

t = Tokarka("Bosch","Rudołtowice","Tokarki","Aluminium",100,159)
t.opis_produkcji()


f = Frezerka("Bosch","Rudołtowice","Frezarki","Stal nierdzewna",100,200)
f.opis_produkcji()


w = Wiertarka("Bosch","Rudołtowice","Wiertarki","Aluminium",150,129)
w.opis_produkcji()



