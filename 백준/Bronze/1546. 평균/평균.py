import sys
input = sys.stdin.readline

n = input()
arr = list(map(int, input().split()))
M = max(arr)

for i, a in enumerate(arr):
    arr[i] = a / M

print(sum(arr) / len(arr) * 100)  