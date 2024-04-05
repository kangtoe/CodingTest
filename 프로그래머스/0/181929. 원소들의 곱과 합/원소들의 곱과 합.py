def solution(num_list):
    mult = 1
    sumNum = 0
    
    for i in num_list:
        sumNum += i
        mult *= i
                
    return int(mult < sumNum**2)