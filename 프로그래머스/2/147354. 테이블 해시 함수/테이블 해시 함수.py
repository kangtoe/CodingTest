def solution(data, col, row_begin, row_end):
    answer = 0
        
    data.sort(key=lambda x:(x[col-1], -x[0]))
    
    S_i = 0
    for i in range(len(data)):
        if not row_begin-1 <= i <= row_end-1: continue
        
        tmp = 0
        for j in range(len(data[i])):
            tmp += data[i][j] % (i +1)            
        
        S_i = tmp ^ S_i        
    
    return S_i