using System;
using System.Collections.Generic;
class HelloWorld {
    static int r, c, k;
    static int count = 0;
    
    static void Go(int x, int y, int[,] visited, char[,] grid)
    {
        if(y==0&&x==c-1)
        {
            //Console.WriteLine("len:" + visited[y,x]);
            if(visited[y,x]==k) count++;
        }
            
        
        int[] dy = new int[]{0,0,-1,1};
        int[] dx = new int[]{1,-1,0,0};
        
        for(int i =0; i< 4; i++)
        {
            int nx = x + dx[i];
            int ny = y + dy[i];
            
            if(nx<0||ny<0||nx>=visited.GetLength(1)||ny>=visited.GetLength(0)) continue;
            if(visited[ny,nx]!=0) continue;
            if(grid[ny,nx]=='T') continue;
            
            visited[ny,nx] = visited[y,x] + 1;
            Go(nx,ny, visited, grid);
            visited[ny,nx] = 0;
        }
    }
    
	static void Main() {
		string[] rck = Console.ReadLine().Split();
		
		r = int.Parse(rck[0]);
		c = int.Parse(rck[1]);
		k = int.Parse(rck[2]);
		
		char[,] grid = new char[r,c];
		int[,] visited = new int[r,c];
		
		for(int i =0; i< r; i++)
		{
		    string str = Console.ReadLine();
		    for(int j =0; j< c; j++)
		    {
		        grid[i,j] = str[j];
		    }
		}
		
		visited[r-1,0] = 1;
		Go(0,r-1,visited,grid);
		Console.WriteLine(count);
	}
}