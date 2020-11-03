from tkinter import *
from tkinter.colorchooser import*
from tkinter.simpledialog import*

#함수 #
def mouseClick(event) :
    global x1, y1, x2, y2
    x1 = event.x
    y1 = event.y

def mouseDrop(event):
    global x1, y1, x2, y2, penWidth, penColor, fillColor, shapeKind
    x2 = event.x
    y2 = event.y
    if shapeKind == "line":
        canvas.create_line(x1, y1, x2, y2, width = penWidth, fill = penColor)
    elif shapeKind == "oval":
        canvas.create_oval(x1, y1, x2, y2, width = penWidth, fill = fillColor, outline = penColor)
    elif shapeKind == "rectangle":
        canvas.create_rectangle(x1, y1, x2, y2, width = penWidth, fill = fillColor, outline = penColor)
        
def getColor():
    global penColor
    color = askcolor()
    penColor = color[1]

def getFillColor():
    global fillColor
    color = askcolor()
    fillColor = color[1]

def getWidth():
    global penWidth
    penWidth = askinteger("선두께","선두께1~10중 입력하세요", minvalue = 1, maxvalue = 10)

def drawLine():
    global shapeKind
    shapeKind = "line"

def drawOval():
    global shapeKind
    shapeKind = "oval"

def drawRectangle():
    global shapeKind
    shapeKind = "rectangle"

# 전역변수#
window = None
canvas = None
x1, y1, x2, y2 = None, None, None, None
penColor = 'black'
penWidth=5
fillColor=None
shapeKind = "line"

#메인#
if __name__=="__main__":
    window=Tk()
    window.title("그림판만들기")
    canvas = Canvas(window, height = 300, width = 300)
    canvas.bind("<Button-1>", mouseClick)
    canvas.bind("<ButtonRelease-1>", mouseDrop)
    canvas.pack()

    mainMenu = Menu(window)
    window.config(menu=mainMenu)

    shapeMenu = Menu(mainMenu, tearoff=False)
    mainMenu.add_cascade(label="모양",menu=shapeMenu)
    shapeMenu.add_command(label="선",command=drawLine)
    shapeMenu.add_command(label="원",command=drawOval)
    shapeMenu.add_command(label="사각형",command=drawRectangle)
    
    setupMenu = Menu(mainMenu)
    mainMenu.add_cascade(label="설정", menu=setupMenu)
    setupMenu.add_command(label="선색상선택", command=getColor)
    setupMenu.add_separator()
    setupMenu.add_command(label="면색상선택", command=getFillColor)
    setupMenu.add_separator()
    setupMenu.add_command(label="선두깨설정", command=getWidth)

    window.mainloop() 
