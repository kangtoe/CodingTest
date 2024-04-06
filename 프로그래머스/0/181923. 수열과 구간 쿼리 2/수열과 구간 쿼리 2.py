def solution(arr, queries):
    answer = []
    
    for q in queries:
        biggerK = []
        for a in arr[q[0]:q[1]+1]:
            if a > q[2]:
                biggerK.append(a)
        
        if biggerK == []:
            answer.append(-1)
        else:
            answer.append(min(biggerK))
    
    return answer