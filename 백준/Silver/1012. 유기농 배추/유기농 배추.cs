using System;

public class Sol
{
    static int[] dx = new int[]{0,0,-1,1};
    static int[] dy = new int[]{1,-1,0,0};
    
    static void Dfs(int x, int y, int[,] grid, int m, int n)
    {
        grid[y,x] = 0;
        
        for(int i =0; i< 4;i++)
        {
            int nx = x + dx[i];
            int ny = y + dy[i];
            
            if(nx < 0 || ny < 0 || nx >= m || ny >= n) continue;
            if(grid[ny,nx] != 1) continue;
            
            Dfs(nx, ny, grid,m,n);
        }
    }
    
    static public void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        for(int tmp = 0; tmp < t; tmp++)
        {
            int count = 0;
            string[] arr = Console.ReadLine().Split();
            
            int n,m,k;
            m = int.Parse(arr[0]);
            n = int.Parse(arr[1]);
            k = int.Parse(arr[2]);
            
            int[,] grid = new int[n,m];
            
            for(int i = 0; i < k; i++)
            {
                string[] strs = Console.ReadLine().Split();
                grid[int.Parse(strs[1]),int.Parse(strs[0])] = 1; // 1은 배추
            }
            
            for(int i =0; i<n;i++)
            {
                for(int j =0;j<m;j++)
                {
                    if(grid[i,j]!=1)continue;
                    Dfs(j,i,grid,m,n);
                    count++;
                }
            }
        
            Console.WriteLine(count.ToString());
        }
    }
}