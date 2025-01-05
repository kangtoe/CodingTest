def solution(N, stages):
    
    # 각 스테이지 별 실패자 수
    arr = [0] * (N + 1)                    
    for s in stages: 
        if s < 1: s = 1
        arr[s-1] += 1
    #print(arr)
    
    # 각 스테이지 별 도전자 수
    trySum = 0
    arr1 = []
    for i in range(len(arr)-1, -1, -1):
        trySum += arr[i]
        arr1.append(trySum)
    arr1 = arr1[::-1]
    #print(arr1)
    
    # 스테이지 인덱스와 실패율 묶어서 정렬
    arr2 = []
    for i in range(len(arr) - 1):        
        if arr1[i] == 0:
            arr2.append([i, 0])
            continue
        arr2.append([i, arr[i] / arr1[i]])    
    arr2.sort(key = lambda x:-x[1])
    print(arr2)
    
    arr3 = []    
    for a in arr2:
        arr3.append(a[0] + 1)
    #print(arr3)

    return arr3