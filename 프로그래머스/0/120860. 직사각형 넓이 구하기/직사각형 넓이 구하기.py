def solution(dots):
    dot1 = dots[0]
    for d in dots:
        if d[0] != dot1[0] and d[1] != dot1[1]:
            return abs(dot1[0] - d[0]) * abs(dot1[1] - d[1])