def solution(picture, k):
    answer = []
    
    for line in picture:
        lineD = ''
        for s in line:
            for i in range(k):
                lineD+=s
            
        for i in range(k):
            answer.append(lineD)        
        
    return answer