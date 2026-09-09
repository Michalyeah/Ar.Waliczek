#kalkulator Max tętna biegacza

from tkinter import *
from tkinter import messagebox
def oblicz_MAXhr():
    try:
        wiek = float(entry_wiek.get())
        Maxhr = 208 - 0.7 * wiek
        label_wynik.config(text=f"Max tętno biegacza: {Maxhr:.2f}")
    except ValueError:
        messagebox.showerror("Bład","Podaj poprawnie liczy!")

okno = Tk()
okno.title("Kalkulator Max tętna biegacza")
okno.geometry("300x250")


#wysokość
entry_wiek = Entry(okno)
entry_wiek.pack()

#pole wyniku
label_wynik = Label(okno,text="Max tętno biegacza: ") 
label_wynik.pack()
#przycisk obliczający Maxhr
btn_oblicz = Button(okno,text="Oblicz",command=oblicz_MAXhr)

btn_oblicz.pack()

okno.mainloop()