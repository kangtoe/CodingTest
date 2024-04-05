def solution(arr, query):
    answer = []
    
    for i in range(len(query)):
        idx = query[i]
        if i % 2 == 0:      
            arr = arr[0:query[i] + 1]
        else:         
            arr = arr[query[i]:]
        
        #print('idx', idx)
        #print(arr)
    
    return arr