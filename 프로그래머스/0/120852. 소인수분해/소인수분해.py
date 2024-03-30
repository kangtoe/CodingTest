def solution(n):
    answer = []
    
    for i in range(2, n + 1):
        
        # i 소수 검사
        b = True
        for j in range(2, i):
            if i % j == 0:
                b = False
                break
        
        # 약수 검사
        if b and n % i == 0:
            answer.append(i);
    
    
    return answer