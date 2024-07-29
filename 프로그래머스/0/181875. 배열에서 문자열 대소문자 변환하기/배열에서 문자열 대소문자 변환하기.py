def solution(strArr):
    answer = []        
        
    arr = []            
    for i in range(len(strArr)):
        s = strArr[i]
        
        if(i % 2 ==1):
            a = s.upper()
        else: 
            a = s.lower()

        arr.append(a)
    
    return arr