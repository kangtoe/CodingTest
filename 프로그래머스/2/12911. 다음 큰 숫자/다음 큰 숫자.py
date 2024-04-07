def to2(n):
    tmp = ''
    while n:        
        tmp = str(n%2) + tmp
        n //= 2
        
    return tmp

def solution(n):
    count1 = to2(n).count("1")
    #print(count1)
    i = n
    while True:
        i += 1
        #print(i, to2(i))
        if count1 == to2(i).count("1"):
            return i