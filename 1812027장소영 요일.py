year,month,day ,preY,tot,d2=0, 0, 0, 0, 0, 0

print("** 요일 계산 프로그램 **")
year = int(input("연도를 입력하세요. : "))
month = int(input("월을 입력하세요. : "))
day = int(input("일을 입력하세요. : "))
preY = year -1
tot = preY * 365 + (preY/4 - preY/100 + preY/400)
days = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31]

for a in range (0,(month -1) ):
    tot += days[a]
if((year % 4 ==0) and (year % 100 != 0)) or (year % 400 == 0) :
    tot= tot+1
tot += day

d2 = int(tot % 7)
dA = ['일', '월', '화', '수', '목' ,'금' , '토']

print ("\n%d 년 %d 월 %d일은 \n""1년 1월 1일 부터 전체 %d 일 이며,\n" "%s요일 입니다." %(year,month, day, tot, dA[d2]))

