from tkinter import *
import math
from tkinter import messagebox
def oblicz_dlugosc():
    try:
        x1 = float(entry_x1.get())
        y1 = float(entry_y1.get())
        x2 = float(entry_x2.get())
        y2 = float(entry_y2.get())
        dlugosc = math.sqrt((x2 - x1)**2 + (y2 - y1)**2)
        label_wynik.config(text=f"Długość odcinka wynosi: {dlugosc:.2f} cm")
    except ValueError:
        messagebox.showerror("Bład","Podaj poprawnie liczy!")


okno = Tk()
okno.title("Kalkulator długości odcinka")
okno.geometry("300x250")


label_x1 = Label(okno,text="Podaj x1: ")
label_x1.pack()
entry_x1 = Entry(okno)
entry_x1.pack()

label_y1 = Label(okno,text="Podaj y1: ")
label_y1.pack()
entry_y1 = Entry(okno)
entry_y1.pack()

label_x2 = Label(okno,text="Podaj x2: ")
label_x2.pack()
entry_x2 = Entry(okno)
entry_x2.pack()

label_y2 = Label(okno,text="Podaj y2: ")
label_y2.pack()
entry_y2 = Entry(okno)
entry_y2.pack()

#pole wyniku
label_wynik = Label(okno,text="Długość odcinka wynosi: ") 
label_wynik.pack()
#przycisk obliczający dlugosc odcinka
btn_oblicz = Button(okno,text="Oblicz",command=oblicz_dlugosc)

btn_oblicz.pack()

okno.mainloop()