using System;
using System.Collections.Generic;

public class Sol
{
	static int[,]grid,visited;

	static void Main()
	{
	    string[] nm = Console.ReadLine().Split();
		int n = int.Parse(nm[0]);
		int m = int.Parse(nm[1]);

        visited = new int[n,m];
		grid = new int[n,m];
		for(int i=0; i<n;i++)
		{
		    string line = Console.ReadLine();
		    for(int j =0; j< m; j++)
		    {
		        grid[i,j] = line[j] - '0';
		    }
		}

		Queue<int> xq = new Queue<int>();
		Queue<int> yq = new Queue<int>();

		xq.Enqueue(0);
		yq.Enqueue(0);
		visited[0,0] = 1;
		while(xq.Count>0)
		{
			int x = xq.Dequeue();
			int y = yq.Dequeue();

			int[] dx = {0,0,-1,1};
			int[] dy = {1,-1,0,0};

			for(int i =0; i < 4; i++)
			{
				int ny = y + dy[i];
				int nx = x + dx[i];

				if(ny<0||nx<0||ny>=n||nx>=m) continue;
				if(visited[ny,nx]!=0) continue;
				if(grid[ny,nx]!=1) continue;

                yq.Enqueue(ny);
				xq.Enqueue(nx);
				
				visited[ny,nx] = visited[y,x] + 1;
			}
		}
		
		Console.WriteLine(visited[n-1,m-1]);
	}
}