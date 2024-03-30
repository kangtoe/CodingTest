def solution(a, b, c, d):
    answer = 0
    arr = [a, b, c, d]
    s = list(set(arr))         
        
    if len(s) == 1:
        return 1111 * a
    
    elif len(s) == 2 :
        if arr.count(s[0]) == 3:
            return (10 * s[0] + s[1]) ** 2        
        elif arr.count(s[1]) == 3:
            return (10 * s[1] + s[0]) ** 2
        
        else:                                  
            return (s[0] + s[1]) * abs(s[0] - s[1])
    
    elif len(s) == 3:  
        for c in s:
            if arr.count(c) == 2:
                s.remove(c)
                break          
        return s[0] * s[1]
               
    else:            
        return min(arr)