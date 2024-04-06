def solution(rank, attendance):
    answer = 0
    
    arr = []
    for i in range(len(rank)):
        if attendance[i]:
            arr.append(rank[i])
        
    arr.sort()
    a, b, c = arr[:3]
    return rank.index(a) * 10000 + rank.index(b) * 100 + rank.index(c)