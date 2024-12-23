def solution(n, m, section):
    count = 0    
    curr = 0
    
    for i in range(len(section)):
        if(curr <= section[i]):
            curr = section[i] + m
            count += 1        
    
    return count