def fun():
    n = int(input())

    # stop = -1 -> 2의 배수인 경우까지 처리
    for i in range(n//5, -1, -1): 
        tmp = n - (i * 5)
        if tmp % 2 == 0:
            j = tmp // 2
            return i + j

    return -1
    
print(fun())