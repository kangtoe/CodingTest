def solution(elements):

    li = set()
    elementsD = elements + elements         # 원형 구조 대신 리스트 2개 사용
    for startIdx in range(len(elements)):   # 부분 수열 시작 인덱스
        s = 0                               # 부분 수열 합
        for idxAdd in range(len(elements)): # 부분 수열 길이
            s += elementsD[startIdx + idxAdd]            
            li.add(s)
            
    li = list(li)
    return len(li)


    
            