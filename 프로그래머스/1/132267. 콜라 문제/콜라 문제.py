def solution(a, b, n):
    c = 0
    
    while n >= a:
        left = n % a # 가져다주고 남은 빈병
        newC = (n // a) * b # 받게될 콜라
        c += newC
        n = left + newC
    
    return c