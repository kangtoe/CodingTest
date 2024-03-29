def solution(numbers, k):
    num = 1
    k -= 1
    while True:
        
        num += 2
        if num > len(numbers):
            num = num - len(numbers)
        
        k -= 1        
        #print (k, num)        
        if k == 0:
            return num