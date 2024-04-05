def solution(l, r):
        
    arr = []
    # 2진법 변환 후
    # 문자 '1' -> 문자 '5' 변환 후 배열에 더하기
    for i in range(1, int('0b111111', 2) + 1):
        s = int(str(format(i, 'b')).replace('1', '5'))        
        arr.append(s)
    
    answer = []
    for num in arr:
        if r < num:                        
            break
        
        if l <= num:
            answer.append(num)
    
    return [-1] if answer == [] else answer