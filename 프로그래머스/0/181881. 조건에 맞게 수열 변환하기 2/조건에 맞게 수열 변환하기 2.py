def solution(arr):
    count = 0
    before = arr[:]
    
    while True:   
        #print(count, arr)
        for i, a in enumerate(arr):
            if a >= 50 and a % 2 == 0:
                arr[i] = a // 2
            elif a < 50 and a % 2 == 1:
                arr[i] = a * 2 + 1                        
        count += 1
        
        if before == arr:
            return count - 1
        
        before = arr[:]
    return answer