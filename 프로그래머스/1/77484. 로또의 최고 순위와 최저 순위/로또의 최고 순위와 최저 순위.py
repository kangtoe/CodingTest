def getRank(match):
    rank = 7 - match
    if rank > 6: rank = 6
    return rank

def solution(lottos, win_nums):
    match = 0
    for l in lottos:
        if l in win_nums: match += 1
    
    zero = lottos.count(0)    
    minMatch, maxMatch = match, match + zero
        
    return [getRank(maxMatch), getRank(minMatch)]