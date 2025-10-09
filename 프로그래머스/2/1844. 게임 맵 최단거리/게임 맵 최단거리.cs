using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {                
        
        int row = maps.GetLength(0);
        int col = maps.GetLength(1);
                
        int[,] visited = new int[row,col];
        
        Queue<int> xq = new Queue<int>();
        Queue<int> yq = new Queue<int>();
        
        xq.Enqueue(0);
        yq.Enqueue(0);
        visited[0,0] = 1;
        
        while(xq.Count > 0)
        {
            int x = xq.Dequeue();
            int y = yq.Dequeue();
            
            int[] dx = {0,0,-1,1};
            int[] dy = {1,-1,0,0};
            
            for(int i = 0; i < 4; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];
                
                if(nx < 0 || ny < 0 || nx >= col || ny >= row) continue;
                if(visited[ny,nx] != 0) continue;
                if(maps[ny,nx] != 1) continue;
                
                visited[ny,nx] = visited[y,x] + 1;
                xq.Enqueue(nx);
                yq.Enqueue(ny);
            }
        }        
               
        int res = visited[row-1,col-1];
        if(res == 0) return -1;
        else return res;
    }
}