import sys
input = sys.stdin.readline
from collections import deque

k = int(input())
que = deque()
ans = []
for i in range(k):
    arr = input().split()

    if arr[0]=='push':        
        que.append(int(arr[1]))
        continue
    if arr[0]=='pop':
        if que: n = que.popleft()
        else: n = -1
    if arr[0]=='size':
        n = len(que)
    if arr[0]=='empty':
        n = 0 if que else 1
    if arr[0]=='front':
        if que: n = que[0]
        else: n = -1
    if arr[0]=='back':
        if que: n = que[-1]
        else: n = -1
        
    ans.append(n)

for a in ans:
    print(a)