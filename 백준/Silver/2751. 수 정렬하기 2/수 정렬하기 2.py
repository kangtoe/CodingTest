import sys
input = sys.stdin.readline

n = int(input())
arr = []
for i in range(n):
    k = int(input())
    arr.append(k)
    
arr.sort()
for a in arr:
    print(a)