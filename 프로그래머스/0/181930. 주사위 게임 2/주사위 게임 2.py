def square3(arr, n):
    return arr[0]**n + arr[1]**n + arr[2]**n

def solution(a, b, c):
    answer = 0
    
    arr = [a, b, c]
    arr_set = set(arr)
    
    if len(arr_set) == 3:
        return square3(arr, 1)
    if len(arr_set) == 2:
        return square3(arr, 1) * square3(arr, 2)
    if len(arr_set) == 1:
        return square3(arr, 1) * square3(arr, 2) * square3(arr, 3)
    
    
    
    return answer