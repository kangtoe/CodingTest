def solution(n):
    cnt = 1
    
    start = 1 # 더하기 시작 수  
    while start <= n/2:
                               
        check = start # 루프 내 현재 더하기 수        
        arr = []
        while sum(arr) < n:
            arr.append(check)
            check += 1            
            #print(start, check, sum(arr))            
    
        # 더하기 총합 == 목표 자연수
        if sum(arr) == n:
            cnt += 1      
            
        start += 1        
    
    return cnt