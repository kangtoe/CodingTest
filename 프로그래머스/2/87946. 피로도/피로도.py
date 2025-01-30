def dfs(k, dungeons, count):
    maxCnt = count        
    
    for d in dungeons:
        if d[0] > k: continue
        tmp = dungeons.copy()
        tmp.remove(d)
        maxCnt = max(maxCnt, dfs(k - d[1], tmp, count + 1))
        
    return maxCnt

def solution(k, dungeons):            
    count = dfs(k, dungeons, 0)    
    
    return count