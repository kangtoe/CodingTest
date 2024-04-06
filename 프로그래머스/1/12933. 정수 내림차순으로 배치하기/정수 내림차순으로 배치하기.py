def solution(n):
    
    arr = list(s for s in str(n))
    arr.sort(reverse = True)
    
    s = ''
    for a in arr:
        s += a
            
    return int(s)