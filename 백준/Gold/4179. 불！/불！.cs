
using System;
using System.Collections.Generic;

class HelloWorld {
	static void Main() {

		string[] rc = Console.ReadLine().Split();
		int r = int.Parse(rc[0]);
		int c = int.Parse(rc[1]);

		char[,] grid = new char[r,c];
		int[,] fireVisited = new int[r,c];
		int[,] visited = new int[r,c];

		List<int> start = new List<int>();
		List<List<int>> fires = new List<List<int>>();

		for(int i = 0; i <r; i++)
		{
			string line = Console.ReadLine();
			for(int j = 0; j <c; j++)
			{
				grid[i,j] = line[j];

				if(grid[i,j] == 'J') start = new List<int>() {i,j};
				if(grid[i,j] == 'F') fires.Add(new List<int>(){i,j});
			}
		}
		
		if(start[0]==0||start[0]==r-1||start[1]==0||start[1]==c-1)
		{
		    Console.WriteLine(1);
		    return;
		}
		
		for(int i =0; i< r; i++)
		{
		    for(int j =0; j< c; j++)
		    {
		        fireVisited[i,j] = int.MaxValue;
		        visited[i,j] = int.MaxValue;
		    }
		}

		Queue<int> xq = new Queue<int>();
		Queue<int> yq = new Queue<int>();
		int[]dy= {1,-1,0,0};
		int[]dx= {0,0,-1,1};

		foreach(List<int> fire in fires)
		{
			int y = fire[0];
			int x = fire[1];

			fireVisited[y,x] = 1;
			yq.Enqueue(y);
			xq.Enqueue(x);
		}

		while(xq.Count > 0)
		{
			int y = yq.Dequeue();
			int x = xq.Dequeue();

			for(int i =0; i< 4; i++)
			{
				int ny = y + dy[i];
				int nx = x + dx[i];

				if(ny<0||nx<0||ny>=r||nx>=c) continue;
				if(fireVisited[ny,nx]!=int.MaxValue) continue;
				if(grid[ny,nx]=='#') continue;

				fireVisited[ny,nx] = fireVisited[y,x] +1;
				yq.Enqueue(ny);
				xq.Enqueue(nx);
			}
		}

        yq.Enqueue(start[0]);
		xq.Enqueue(start[1]);
		visited[start[0],start[1]] = 1;
		
        while(xq.Count > 0)
		{
			int y = yq.Dequeue();
			int x = xq.Dequeue();

			for(int i =0; i< 4; i++)
			{
				int ny = y + dy[i];
				int nx = x + dx[i];

				if(ny<0||nx<0||ny>=r||nx>=c) continue;
				if(visited[ny,nx]!=int.MaxValue) continue;
				if(grid[ny,nx]=='#') continue;
				if(fireVisited[ny,nx]<=visited[y,x]+1) continue;

				visited[ny,nx] = visited[y,x] +1;
				yq.Enqueue(ny);
				xq.Enqueue(nx);
			}
		}
        
        int minDist = int.MaxValue;
		for(int i =0; i< r; i++)
		{
		    for(int j =0; j< c; j++)
		    {
		        if(!(i==0||i==r-1||j==0||j==c-1)) continue;
		        if(grid[i,j]!='.') continue;
		        if(visited[i,j]==int.MaxValue) continue;
		        
		        if(visited[i,j] < minDist) minDist = visited[i,j];
		    }
		}
		
		if(minDist == int.MaxValue) Console.WriteLine("IMPOSSIBLE");
		else Console.WriteLine(minDist);
		    
	}
}