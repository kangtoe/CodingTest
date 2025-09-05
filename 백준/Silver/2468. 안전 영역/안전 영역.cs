using System;

public class Sol
{
    static int[] dx = new int[]{0,0,-1,1};
    static int[] dy = new int[]{1,-1,0,0};
    
    static void Dfs(int y, int x, int[,] grid, int [,]visited, int n, int t)
    {
        visited[y,x] = 1;
        
        for(int i=0;i<4;i++)
        {
            int nx = x + dx[i];
            int ny = y + dy[i];
            
            if(nx<0||ny<0||nx>=n||ny>=n) continue;
            if(grid[ny,nx] <= t) continue;
            if(visited[ny,nx]==1)continue;
            
            Dfs(ny,nx,grid,visited,n,t);
        }
    }
    
    static public void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] grid = new int[n,n];
        
        for(int i = 0; i < n;i++)
        {
            string[] str = Console.ReadLine().Split();
            
            for(int j =0;j<n;j++)
            {
                grid[i,j] = int.Parse(str[j]);
            }
        }
        
        int maxCount = 0;
        for(int t = 0; t<= 100; t++)
        {
            int[,] visited = new int[n,n];
            int count = 0;
            
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(visited[i,j] == 1) continue;
                    if(grid[i,j] <= t) continue;
                    Dfs(i,j,grid,visited,n,t);
                    count ++;
                }
            }
            
            if(count > maxCount) maxCount = count;
        }
        
        Console.WriteLine(maxCount);
    }
}