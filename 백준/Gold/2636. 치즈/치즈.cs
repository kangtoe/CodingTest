using System;
class HelloWorld {
	static int row,col;
	static int[,] grid, visited;

	static int GetMeltCount()
	{
		int count =0;
		for(int i = 0; i < row; i++)
		{
			for(int j = 0; j < col; j++)
			{
				if(grid[i,j] == 2)
				{
					count++;
				}
			}
		}
		return count;
	}

	static void Dfs(int x, int y)
	{
		visited[y,x] = 1;

		int[] dx = {1,-1,0,0};
		int[] dy = {0,0,1,-1};

		for(int i = 0; i <4; i++)
		{
			int nx = x + dx[i];
			int ny = y + dy[i];

			if(nx<0||ny<0||nx>=col||ny>=row) continue;
			if(visited[ny,nx]==1) continue;
			if(grid[ny,nx]==2)continue;
			if(grid[ny,nx]==1)
			{
				grid[ny,nx]=2;
				continue;
			}

			Dfs(nx, ny);
		}
	}

	static void Main()
	{
		string[] str = Console.ReadLine().Split();

		row = int.Parse(str[0]);
		col = int.Parse(str[1]);

		grid = new int[row,col];
		visited = new int[row,col];

		int startCheese = 0;
		for(int i = 0; i < row; i++)
		{
			string[] nums = Console.ReadLine().Split();

			for(int j = 0; j < col; j++)
			{
				grid[i,j] = int.Parse(nums[j]);
				if(grid[i,j]==1) startCheese++;
			}
		}

		int time = 0;
		int lastRemain = startCheese;
		while(true)
		{
			for(int i = 0; i < row; i++)
			{
				for(int j = 0; j < col; j++)
				{
					visited[i,j] = 0;
				}
			}

			Dfs(0,0);
			int melt = GetMeltCount();
			if(melt==0) break;

			time++;
			lastRemain = melt;

			for(int i = 0; i < row; i++)
			{
				for(int j = 0; j < col; j++)
				{
					if(grid[i,j] == 2)
					{
						grid[i,j] = 0;
					}
				}
			}

		}

		Console.WriteLine(time);
		Console.WriteLine(lastRemain);
	}
}