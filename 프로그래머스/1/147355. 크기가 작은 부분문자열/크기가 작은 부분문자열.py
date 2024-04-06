def solution(t, p):
    answer = 0
    
    for i in range(len(t)-len(p)+1):
        part = t[i:i+len(p)]
        if int(p) >= int(part): answer += 1
    
    return answer