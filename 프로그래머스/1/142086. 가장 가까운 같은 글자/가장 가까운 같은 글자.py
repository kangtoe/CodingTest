def solution(s):
    answer = []
    for i, c in enumerate(s):
        idx = s[:i][::-1].find(c)
        if idx != -1 : idx += 1
        answer.append(idx)
        
    return answer