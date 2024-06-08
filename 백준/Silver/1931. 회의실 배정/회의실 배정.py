n = int(input())
arr = []
for i in range(n):
    li = list(map(int, input().split()))
    arr.append(li)

arr.sort(key = lambda x:(x[1], x[0])) # 1.회의 종료 시간 순, 2.회의 시작 시간 순 정렬 # 중요!

cnt = 0
currEnd = 0
for li in arr:
    if currEnd > li[0]: continue # 이전 회의 종료 시간 > 예정 회의 시작 시간 => 회의 불가
    else:
        cnt += 1
        currEnd = li[1]

print(cnt)
    