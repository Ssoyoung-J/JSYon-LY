from tkinter import*
from tkinter.colorchooser import*
from tkinter.simpledialog import*

        
def mouseClick(event) :
    global x1, y1,x2,y2
    x1 = event.x
    y1 = event.y
    
def mouseDrop(event) :
    global x1,y1,x2,y2,penWidth,penColor,lineColor,shape
    x2 = event.x
    y2 = event.y
    if shape == "line" :
        canvas.create_line(x1,y1,x2,y2,width = penWidth, fill = penColor)
    elif shape == "oval" :
        canvas.create_oval(x1,y1,x2,y2,width=penWidth, fill = penColor, outline = lineColor)
    elif shape == "rectangle" :
        canvas.create_rectangle(x1,y1,x2,y2,width=penWidth, fill = penColor, outline = lineColor)

def Line() :
    global shape
    shape = "line"

def Oval() :
    global shape
    shape = "oval"

def Rectangle() :
    global shape
    shape = "rectangle"
           
def getpenColor() :
    global penColor
    color = askcolor()
    penColor = color[1]

def getlineColor() :
    global lineColor
    color = askcolor()
    lineColor = color[1]
    
def getWidth() :
    global penWidth
    penWidth = askinteger("선 두께", "선 두께(1~10)를 입력하세요", minvalue =1, maxvalue = 10)

def func_exit():
    window.quit()
    window.destroy()


window = None
canvas = None
x1,y1,x2,y2 = None, None, None, None
penColor = 'white'
lineColor = 'black'
penWidth = 5

if __name__=="__main__":
    window = Tk()
    window.title("그림판 비슷한 프로그램")
    canvas = Canvas(window,height=300,width=300)
    canvas.bind("<Button-1>",mouseClick)
    canvas.bind("<ButtonRelease-1>",mouseDrop)
    canvas.pack()

    mainMenu=Menu(window)
    window.config(menu=mainMenu)
    filemenu= Menu(mainMenu)
    figuremenu = Menu(mainMenu)
    attributemenu = Menu(mainMenu)
    mainMenu.add_cascade(label="파일",menu=filemenu)
    filemenu.add_command(label = "종료",command=func_exit)
    mainMenu.add_cascade(label="도형",menu=figuremenu)
    figuremenu.add_command(label="선분",command = Line)
    figuremenu.add_separator()
    figuremenu.add_command(label="원",command = Oval)
    figuremenu.add_separator()
    figuremenu.add_command(label="사각형",command = Rectangle)
    mainMenu.add_cascade(label="속성",menu=attributemenu)
    attributemenu.add_command(label="선두께",command = getWidth)
    attributemenu.add_separator()
    attributemenu.add_command(label="선색깔",command = getlineColor)
    attributemenu.add_separator()
    attributemenu.add_command(label="면색깔",command = getpenColor)


    window.mainloop()
    
    
    

