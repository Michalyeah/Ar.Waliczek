class Pies:
    def __init__(self,_imie,_rasa,_wiek):
        self.imie = _imie
        self.rasa = _rasa
        self.wiek = _wiek
    
    def Szczekaj(self):
        print(f"{self.imie} rasy {self.rasa} wieku lat {self.wiek} szczeknij")



piesek1 = Pies("Resksio", "Groźny wilczór", 3)
piesek2 = Pies("Burek", "Spokojny buldok", 2)

piesek1.Szczekaj()
piesek2.Szczekaj()