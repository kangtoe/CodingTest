from itertools import permutations

def get_prime(n):
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
                
    return prime

def solution(numbers):
    answer = 0
    arr = [] # 순열 리스트
    
    # 1~n자리의 수의 모든 순열 구하기
    num_list = []
    for i in numbers: # 순열을 구하기 위한 리스트
        num_list.append(int(i))     
    for i in range(1, len(num_list)+1):
        tmpArr = list(permutations(num_list, i))   
        for tmpItem in tmpArr:
            s = []
            for t in tmpItem:
                s.append(str(t))            
            arr.append(int(''.join(s)))

        
    # 중복 제거 - 11과 011은 같은 숫자 등
    arr = list(set(arr))

    # 조합된 수 리스트 순회하며 소수 판별
    prime = get_prime(max(arr))
    for a in arr:
        if prime[a]:
            answer += 1

    #print(arr)
    return answer