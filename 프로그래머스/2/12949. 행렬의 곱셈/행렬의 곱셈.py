
def solution(arr1, arr2):
    arr = []

    # arr1 => a * b
    # arr2 => b * c
    a, b, c = len(arr1), len(arr2), len(arr2[0])
    for i in range(a):
        tmp = [0] * c
        arr.append(tmp)

    for y in range(len(arr)):
        for x in range(len(arr[0])):            
            s = 0
            for i in range(b):
                s += arr1[y][i] * arr2[i][x]
            arr[y][x] = s            
        
    return arr