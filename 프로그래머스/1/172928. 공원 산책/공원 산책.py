def solution(park, routes):    
    h = len(park)
    w = len(park[0])
    
    x, y = 0, 0
    for i in range(h):
        for j in range(w):
            if(park[i][j] == "S"):
                x, y = j, i
                break
    
    dirs = ["N", "S", "W", "E"]
    dx = [0, 0, -1, 1]
    dy = [-1, 1, 0, 0]
    
    for route in routes:
        
        route = list(route.split())
        cDir = route[0]
        move = int(route[1])
        nx, ny = x, y 
        
        while(True):
            idx = dirs.index(cDir)
            nx += dx[idx]
            ny += dy[idx]
            move -= 1            
            print(nx, ny)
            
            if(nx < 0 or ny < 0 or nx >= w or ny >= h):
                break
            if(park[ny][nx] == "X"):
                break
                
            if(move == 0):
                x, y = nx, ny             
                break
    
    return [y,x]