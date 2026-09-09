class Osoba:
    def __init__(self,_imie,_nazwisko):
        self.imie = _imie
        self.nazwisko = _nazwisko
    def przedsawt_sie(self):
        print(f"Nazywam się: {self.imie} {self.nazwisko}")


class Uczen(Osoba):
    def __init__(self, _imie, _nazwisko, _klasa , _srednia):
        super().__init__(_imie, _nazwisko)
        self.klasa = _klasa
        self.srednia = _srednia

    def pokaz_ucznia(self):
        print(f"{self.imie} {self.nazwisko} {self.klasa} {self.srednia}")

uczen1 = Uczen("Adam", "Nowak", "2CT", 4.5)

uczen1.przedsawt_sie()
uczen1.pokaz_ucznia()