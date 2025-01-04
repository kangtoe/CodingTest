def solution(dirs):
    count = 0
    x, y = 0, 0
    walk = []
    for i, d in enumerate(dirs):
        nx, ny = x, y
        start = [x, y]
        if d == "U": ny += 1
        if d == "D": ny -= 1
        if d == "R": nx += 1
        if d == "L": nx -= 1
        end = [nx, ny]
        
        if nx < -5 or nx > 5 or ny < -5 or ny > 5:             
            continue
        x,y = nx, ny
        
        f = [start, end]
        b = [end, start]
        if (f not in walk) and (b not in walk):
            walk.append(f)
            count += 1
        
        #print(i, walk)
    
    return count