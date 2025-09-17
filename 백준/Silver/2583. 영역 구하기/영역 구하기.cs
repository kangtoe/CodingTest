using System;
using System.Collections.Generic;
class HelloWorld {
    
    static int m,n,k;
    static int[,] grid,visited;
    
    static int DFS(int y, int x)
    {
        int count = 1;
        visited[y,x] = 1;
        
        int[] dy = {1,-1,0,0};
        int[] dx = {0,0,-1,1};
        
        for(int i = 0; i < 4; i++)
        {
            int ny = y + dy[i];
            int nx = x + dx[i];
            
            if(ny<0||nx<0||ny>=m||nx>=n) continue;
            if(visited[ny,nx]!=0) continue;
            if(grid[ny,nx]!=0) continue;
            
            count += DFS(ny,nx);
        }
        
        return count;
    }
    
	static void Main() {
		string[] mnk = Console.ReadLine().Split();
		m = int.Parse(mnk[0]);
		n = int.Parse(mnk[1]);
		k = int.Parse(mnk[2]);
		
		grid = new int[m,n];
		for(int i = 0; i < k; i++)
		{
		    string[] line = Console.ReadLine().Split();
		    int minX = int.Parse(line[0]);
		    int minY = int.Parse(line[1]);
		    int maxX = int.Parse(line[2]);
		    int maxY = int.Parse(line[3]);
		    
		    for(int row = minY; row < maxY; row++)
		    {
		        for(int col = minX; col < maxX; col++)
		        {
		            grid[row,col] = 1;
		        }
		    }
		}
		
		List<int> li = new List<int>();
		visited = new int[m,n];
		for(int i = 0; i <m; i++)
		{
		    for(int j = 0; j < n; j++)
		    {
		        if(visited[i,j]==0 && grid[i,j] ==0)
		        {
		            int count = DFS(i,j);
		            li.Add(count);
		        }
		    }
		}
		
		Console.WriteLine(li.Count);
		li.Sort();
		Console.WriteLine(string.Join(" ", li));
	}
}