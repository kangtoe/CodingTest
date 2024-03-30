def solution(my_string):
    answer = 0
    
    for c in my_string:
        if '0'<= c <='9':
            answer += int(c)
        
    return answer