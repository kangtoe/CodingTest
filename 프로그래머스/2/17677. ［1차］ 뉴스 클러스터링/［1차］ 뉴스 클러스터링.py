def getU(arr1, arr2):
    arr = []
    setArr = set(arr1 + arr2)    
    for a in setArr:
        m = max(arr1.count(a), arr2.count(a)) 
        arr.append(m)        
    return sum(arr)

def getN(arr1, arr2):
    arr = []
    setArr = set(arr1 + arr2)    
    for a in setArr:
        m = min(arr1.count(a), arr2.count(a)) 
        arr.append(m)        
    return sum(arr)

def toArr(str0):
    arr = []
    for i in range(len(str0) - 1):
        a, b = str0[i], str0[i+1]
        if not (a.isalpha() and b.isalpha()): continue
        arr.append(a+b)
    return arr

def solution(str1, str2):
    arr1 = toArr(str1.upper())
    arr2 = toArr(str2.upper())
    
    n = getN(arr1,arr2)
    u = getU(arr1,arr2)
    #print(n, u)
    
    if n == 0 and u == 0: return 65536
    return int(n/u*65536)