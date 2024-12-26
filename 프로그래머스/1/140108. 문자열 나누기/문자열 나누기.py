def solution(s):
    detach = 0
    
    while(s):
        countX, countNoX = 0, 0   
        x = s[0]
        for c in s:
            if(x == c): countX+=1
            else: countNoX+=1
            if(countX==countNoX):                
                break
        
        s = s[countX+countNoX:]
        detach += 1
        
    return detach