def solution(numbers, direction):
    answer = []
    
    if direction == "right":    
        answer = numbers[-1:] + numbers[0: -1]
    elif direction == "left":    
        answer = numbers[1: len(numbers)] + numbers[:1]
    
    return answer