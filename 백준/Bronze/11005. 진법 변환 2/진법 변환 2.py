n, k = map( int, input().split())

# 10진법 수 => k진법 수(문자열)
tmp = ''
while n:
    i = n % k
    if i >= 10:
        i = chr(i - 10 + ord('A'))
    else:
        i = str(i)
    tmp = i + tmp 
    n = n // k
    #print(i)

print(tmp)