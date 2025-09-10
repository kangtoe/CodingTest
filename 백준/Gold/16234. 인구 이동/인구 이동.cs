using System;
using System.Collections.Generic;
class HelloWorld {

	static int n,l,r;
	static int[,] grid;

	static int Abs(int i )
	{
		if(i<0)return -i;
		return i;
	}

	static bool OpenCheck(int y, int x, int ny, int nx, int[,] grid)
	{
		int i = Abs(grid[y,x]-grid[ny,nx]);
		return i >= l && i <= r;
	}

	static void Dfs(int y, int x, int[,] visited, List<int> xl, List<int> yl)
	{
		visited[y,x] = 1;
		xl.Add(x);
		yl.Add(y);

		int[] dy = new int[] {1,-1,0,0};
		int[] dx = new int[] {0,0,-1,1};

		for(int k = 0; k < 4; k++)
		{
			int ny = y + dy[k];
			int nx = x + dx[k];

			if(ny<0||nx<0||ny>=n||nx>=n) continue;
			if(visited[ny,nx]!=0)continue;
			if(!OpenCheck(y,x,ny,nx,grid)) continue;

			Dfs(ny,nx, visited, xl, yl);
		}
	}

	static void Move(List<int> xl, List<int> yl)
	{
		int sum = 0;
		for(int i = 0; i < xl.Count; i++)
		{
		    sum += grid[yl[i],xl[i]];
		}
		
		for(int i = 0; i < xl.Count; i++)
		{
		    grid[yl[i],xl[i]] = sum / xl.Count;
		}
	}

	static void Main() {
		string[] nlr = Console.ReadLine().Split();
		n = int.Parse(nlr[0]);
		l = int.Parse(nlr[1]);
		r = int.Parse(nlr[2]);

		grid  = new int[n,n];
		for(int i = 0; i < n; i++)
		{
			string[] str = Console.ReadLine().Split();
			for(int j = 0; j < n; j++)
			{
				grid[i,j] = int.Parse(str[j]);
			}
		}

		int count = 0;
		bool isMove;
		while(true) {
		    isMove = false;
			int[,] visited = new int[n,n];

			for(int i = 0; i < n; i++)
			{
				for(int j = 0; j < n; j++)
				{
				    if(visited[i,j]!=0) continue;
                    
                    List<int> xl = new List<int>();
			        List<int> yl = new List<int>();
					
					Dfs(i,j, visited,xl,yl);
					
					if(xl.Count>1)
					{
    					Move(xl,yl);
    					isMove = true;    
					}
				}
			}
			
			if(!isMove) break;
			count++;
		}

		Console.WriteLine(count.ToString());
	}
}