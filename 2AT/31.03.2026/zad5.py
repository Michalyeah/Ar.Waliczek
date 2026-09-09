"""
Dziedziczeni: klasa Figury, klasy dziedziczące po Figury to:Prostokąt, Kwadrat, Trojkat, Romb, Kolo.
Klasa Figury posiada konstruktor, właściwości: nazwa
Klasy dziedziczące posiadają konstruktor , dziedziczą konstruktor po Figury, posiadają funkcje obliczPole i  zaprezentujFigurę 
Figury należy wyswietlic 

"""

class Figury:
    def __init__(self,nazwa):
        self.nazwa = nazwa
    def podaj_nazwe(self):
        print(f"Nazwa figury to {self.nazwa}")

class Prostokat(Figury):
    def __init__(self, nazwa,pole):
        super().__init__(nazwa)
        self.pole = pole
    def ObliczPole(self):
        a = float(input("Podaj długość krótszego boku: "))
        b = float(input("Podaj długość dłuższego boku: "))
        self.pole = a*b
    def zaprezentujFigure(self):
        print(f"Pole {self.nazwa} wynosi {self.pole}")


figura1 = Prostokat("Protokat")
figura1.ObliczPole
figura1.zaprezentujFigure
        