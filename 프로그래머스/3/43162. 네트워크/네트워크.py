def solution(n, computers):
    count = 0

    def dfs(x, y, computers):

        # 영역 내 검사
        if x < -1 or x >= n or y < -1 or y >= n:
            return False

        # 묶음 처리 가능?        
        if computers[x][y] == 1:
            computers[x][y] = 0 # 묶음 처리            

            # y번째 줄의 모든 요소에 대해 재귀
            for i in range(n):
                dfs(i, x, computers)        
            return True

        else:
            return False        

    for i in range(n):
        for j in range(n):
            if dfs(i, j, computers):
                count += 1

    return count