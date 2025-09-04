using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {                                        
        int n = maps.GetLength(0);
        int m = maps.GetLength(1);
        int[,] visited = new int[n,m];
        
        Queue<int> xq = new Queue<int>();
        Queue<int> yq = new Queue<int>();
        
        int[] dx = new int[]{0,0,-1,1};
        int[] dy = new int[]{1,-1,0,0};        
        
        xq.Enqueue(0);
        yq.Enqueue(0);
        visited[0,0] = 1;
        while(xq.Count > 0)
        {            
            int x = xq.Dequeue();
            int y = yq.Dequeue();                            
            
            for(int i = 0; i < 4; i++)
            {                                                
                int nx = x + dx[i];
                int ny = y + dy[i];
                
                if(nx < 0 || ny < 0 || nx >= m || ny >= n) continue;
                if(maps[ny, nx] == 0) continue;
                if(visited[ny, nx]!=0) continue;
                
                xq.Enqueue(nx);
                yq.Enqueue(ny);
                visited[ny, nx] = visited[y, x] + 1;                                
            }                        
        }
                
        return visited[n-1,m-1] != 0 ? visited[n-1,m-1] : -1;
    }
}