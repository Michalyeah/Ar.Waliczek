from tkinter import *

okno = Tk()

topframe = Frame(okno) # w którym oknie ma się znajdować głowna ramka
topframe.pack()

bottomframe = Frame(okno)
bottomframe.pack(side=BOTTOM)

button1 = Button(topframe,text='Klinkaj mnie 1', fg='black')
button2 = Button(topframe,text='Klinkaj mnie 1', fg='red')
button3 = Button(bottomframe,text='Klinkaj mnie 1', fg='blue')
button4 = Button(bottomframe,text='Klinkaj mnie 1', fg='cyan')

button1.pack(side=LEFT)
button2.pack(side=RIGHT)
button3.pack()
button4.pack()


okno.mainloop()