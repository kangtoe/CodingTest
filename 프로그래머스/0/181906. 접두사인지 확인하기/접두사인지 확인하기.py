def solution(my_string, is_prefix):
    if len(is_prefix) > len(my_string): return 0
    for i, s in enumerate(is_prefix):
        if my_string[i] != is_prefix[i]:
            return 0
    return 1