from collections import deque

def bfs(maps, startX, startY):

    # 왼쪽, 오른쪽, 아래, 위 -> y가 클수록 아래 줄임에 유의
    dx = [-1,1,0,0]
    dy = [0,0,1,-1]
    
    n = len(maps)
    m = len(maps[0])

    dq = deque()
    dq.append((startX, startY))    

    while dq:
        x, y = dq.popleft()

        for i in range(4): # 4 방향 검사
            nx = x + dx[i]
            ny = y + dy[i]

            if nx == startX and ny == startY: # 시작 위치인가?
                continue 

            if nx < 0 or nx >= n or ny < 0 or ny >= m: # 영역 내 검사
                continue

            if maps[nx][ny] == 0: # 벽 검사
                continue

            if maps[nx][ny] == 1:
                maps[nx][ny] = maps[x][y] + 1
                dq.append((nx, ny))

    goal = maps[- 1][- 1]    
    return goal if goal != 1 else -1    


def solution(maps):    
    return bfs(maps, 0,0)