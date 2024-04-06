def solution(my_string):
    # eval(my_string)
    
    arr = my_string.split()
    calc = int(arr[0])
    stack = []
    
    for s in arr:                
        if s == " ":
            continue
            
        elif s == "-" or s == "+":
            stack.append(s)            
        
        elif stack != []:
            c = stack.pop()
            if c == "+":
                calc += int(s)            
            if c == "-":
                calc -= int(s)            
            
        #print('s', s)
        #print('calc', calc)
    return calc