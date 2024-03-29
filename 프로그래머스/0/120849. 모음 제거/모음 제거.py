def solution(my_string):
    arr = "aeiou"
    for a in arr:
        my_string = my_string.replace(a, '')
    
    return my_string