N,M = map(int, input().split())

arr = list(str(i) for i in range(1, N+1))
#print(arr)

for i in range(M):
    i, j = map(int, input().split())
    i -= 1
    j -= 1

    arr = arr[:i] + arr[i:j+1][::-1] + arr[j+1:]
    #print(i, j, arr)


print(' '.join(arr))