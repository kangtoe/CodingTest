def gcd(a,b):
    while b:
        a, b = b, a%b
    return a

def solution(a, b):
    n = b // gcd(a,b)    
    
    while True:
        if n % 2 != 0: break
        n /= 2
        
    while True:
        if n % 5 != 0: break
        n /= 5
    
    return 1 if n == 1 else 2