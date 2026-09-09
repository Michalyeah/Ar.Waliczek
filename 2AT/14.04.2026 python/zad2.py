class Pracownik:
    def __init__(self,imie,pensja):
        self.imie = imie
        self.pensja = pensja

class Manager(Pracownik):
    def __init__(self, imie, pensja,premia):
        super().__init__(imie, pensja)
        self.premia = premia
    def pokaz_wynagrodzenie(self):
        print(f"{self.imie} zarabia {self.pensja + self.premia} zł")

m = Manager("Jan",5000,2000)
m.pokaz_wynagrodzenie()