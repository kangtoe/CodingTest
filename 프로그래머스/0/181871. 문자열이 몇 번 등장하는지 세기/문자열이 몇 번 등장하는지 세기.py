def solution(myString, pat):
    
    if len(pat) > len(myString): return 0
    
    cnt = 0
    for i in range(len(myString) - len(pat) + 1):
        if myString[i:i + len(pat)] == pat: cnt += 1
        
    return cnt