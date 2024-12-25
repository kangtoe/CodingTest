def solution(k, m, score):
    if len(score) < m : return 0
    
    score.sort()
    left = len(score) % m
    score = score[left:]    
             
    sum = 0
    for idx in range(len(score)):
        if idx % m == 0:
            sum += score[idx] * m
    
    return sum