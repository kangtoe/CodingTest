def solution(arr1, arr2):
    answer = []
        
    for i in range(len(arr1)):
        sumArr = []
        for j in range(len(arr1[i])):
            sumArr.append( arr1[i][j] + arr2[i][j] )
        answer.append(sumArr)
    
    return answer