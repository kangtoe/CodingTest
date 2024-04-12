def solution(array, n):
    close = 1e9
    ran = 1e9
    for i in array:
        if abs(i - n) <= ran:
            if abs(i - n) == ran and i > close:
                continue
                
            close = i
            ran = abs(i - n)
            print(close, ran)
                
    return close