n = input()
arr = list(map(int, input().split()))
arr.sort()
#print(arr)

total = 0
s = 0
for a in arr:
    s += a
    total += s
    #print(total)

print(total)