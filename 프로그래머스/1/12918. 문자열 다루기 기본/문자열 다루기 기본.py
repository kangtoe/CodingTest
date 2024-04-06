def solution(s):        
    for c in s:
        if not ('0'<=c<='9'): return False
                
    return len(s) == 4 or len(s) == 6