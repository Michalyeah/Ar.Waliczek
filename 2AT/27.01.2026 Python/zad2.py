imie = "Michal"
nazwisko = "Kula"
wiek = 16

opis = "Moje imie " + imie + " nazwisko " + nazwisko + " wiek " + str(wiek)

print(opis)

opis2 = "Moje imie {} nazwisko {} wiek {}".format(imie,nazwisko,wiek)

print(opis2)

opis3 = f"Moje imie {imie} nazwisko {nazwisko} wiek {wiek}"

print(opis3)
