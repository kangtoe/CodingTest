def solution(num_list):
    answer = 0
    if len(num_list) >= 11:
        return sum(num_list)
    else:        
        mult = 1
        for i in num_list:
            mult *= i
        return mult
            
    return  -1 