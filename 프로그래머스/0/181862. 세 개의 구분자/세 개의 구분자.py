def solution(myStr):
        
    arr = []
    c = ''
    
    for s in myStr:
        if s in ['a', 'b', 'c']:
            if c != '':
                arr.append(c)
                c = ''
        else:
            c += s
    arr.append(c)                    
    
    return arr if arr != [""] else ["EMPTY"]