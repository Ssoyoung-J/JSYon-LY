import turtle

num1,num2,num3= 0,0,0
swidth, sheight = 1000, 300
curX, curY = 0,0

    
if __name__=="__main__" :
    turtle.title('거북이로 2진수 표현하기')
    turtle.shape('turtle')
    turtle.setup(width = swidth + 50, height = sheight + 50)
    turtle.screensize(swidth, sheight) 
    turtle.penup()
    turtle.left(90)

    num1=int(input("숫자1을 입력하세요 : "))
    binary1 = bin(num1) 
    num2=int(input("숫자2을 입력하세요 : "))
    binary2 = bin(num2)
    num3 = num1&num2
    binary3= bin(num1 & num2)
    print("%d & %d = %d " %(num1,num2,num3))
    curX = swidth /2
    curY = 0
    for i in range(len(binary1)-2) : 
        turtle.goto(curX,curY)
        if num1 & 1 : 
            turtle.color('red')
            turtle.turtlesize(2)
        else :
             turtle.color('blue')
             turtle.turtlesize(1)
        turtle.stamp()
        curX -= 50
        num1 >>=1
    
    for k in range(len(binary2)-2) : 
        turtle.goto(curX+50*(len(binary2)-4),curY-50)
        if num2 & 1 : 
            turtle.color('red')
            turtle.turtlesize(2)
        else :
             turtle.color('blue')
             turtle.turtlesize(1)
        turtle.stamp()
        curX -=50
        num2 >>=1
    for g in range(len(binary3)-2) : 
        turtle.goto(curX+50*(len(binary2)-4)+50*len(binary3),curY-100)
        if num3 & 1 : 
            turtle.color('red')
            turtle.turtlesize(2)
        else :
             turtle.color('blue')
             turtle.turtlesize(1)
        turtle.stamp()
        curX -=50
        num3 >>=1

turtle.done()
