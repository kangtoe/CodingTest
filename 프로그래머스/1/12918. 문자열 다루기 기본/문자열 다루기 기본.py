def solution(s):        
    for c in s:
        if not ('0'<=c<='9'): return False
                
    return len(s) in [4,6]