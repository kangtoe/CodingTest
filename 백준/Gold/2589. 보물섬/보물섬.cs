using System;
using System.Collections.Generic;
class HelloWorld {
    static int n, m;
    static int[,] grid, visited;
	
	static void Main() {
		string[] nm = Console.ReadLine().Split();
		n = int.Parse(nm[0]);
		m = int.Parse(nm[1]);
		grid = new int [n,m];
		
		for(int i = 0; i < n; i++)
		{
		    string line = Console.ReadLine();
		    for(int j = 0; j < m; j++)
		    {
		        if(line[j]=='W') grid[i,j] = 1;
		        else grid[i,j] = 0;
		    }
		}
		
		int[] dx = {0,0,-1,1};
        int[] dy = {1,-1,0,0};
		
		int maxDist = 0;
		for(int i = 0; i < n; i++)
		{
		    for(int j = 0; j < m; j++)
		    {
		        if(grid[i,j]==0)
		        {
		            visited = new int[n,m];
		            
		            Queue<int> xq = new Queue<int>();
		            Queue<int> yq = new Queue<int>();
		            
		            yq.Enqueue(i);
		            xq.Enqueue(j);
		            visited[i,j] = 1;
		            
		            int last = 1;
		            while(xq.Count > 0)
		            {
		                int x = xq.Dequeue();
		                int y = yq.Dequeue();
		                
		                for(int idx = 0; idx <4; idx++)
		                {
		                    int nx = x + dx[idx];
		                    int ny = y + dy[idx];
		                    
		                    if(nx<0||ny<0||nx>=m||ny>=n) continue;
		                    if(grid[ny,nx]==1) continue;
		                    if(visited[ny,nx]!=0) continue;
		                    
		                    xq.Enqueue(nx);
		                    yq.Enqueue(ny);
		                    
		                    visited[ny,nx] = visited[y,x] + 1;
		                    last = visited[ny,nx];
		                }
		            }
		            
		            if(maxDist < last) maxDist = last;
		        }
		    }
		}
		
		Console.WriteLine(maxDist-1);
	}
}