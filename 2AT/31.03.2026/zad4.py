class Zwiezrze:
    def __init__(self, imie):
        self.imie = imie
    def wydaj_dzwiek(self):
        print("Zwierze wydaje dzwięk...")

class Kot(Zwiezrze):
    def wydaj_dzwiek(self):
        print(f"{self.imie} mówi: Miau")

class Swinia(Zwiezrze):
    def wydaj_dzwiek(self):
        print(f"{self.imie} mówi: Chrum boczek pyszny mniam mniam w przecenie w Lewiatanie ")


class Krowa(Zwiezrze):
    def wydaj_dzwiek(self):
        print(f"{self.imie} mówi: Muuuuuuuuuu....")

kot = Kot("Mruczek")
kot.wydaj_dzwiek()

swinia = Swinia("Boczek")
swinia.wydaj_dzwiek()

krowa = Krowa("Gimper")
krowa.wydaj_dzwiek()

        

    