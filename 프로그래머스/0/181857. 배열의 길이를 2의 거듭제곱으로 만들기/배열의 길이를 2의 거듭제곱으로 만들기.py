import math

def solution(arr):    
    
    i = 0
    iMax = 0
    while True:        
        if 2 ** i > 1000:
            iMax = i
            break
        i += 1
    
    for i in range(iMax):        
        if len(arr) == 2 ** i:
            return arr        
        elif (2 ** i) < len(arr) < (2 ** (i+1)):
            targetL = 2 ** (i+1)
            break
    
    zArr = []
    for i in range(targetL - len(arr)):
        zArr.append(0)
        
    return arr + zArr
        