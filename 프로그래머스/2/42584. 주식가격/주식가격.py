def solution(prices):
    arr = []
    for i in range(len(prices) - 1):
        for j in range(i + 1, len(prices)):
            inter = prices[j] - prices[i]            
            if inter < 0: # i ~ j 가격 떨어지는 지점
                #print('u', i, j, inter)
                arr.append(j-i)
                break
            if j == len(prices) - 1: # 마지막까지 가격 유지
                #print('h', i, j, inter)
                arr.append(len(prices) -1 -i)
    arr.append(0)
                                                
    return arr