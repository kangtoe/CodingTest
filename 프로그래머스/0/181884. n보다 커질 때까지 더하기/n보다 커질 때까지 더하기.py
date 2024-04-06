def solution(numbers, n):
    
    sum = 0
    for num in numbers:
        sum += num
        
        if sum > n:
            return sum