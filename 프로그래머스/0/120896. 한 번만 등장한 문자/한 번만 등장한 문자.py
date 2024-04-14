def solution(s):
    answer = ''
    
    arr = list( set(s))
    for a in arr:
        if s.count(a) == 1:
            answer += a
    
    return ''.join(sorted(answer))