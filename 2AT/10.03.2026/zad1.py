from tkinter import *
from tkinter import messagebox
def oblicz_Ek():
    try:
        m = float(entry_masa.get())
        v = float(entry_predkosc.get())
        Ek = 0.5 * m * v**2
        label_wynik.config(text=f"Energia kinetyczna: {Ek:.2f} [J]")
    except ValueError:
        messagebox.showerror("Bład","Podaj poprawnie liczy!")


okno = Tk()
okno.title("Kalkulator Energi Kinetycznej")
okno.geometry("300x250")

#masa
entry_masa = Entry(okno)
entry_masa.pack()

#predkość
entry_predkosc = Entry(okno)
entry_predkosc.pack()

#pole wyniku
label_wynik = Label(okno,text="Enrgia kinetyczna: ") 
label_wynik.pack()
#przycisk obliczający ek
btn_oblicz = Button(okno,text="Oblicz",command=oblicz_Ek)

btn_oblicz.pack()

okno.mainloop()