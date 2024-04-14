def solution(myString):    
    arr = []
    for i in sorted(myString.split('x')):
        if i != "": arr.append(i)
    
    return arr