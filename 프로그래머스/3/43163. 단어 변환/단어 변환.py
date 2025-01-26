def canChange(a, b):
    count = 0
    for i in range(len(a)):
        if not a[i] == b[i]: count += 1
        if count > 1: return False
    return True  

def solution(begin, target, words):
    
    def changeCheck(begin, target, words, count): 
        #print(begin, count)
        
        # 변환 목표 도달
        if begin == target:
            return count
        
        minCnt = 1e9
        for w in words:
            if canChange(begin, w):
                tmp = words.copy()
                tmp.remove(w)
                res = changeCheck(w, target, tmp, count + 1)
                if not res == None:
                    minCnt = min(minCnt, res)
                    #print(minCnt)
                            
        return minCnt
    
    cnt = changeCheck(begin, target, words, 0)
    if cnt == 1e9: return 0
    return cnt