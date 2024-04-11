def solution(my_string, is_suffix):
    re = my_string[::-1]                
    return int(re[:len(is_suffix)] == is_suffix[::-1])