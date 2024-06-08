n, k = map(int, input().split()) 
arr = []

for i in range(n):
    i = int(input())    
    arr.append(i)

arr.sort(reverse=True)
#print('--- ---')

ans = 0
for i in arr:
    if k >= i:
        div = k // i
        ans += div
        k -= div * i
        #print(i, div, k)

#print('--- ---')
print(ans)