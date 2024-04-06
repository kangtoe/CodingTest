def solution(my_string):
    answer = list(0 for i in range(52))    
    alp = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"    
    for s in my_string:
        answer[alp.index(s)] += 1
        
        #if s <= 'Z': 
            #answer[ord(s) - 65] += 1
        #else: 
            #answer[ord(s) - 65 - 32 + 26] += 1                    
    
    return answer