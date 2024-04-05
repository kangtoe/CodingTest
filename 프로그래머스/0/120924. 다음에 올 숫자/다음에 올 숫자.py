def solution(common):
    answer = 0
    isAdd = common[2] - common[1] == common[1] - common[0]
    
    if(isAdd):        
        return common[-1] + common[1] - common[0]
    else:
        return common[-1] * common[1] / common[0]
    
    return answer