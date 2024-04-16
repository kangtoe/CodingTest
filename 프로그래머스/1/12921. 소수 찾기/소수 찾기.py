def solution(n):
    
    # 선언 및 초기화
    MAX = n
    prime = [True for i in range(MAX+1)]
    prime[0] = False
    prime[1] = False

    # 2부터 제곱근까지 순회
    # 현재 수가 소수인 경우, 자신을 제외한 자신의 배수들을 지운다
    for i in range(2, int(MAX**0.5)+1):
        if prime[i] == True:
            j = 2
            while i*j <= MAX:
                prime[i*j] = False
                j += 1

    # 테스트
    number = n
    #print(prime)
        
    return prime.count(True)