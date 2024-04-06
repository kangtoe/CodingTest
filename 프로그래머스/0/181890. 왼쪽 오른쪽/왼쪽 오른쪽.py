def solution(str_list):
    
    lFirst = False
    idx = -1
    for i, s in enumerate(str_list):
        if s == 'l':
            lFirst = True
            idx = i
            break
        if s == 'r':
            lFirst = False
            idx = i
            break
            
    if idx == -1: return []
    return str_list[:idx] if lFirst else str_list[idx+1:]