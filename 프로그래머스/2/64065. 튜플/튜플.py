def solution(s):
    
    # str -> list 변환
    arr = []
    for c in s[2:-2].split("},{"):
        tmp = []
        for n in c.split(","):
            tmp.append(int(n))            
        arr.append(tmp)
    
    # 정렬하여 정답 구하기
    arr2 = []
    arr.sort(key = lambda x:len(x))
    for tmp in arr:
        for c in tmp:
            if not c in arr2:
                arr2.append(c)
        
    return arr2