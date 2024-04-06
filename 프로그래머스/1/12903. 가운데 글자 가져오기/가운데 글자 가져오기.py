def solution(s):    
    mid = len(s)//2
    return s[mid] if len(s) % 2 == 1 else s[mid-1:mid+1]     