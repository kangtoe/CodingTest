import sys
input = sys.stdin.readline

n = int(input())
for i in range(n):
    stack = []
    arr = list(input().strip())
    #print(arr)

    for s in arr:
        if stack == []: 
            stack.append(s)
            continue

        if s == ')':
            if stack[-1] == '(':
                stack.pop()
                continue

        stack.append(s)

    #print(stack)
    print('YES') if stack == [] else print('NO')