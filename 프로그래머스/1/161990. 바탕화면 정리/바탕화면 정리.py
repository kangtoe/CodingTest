def solution(wallpaper):    
    min, max = [50,50], [0,0]
    
    for y in range(len(wallpaper)):
        for x in range(len(wallpaper[y])):
            if(wallpaper[y][x] == "#"):
                print("---", x, y)
                if x < min[0]: min[0] = x 
                if y < min[1]: min[1] = y
                if x +1 > max[0]: max[0] = x+1
                if y +1 > max[1]: max[1] = y+1           

                print(min, max)
    
    answer = max + min
    answer.reverse()
    return answer