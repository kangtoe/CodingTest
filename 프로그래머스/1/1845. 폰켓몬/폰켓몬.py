def solution(nums):
    nums_l = len(nums) / 2
    
    arr = list(set(nums))
    arr_l = len(arr)    
    
    answer = 0
    return arr_l if arr_l < nums_l else nums_l