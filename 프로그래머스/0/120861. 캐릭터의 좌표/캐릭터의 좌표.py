import math

def solution(keyinput, board):
    answer = [0,0]    

    xHalf = math.floor(board[0] / 2)
    yHalf = math.floor(board[1] / 2)    
    #print(xHalf, yHalf)    
    
    for k in keyinput:
        
        if k == "right":
            answer[0] += 1    
        elif k == "left":
            answer[0] -= 1                        
        elif k == "up":
            answer[1] += 1            
        elif k == "down":
            answer[1] -= 1                    
        
        if xHalf < answer[0]:
            answer[0] = xHalf
        elif answer[0] < -xHalf:
            answer[0] = -xHalf
              
        if yHalf < answer[1]:
            answer[1] = yHalf            
        elif answer[1] < -yHalf:
            answer[1] = -yHalf
            
    return answer
        