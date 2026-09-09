"""
Pojazd: prdekosc, waga, nazwa
Samochod: kolor, rodzaj, paliwo
Rower: kolor rodzaj, paliwo
Deskorolka: kolor, rodzaj, paliwo


Metody: opis_pojazdu,ilosc_paliwa, konstruktorzy...
"""

class Pojazd:
    def __init__(self,nazwa,waga,predkosc):
        self.nazwa = nazwa
        self.waga = waga
        self.predkosc = predkosc
class Samochod(Pojazd):
    def __init__(self, nazwa, waga, predkosc,kolor,rodzaj,paliwo):
        super().__init__(nazwa, waga, predkosc)
        self.kolor = kolor
        self.rodzaj = rodzaj
        self.paliwo = paliwo
    def opis_pojazdu(self):
        print(f"{self.nazwa} o wadze {self.waga} kg osiąga prędkość {self.predkosc}. Wystepuje w kolorze {self.kolor},typ {self.rodzaj} oraz ma pojemnosc {self.paliwo}")
    def ilosc_paliwa(self):
        print(f"Rocznie zużywa {self.paliwo * 12} litrów rocznie")
class Rower(Samochod):
    def ilosc_paliwa(self):
        print(f"Rocznie zużywa {self.paliwo} kilokalori na godzine")
class Deskorolka(Samochod):
    def ilosc_paliwa(self):
        print(f"Rocznie zużywa {self.paliwo} kilokalori na godzine")

s = Samochod("Toyota",900,150,"czerwony","Corolla",40)
s.opis_pojazdu()
s.ilosc_paliwa()
r = Rower("Toyota",2,30,"czarny","Corolla",30)
r.opis_pojazdu()
r.ilosc_paliwa()
d = Deskorolka("Toyota",1,25,"zółty","Corolla",5)
d.opis_pojazdu()
d.ilosc_paliwa()

        