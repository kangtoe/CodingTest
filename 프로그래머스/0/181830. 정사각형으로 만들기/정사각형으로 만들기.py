def solution(arr):
    answer = [[]]
    
    col = len(arr[0])
    row = len(arr)    
    i = col - row
    
    if i > 0:
        z = []
        for j in range(col):
            z.append(0)
        
        for j in range(i):
            arr.append(z)
        
    elif i < 0:
        for a in arr:
            for j in range(-i):
                a.append(0)   
    return arr