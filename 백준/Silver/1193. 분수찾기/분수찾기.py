target = int(input())
curr = 1

# 몇 번째 대각선(k)에 있는지 구하기
# 이전 대각선까지 누적한 요소 개수(sum)
sum = 0 
k = 1
while(sum < target):         
    sum += k
    k += 1

# 대각선 내 몇번째(left)에 있는지 구하기
k -= 1
sum -= k
left = target - sum
#print('k, left:', k, left)

# 짝수번째 대각선은 역순으로 세기
# n / m
if k % 2 == 1:        
    n = k - left + 1
    m = k - n + 1
else:    
    m = k - left + 1
    n = k - m + 1

print(str(n) + '/' + str(m))