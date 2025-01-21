def solution(n):
    
    i = 0
    a, b = 0, 1
    for j in range(n):
        i = (a + b) % 1000000007
        a = b
        b = i
    
    return i