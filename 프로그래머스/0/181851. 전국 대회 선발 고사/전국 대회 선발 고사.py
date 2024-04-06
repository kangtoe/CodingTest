def solution(rank, attendance):
    answer = 0
    
    arr = []
    for i in range(len(rank)):
        if attendance[i]:
            arr.append(rank[i])
        
    aScore = min(arr)
    arr.remove(aScore)
    bScore = min(arr)
    arr.remove(bScore)
    cScore = min(arr)
    arr.remove(cScore)
    
    #print(aScore, bScore, cScore)        
    return rank.index(aScore) * 10000 + rank.index(bScore) * 100 + rank.index(cScore)