from collections import deque 

def solution(priorities, location):    
    
    # 인덱스와 짝지어 놓기
    arr = []
    for i in range(len(priorities)):
        arr.append([i, priorities[i]])    
    #print(arr)
    
    ex = [] # 실행 리스트
    q = deque(arr)        
    while(q):
        e = q.popleft()        
        if not e[1] == max(priorities):
            q.append(e)
        else:
            ex.append(e[0])
            priorities.remove(e[1])
    
    #print(ex)
    return ex.index(location) + 1