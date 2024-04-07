def to2(n):
    tmp = ''
    while n:        
        tmp = str(n%2) + tmp
        n //= 2
        
    return tmp

def solution(n):
    count1 = to2(n).count("1")
    for i in range(n+1, n*2+1):
        if count1 == to2(i).count("1"):
                return i