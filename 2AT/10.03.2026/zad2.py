#Utwórz aplikacje która kalkutor BMI  


from tkinter import *
from tkinter import messagebox
def oblicz_BMI():
    try:
        m = float(entry_masa.get())
        h = float(entry_height.get())
        BMI = m/h**2
        label_wynik.config(text=f"BMI: {BMI:.2f}")
    except ValueError:
        messagebox.showerror("Bład","Podaj poprawnie liczy!")

okno = Tk()
okno.title("Kalkulator BMI")
okno.geometry("300x250")

#masa
label_masa = Label(okno,text="Masa moc kiełbasa")
label_masa.pack()
entry_masa = Entry(okno)
entry_masa.pack()

#wysokość
entry_height = Entry(okno)
entry_height.pack()

#pole wyniku
label_wynik = Label(okno,text="BMI: ") 
label_wynik.pack()
#przycisk obliczający BMI
btn_oblicz = Button(okno,text="Oblicz",command=oblicz_BMI)

btn_oblicz.pack()

okno.mainloop()