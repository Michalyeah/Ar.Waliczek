#utwórz kalkulator Energi potencjalnej

from tkinter import *
from tkinter import messagebox
def oblicz_Ep():
    try:
        m = float(entry_masa.get())
        g = float(10)
        h = float(entry_wysokosc.get())
        Ep = m*g*h
        label_wynik.config(text=f"Energia potencjalna: {Ep:.2f} [J]")
    except ValueError:
        messagebox.showerror("Bład","Podaj poprawnie liczy!")


okno = Tk()
okno.title("Kalkulator Energi Kinetycznej")
okno.geometry("300x250")

#masa
label_masa = Label(okno,text="Masa moc kiełbasa")
label_masa.pack()
entry_masa = Entry(okno)
entry_masa.pack()

#wyokosc
label_wys = Label(okno,text="Wysokosc")
label_wys.pack()
entry_wysokosc = Entry(okno)
entry_wysokosc.pack()

#pole wyniku
label_wynik = Label(okno,text="Enrgia potencjalna: ") 
label_wynik.pack()
#przycisk obliczający ek
btn_oblicz = Button(okno,text="Oblicz",command=oblicz_Ep)

btn_oblicz.pack()

okno.mainloop()