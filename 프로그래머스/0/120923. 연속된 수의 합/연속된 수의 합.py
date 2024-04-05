def solution(num, total):    
    arr = []
    avg = total / num
    
    for idx in range(num):
        i = avg + idx - (num+1) / 2 + 1 # 중앙값과 인덱스 차이만큼 평균에서 가감
        arr.append(i)                
        
    return arr