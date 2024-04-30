import sys
from collections import deque
input = sys.stdin.readline

n = int(input())
arr = map(int, input().split())
q = deque(enumerate(arr))
ans = []

while q:
    idx, paper = q.popleft()
    ans.append(idx +1)

    if paper > 0:
        q.rotate(-(paper - 1))
    elif paper < 0:
        q.rotate(-paper)

print(' '.join(map(str, ans)))