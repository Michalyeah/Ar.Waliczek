from tkinter import *

okno = Tk()
imieEt = Label(okno,text='Imie',bg='black',fg='white')
nazwiskoEt = Label(okno,text='Nazwisko',bg='black',fg='white')

entryImie =Entry(okno)
entryNazwisko = Entry(okno)

imieEt.grid(row=0,sticky=E)
nazwiskoEt.grid(row=1,sticky=E)

entryImie.grid(row=0,column=1)
entryNazwisko.grid(row=1,column=1)

poleCheckbox = Checkbutton(okno,text='Zaznaczaj mnie....... DO IT!')
poleCheckbox.grid(columnspan=3)

okno.mainloop()