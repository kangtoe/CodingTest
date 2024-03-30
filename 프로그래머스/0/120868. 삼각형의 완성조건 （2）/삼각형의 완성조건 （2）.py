def solution(sides):
    answer = 0
    
    a = max(sides) - abs(sides[0] - sides[1])
    b = sides[0] + sides[1] - max(sides) - 1

    print (a, b)
    return a +b