import math

def solution(triangle):
    
    d = [0] * 500
    
    # 현재 arr의 i번 요소에, 
    # 이전 arr max(i, i+1) 요소 더하기
    
    # arr의 첫번째 요소는 그냥 0번 더하고
    # 마지막 요소는 그냥 i-1번 더하기
    
    maxArr = []
    for arr in triangle:  
        newMaxArr = []
        
        if len(arr) == 1:
            newMaxArr.append(arr[0])
        else:                        
            for i in range(len(arr)):   
                if i == 0:
                    newMaxArr.append(arr[i] + maxArr[0])
                elif i == len(arr) - 1:
                    newMaxArr.append(arr[i] + maxArr[len(maxArr) - 1])
                else:
                    newMaxArr.append(arr[i] + max(maxArr[i-1],maxArr[i]))
            
        maxArr = newMaxArr
        #print(maxArr)
                                        
    return max(maxArr)