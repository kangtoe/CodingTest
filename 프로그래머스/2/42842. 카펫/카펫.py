def solution(brown, yellow):
    answer = []
    
    # 가로 : n
    # 세로 : m
    # brown : 2 * (n + m - 2)
    # yellow : (n - 2) * (m - 2)
    
    # n = 4
    # m = 3
    # b = 2 * (n + m - 2)
    # y = (n - 2) * (m - 2)
    # return (b == brown and y == yellow)

    for n in range(brown):
        for m in range(brown):
            b = 2 * (n + m - 2)
            y = (n - 2) * (m - 2)
            if b == brown and y == yellow:
                return [max(n, m), min(n, m)]
    
    return answer