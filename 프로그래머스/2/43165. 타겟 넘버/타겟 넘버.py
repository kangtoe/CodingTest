def func(numbers, target, idx, value):
    if idx == len(numbers):
        if value == target: 
            answer += 1
        return
    
    func(numbers, target, idx + 1, value + numbers[idx])
    func(numbers, target, idx + 1, value - numbers[idx])
    

def solution(numbers, target):
    global answer 
    answer = 0
    
    func(numbers, target, 0, 0)
    
    return answer