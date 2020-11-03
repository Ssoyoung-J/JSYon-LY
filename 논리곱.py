num1,num2= 0,0
num1=int(input("숫자1을 입력하세요 : "))
binary1 = bin(num1) 
num2=int(input("숫자2을 입력하세요 : "))
binary2 = bin(num2)
binary3= bin(num1&num2)
print(binary3)
