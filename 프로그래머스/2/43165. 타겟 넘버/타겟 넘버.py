# 현재 인덱스와 이전 단계까지의 계산값 인자 추가
def func(numbers, target, idx, value): 
    global cnt
    
    # 끝까지 연산 후 목표값과 동일
    if idx == len(numbers):
        if value == target: 
            cnt += 1
        return
    
    # +/- 경우에 따른 재귀적 호출
    func(numbers, target, idx + 1, value + numbers[idx])
    func(numbers, target, idx + 1, value - numbers[idx])
    

def solution(numbers, target):    
    global cnt
    cnt = 0
    func(numbers, target, 0, 0)
    
    return cnt