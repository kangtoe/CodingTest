def solution(my_string):
    answer = list(0 for i in range(52))    

    for s in my_string:
        if s <= 'Z': 
            answer[ord(s) - 65] += 1
        else: 
            answer[ord(s) - 65 - 32 + 26] += 1
    
    return answer