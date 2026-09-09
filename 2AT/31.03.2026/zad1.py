# OPP 
class Samochod:
    def __init__(self,_marka,_model,_rok):
        self.marka = _marka
        self.model = _model
        self.rok = _rok

    def opisSamochodu(self):
        print(f"Samochód: {self.marka}, {self.model}, {self.rok}")

sam1 = Samochod("Toyota","Corolla",2020)

sam2 = Samochod("Chevrolet","X",2026)

sam1.opisSamochodu()
sam2.opisSamochodu()

# __init__ == Samochod - to jest konstruktr klasy, znaczy ze ta funkcja/metoda uruchamia sie jako
#  pierwsza w trakcie tworzenia nowego obiektu