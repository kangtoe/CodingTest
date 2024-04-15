def solution(my_string):
    tmp = ''    
    for i, s in enumerate(list(my_string)):
        if s.isdigit():            
            tmp += s
        else:
            tmp += ' '
    arr = tmp.split()
    
    return sum(int(i) for i in arr)