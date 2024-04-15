def solution(n):
    answer = 0
    arr = list(range(n+1))  
    
    arr[0] = 0
    arr[1] = 1
    arr[2] = 1
        
    if n < 3: return arr[n]
        
    for i in range(3, n+1):
        arr[i] = arr[i-1] + arr[i-2]
                
    return arr[n] % 1234567