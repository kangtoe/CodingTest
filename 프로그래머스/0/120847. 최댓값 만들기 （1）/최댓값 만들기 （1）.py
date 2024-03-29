def solution(numbers):    
    
    max1 = max(numbers)
    del numbers[numbers.index(max1)]
    max2 = max(numbers)    
    
    return max1 * max2