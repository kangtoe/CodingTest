def solution(my_strings, parts):
    answer = ''
    
    for i, c in enumerate(my_strings):
        answer += c[parts[i][0]: parts[i][1]+1]
    
    return answer