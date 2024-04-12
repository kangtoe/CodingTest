def solution(my_string):
    answer = ''
    du = []
    for s in my_string:
        if not s in du:
            answer += s
            du.append(s)            
    
    return answer