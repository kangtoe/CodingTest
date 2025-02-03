def solution(arr):
    stack = []
    
    for ele in arr:
        if stack == []:
            stack.append(ele)
            continue
            
        before = stack.pop()
        if before == ele:
            stack.append(ele)
        else:
            stack.append(before)
            stack.append(ele)
            
    return stack