def solution(number):
    sum = 0
    for s in number:
        sum += int(s)       
    return sum % 9