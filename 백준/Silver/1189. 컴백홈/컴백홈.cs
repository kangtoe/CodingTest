using System;
using System.Collections.Generic;

class HelloWorld {
    static int ans = 0;
    
    static void DFS(int y, int x, int[,] grid, int[,] visited, int r, int c, int k, int count)
    {
        int[]dy={0,0,1,-1};
        int[]dx={1,-1,0,0};
        
        if(y==0&&x==c-1)
        {
            if(count==k) ans++;
            return;
        }
        
        for(int i =0; i< 4; i++)
        {
            int ny = y +dy[i];
            int nx = x +dx[i];
            
            if(ny<0||nx<0||ny>=r||nx>=c) continue;
            if(grid[ny,nx]!=0) continue;
            if(visited[ny,nx]==1) continue;
            
            visited[ny,nx] = 1;
            DFS(ny,nx,grid,visited,r,c,k,count+1);
            visited[ny,nx] = 0;
        }
    }
    
    static void print(int[,]arr)
    {
        Console.WriteLine("---");
        for(int i =0; i< arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i,j] + " ");
            }
            Console.WriteLine("");
        }
    }
    
	static void Main() {
		int r,c,k;
		string[] rck = Console.ReadLine().Split();
		r = int.Parse(rck[0]);
		c = int.Parse(rck[1]);
		k = int.Parse(rck[2]);
		
		int [,] grid = new int[r,c];
		int [,] visited = new int[r,c];
		for(int i =0; i< r; i++)
		{
		    string line = Console.ReadLine();
		    for(int j =0; j <c; j++)
		    {
		        if(line[j] == '.') grid[i,j] = 0;
		        else grid[i,j] = 1;
		    }
		}
		
		int y = r-1;
		int x = 0;
		visited[y,x] = 1;
		DFS(y,x,grid,visited,r,c,k,1);
		
		Console.WriteLine(ans);
	}
}
