def solution(citations):
    H_Index = 0
    
    inyongs = [0] * 10001
    for cit in citations:
        for i in range(cit+1):
            inyongs[i] += 1

    for i in range(len(inyongs)-1, -1, -1):
        if inyongs[i] >= i:
            H_Index = i
            break
    
    return H_Index