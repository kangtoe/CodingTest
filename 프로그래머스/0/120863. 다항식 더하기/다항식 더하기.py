def solution(polynomial):
    arr =  polynomial.split()
    
    xCount = 0
    numCount = 0
    
    for s in arr:
        if s == 'x':
            xCount += 1
            continue
        
        if s[-1] == 'x':
            xCount += int(s.replace('x', ''))
            continue
        
        if s != '+':
            numCount += int(s) 
    
    answer = ''
    if xCount == 1:
        answer = 'x'
    if xCount > 1:
        answer = str(xCount) + 'x'
    if xCount > 0 and numCount > 0:
        answer += ' + ' 
    if numCount > 0:
        answer += str(numCount)
    
    return answer