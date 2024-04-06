def solution(arr, k):    
    tmp = []
    for a in arr:
        if not a in tmp:
            tmp.append(a)
    
    if len(tmp) < k:
        for i in range(k - len(tmp)):
            tmp.append(-1)
        return tmp
        
    return tmp[:k]