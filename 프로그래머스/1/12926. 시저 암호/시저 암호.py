def solution(s, n):    
    apl = 'abcdefghijklmnopqrstuvwxyz'    
    answer = ''
    
    for c in s:
        if c == ' ':
            answer += c
            continue
        
        a = apl[(apl.find(c.lower()) + n) % len(apl)]
        
        if c.isupper(): 
            answer += a.upper()
        else: 
            answer += a.lower()
        
    
    return answer