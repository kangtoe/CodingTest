def solution(participant, completion):
    
    # 시간복잡도 고려할 것    
    participant.sort()
    completion.sort()
    
    for i in range(len(completion)):        
        #print(participant[i], completion[i])
        if participant[i] != completion[i]:            
            return participant[i]            
        
    return participant[len(participant)-1]