def solution(sides):
    
    m = max(sides)  
    sides.remove(m)
            
    return 1 if sides[0] + sides[1] > m else 2