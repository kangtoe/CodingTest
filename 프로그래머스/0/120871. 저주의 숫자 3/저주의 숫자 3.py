def solution(n):
    count = 0
    i = 0
    while True:        
        i += 1
        
        if i % 3 == 0 or '3' in str(i):
            continue
        else:
            count += 1
        
        if count == n: return i