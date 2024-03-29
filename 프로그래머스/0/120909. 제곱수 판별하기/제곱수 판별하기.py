def solution(n):
    answer = 0
    
    root = n ** (1/2)
    if root == int(root):
        return 1
    else:
        return 2    