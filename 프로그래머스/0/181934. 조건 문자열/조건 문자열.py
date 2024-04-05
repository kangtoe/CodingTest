def solution(ineq, eq, n, m):
    
    str = ''
    str += "n"
    str += ineq
    if eq == '=':
        str += eq    
    str += "m"
    
    return int(eval(str))