# 연속된 & 완료된 & 가장 뒤 인덱스
def check(progresses, start):
    idx = -1
    for k in range(start, len(progresses)):
        if progresses[k] == -1: idx = k
        else: return idx
    return idx

def solution(progresses, speeds): 
    rel = []
    front = -1
    for day in range(100):
        for idx in range(len(progresses)-1, -1, -1):    
            if not progresses[idx] == -1:            
                progresses[idx] += speeds[idx]
            
            # 작업 완료 처리
            if progresses[idx] >= 100:
                progresses[idx] = -1
                
                doneIdx = check(progresses, 0)
                done = doneIdx - front
                if done <= 0: continue
                rel.append(done)
                front = doneIdx                                  
        
    return rel