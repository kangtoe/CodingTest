import heapq

def solution(scoville, K):
    heapq.heapify(scoville)
    count = 0
    
    while True:        
        if scoville[0] >= K: break
        if len(scoville) < 2: return -1
        
        a = heapq.heappop(scoville)
        b = heapq.heappop(scoville)
        mix = a + b * 2
        heapq.heappush(scoville, mix)
        count += 1
    
    return count