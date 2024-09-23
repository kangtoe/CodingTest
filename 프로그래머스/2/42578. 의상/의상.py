def solution(clothes):
    
    # 의상 종류별 수 세기
    dick = {}
    for el in clothes:
        cloth = el[1]
        if cloth in dick:
            dick[cloth] += 1
        else:
            dick[cloth] = 1
            
    # (각 종류별 수 + 1의 곱) - 1
    # -1 이유: 아무것도 입지 않는 경우 제외
    sum = 1
    for k, v in dick.items():
        sum *= (v + 1)
        print(v)
    sum -= 1
    
    return sum