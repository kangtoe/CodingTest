def to3(i):
    s = ''    
    jari = 0
    while i > 0:
        na = i % (3 ** (jari+1))
        i -= na
        s = str(na // 3 ** jari) + s                
        jari += 1
                        
    return s
    
def to10(i):
    sum = 0
    for j, s in enumerate(str(i)[::-1]):
        sum += int(s) * (3**j)
        #print(s, j)
        
    return sum

def solution(n):
    n3 = to3(n)
    re = n3[::-1]
    n10 = to10(re)
    #print(n3, re, n10)    
    
    return n10