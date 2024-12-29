def solution(s):
    count = 0
    l = len(s)
    for i in range(len(s)):
        stack = []
        tmp = s[i:l] + s[0:i] # i번 회전한 문자열
        for t in tmp:            
            if stack == []:
                stack.append(t)
            elif stack[-1] == "(" and t == ")":
                stack.pop()
            elif stack[-1] == "{" and t == "}":
                stack.pop()
            elif stack[-1] == "[" and t == "]":
                stack.pop()
            else:
                stack.append(t)
        if stack == []:
            count += 1
        
    return count