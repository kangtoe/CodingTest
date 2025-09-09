using System;
using System.Collections.Generic;

public class Sol {
	static int mx = 0;

	static void Bfs(int startX, int startY, char[,] grid)
	{
		int[,] visited = new int[grid.GetLength(0),grid.GetLength(1)];

		int[] dy = new int[] {-1,1,0,0};
		int[] dx = new int[] {0,0,-1,1};

		Queue<int> xq = new Queue<int>();
		Queue<int> yq = new Queue<int>();

		xq.Enqueue(startX);
		yq.Enqueue(startY);
		visited[startY,startX] = 1;


		while(xq.Count>0)
		{
			int x = xq.Dequeue();
			int y = yq.Dequeue();

			for(int i = 0; i < 4; i++)
			{
				int nx = x + dx[i];
				int ny = y + dy[i];

				if(nx<0||ny<0||nx>=grid.GetLength(1)||ny>=grid.GetLength(0)) continue;
				if(visited[ny,nx] != 0) continue;
				if(grid[ny,nx] != 'L') continue;

				visited[ny,nx] = visited[y,x] + 1;
				if(mx< visited[ny,nx]) mx = visited[ny,nx];

				xq.Enqueue(nx);
				yq.Enqueue(ny);
			}
		}
	}

	static void Main()
	{
		string[] rc = Console.ReadLine().Split();
		int r = int.Parse(rc[0]);
		int c = int.Parse(rc[1]);

		char[,] grid = new char [r,c];

		for(int row = 0; row < r; row++)
		{
			string str = Console.ReadLine();
			for(int col = 0; col < c; col++)
			{
				grid[row,col] = str[col];
			}
		}
		
		for(int row = 0; row < r; row++)
		{
		    for(int col = 0; col < c; col++)
		    {
		        if(grid[row,col] == 'L') Bfs(col,row,grid);
		    }
		}

        Console.WriteLine(mx-1);
	}
}