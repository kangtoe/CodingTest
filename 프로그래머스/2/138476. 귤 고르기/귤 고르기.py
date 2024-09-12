# tangerine의 원소 ≤ 10,000,000 -> O(n) 시간 복잡도 이상은 어려울듯
def solution(k, tangerine):
    answer = 0    
    
    # 인덱스로 출현 빈도 개수 구하기
    arr = [0] * 10000001
    for num in tangerine:
        arr[num] += 1    
        
    # 출현 빈도 리스트 정렬
    arr.sort()
    
    # 위부터 k에서 빼서 0 이하 될때 return
    for i in range(len(arr)):
        if k <= 0: break
        k -= arr[-i-1]
        answer+=1        
        #print('arr[-i]', i, arr[-i-1])
    
    #print('max', max(arr))
    return answer