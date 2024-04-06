def solution(numLog):
    answer = ''    
    for i in range(len(numLog) - 1):
        cal = numLog[i+1] - numLog[i]
        if cal == 1: answer+="w"
        if cal == -1: answer+="s"
        if cal == 10: answer+="d"
        if cal == -10: answer+="a"    
    return answer