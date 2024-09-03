# 대진 라운드인가 검사
# a b 비교 
# 주의 -> abs(a - b) = 1 인가? -> 반례 a = 2, b = 3  
# 추가 -> 둘 중 큰 수가 짝수인가 검사
def IsOnRound(a,b):
    return (a - b == 1 or a - b == -1) and max(a,b) % 2 == 0

def solution(n,a,b):                   
    round = 1    
    
    while not IsOnRound(a,b):
        # 다음 라운드의 번호 알아오기
        # 1. num = 홀수인 경우 + 1
        # 2. num / 2
        # 3. round + 1
        if(a%2==1): a+= 1
        a //= 2
        
        if(b%2==1): b+= 1
        b //= 2
                
        round += 1
        print(a, b, round)

    return round