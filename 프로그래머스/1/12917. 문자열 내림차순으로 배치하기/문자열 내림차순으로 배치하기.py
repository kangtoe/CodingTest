def solution(s):
    arr = list(s)
    arr.sort(key = lambda x: ord(x) if x < 'A' else ord(x) + 100, reverse = True)
    return ''.join(arr)