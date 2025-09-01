using System;

public class Solution {
    public int[,] solution(int n) {
        int[,] answer = new int[n,n];
        
        int count = 1;
        int x = 0; int y = 0;
        
        // 우 하 좌 상
        int dr = 0;
        int[] dx = {1,0,-1,0};
        int[] dy = {0,1,0,-1};        
        
        for(int i = 0; i < n * n; i++)
        {            
            //Console.WriteLine("count"+count);
            //Console.WriteLine(x + " " + y);        
            
            answer[y,x] = count;
            count++;
            
            int nx = x + dx[dr];
            int ny = y + dy[dr];                      
            
            if(nx < 0 || ny < 0 || nx >= n || ny >= n || answer[ny,nx] != 0)
            {                
                dr++;
                dr%=4;
                nx = x + dx[dr];
                ny = y + dy[dr];    
            }
            
            x = nx;
            y = ny;
        }                
        
        return answer;
    }
}