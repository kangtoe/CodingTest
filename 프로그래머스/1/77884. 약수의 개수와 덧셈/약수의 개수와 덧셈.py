def countDiv(i):
    count = 0
    for j in range(1, i+1):
        if i % j == 0: 
            count += 1
    return count
    
def solution(left, right):
    sum = 0
    for i in range(left, right + 1):
        if countDiv(i) % 2 == 0:
            sum += i
        else:
            sum -= i
        
    return sum