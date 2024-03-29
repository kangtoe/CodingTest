def solution(code):    
    mode = False
    ret = ""
    
    for i in range(len(code)):
        c = code[i]
            
        if not mode:
            if c != "1" and i % 2 == 0:
                ret += c
            if c == "1":
                mode = True
                
        elif mode:
            if c != "1" and i % 2 == 1:
                ret += c
            if c == "1":
                mode = False      
                
        #print(i, c, mode, ret)
    
    if ret == "":
        ret = "EMPTY"
    return ret