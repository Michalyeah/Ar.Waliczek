from tkinter import *

okno = Tk()

def klawiszLeft():
    print('klawisz lEwicA')
def klawiszRight():
    print('klawisz PrAwIcA')
def klawiszSrodkowy():
    print('klawisz Sroda')


ramka = Frame(okno,width=480,height=320)


ramka.bind('<Button-1>',klawiszLeft())
ramka.bind('<Button-2>',klawiszSrodkowy())
ramka.bind('<Button-3>',klawiszRight())
ramka.pack()
przycisk = Button(okno,text='Klinkaj',command=klawiszLeft)
przycisk = Button(okno,text='Klinkaj',command=klawiszSrodkowy)
przycisk = Button(okno,text='Klinkaj',command=klawiszRight)

przycisk.pack()
okno.mainloop()