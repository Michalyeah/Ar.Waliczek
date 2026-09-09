from tkinter import *

okno = Tk()

etykieta1 = Label(okno,text="etykieta nr 1",bg="green")
etykieta2 = Label(okno,text="etykieta nr 1",bg="red")
etykieta3 = Label(okno,text="etykieta nr 1",bg="blue")

etykieta1.pack()
etykieta2.pack(fill=X)
etykieta3.pack(fill=Y)

okno.mainloop()