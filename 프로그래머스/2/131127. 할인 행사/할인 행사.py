def solution(want, number, discount):
    count = 0
        
    arr = []
    for i in range(len(want)):
        for j in range(number[i]):
            arr.append(want[i])
    arr.sort()
    
    for i in range(len(discount) - 9):
        tmp = discount[i: i+10]
        tmp.sort()
        if arr == tmp:
            count += 1
    
    return count