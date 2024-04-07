def solution(s):        
    arr = []
    wordIdx = 0
    for i, c in enumerate(s):
        if c == ' ':
            arr.append(' ')
            wordIdx = 0
        else:            
            if wordIdx % 2 == 0:
                arr.append(c.upper())
            else:
                arr.append(c.lower())
            wordIdx += 1
        
    return ''.join(arr)