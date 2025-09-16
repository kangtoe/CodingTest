using System;
using System.Collections.Generic;
class HelloWorld {

	static int[,] grid, visited, gridTmp;
	static int n,m;

	static void Comb(int start, int n, int r, List<int> curr, List<List<int>> res)
	{
		if(r == curr.Count)
		{
			res.Add(new List<int>(curr));
			return;
		}
		
		for(int i = start; i < n; i++)
		{
		    curr.Add(i);
		    Comb(i+1,n,r,curr,res);
		    curr.RemoveAt(curr.Count-1);
		}
	}
	
	static void Dfs(int y, int x)
	{
	    visited[y,x] = 1;
	    
	    int[] dx = {0,0,-1,1};
	    int[] dy = {1,-1,0,0};
	    
	    for(int i =0; i< 4; i++)
	    {
	        int nx = x + dx[i];
	        int ny = y + dy[i];
	        
	        if(nx<0||ny<0||nx>=m||ny>=n) continue;
	        if(visited[ny,nx]!=0) continue;
	        if(gridTmp[ny,nx]!=0) continue;
	        
	        gridTmp[ny,nx] = 2;
	        Dfs(ny, nx);
	    }
	}

	static void Main() 
	{
	    string[] str = Console.ReadLine().Split();
	    n = int.Parse(str[0]);
	    m = int.Parse(str[1]);
	    
	    grid = new int[n,m];
	    for(int i = 0; i< n; i++)
	    {
	        string[] line = Console.ReadLine().Split();    
	        for(int j =0;j <m;j++)
	        {
	            grid[i,j] = int.Parse(line[j]);
	        }
	    }
	    
	    visited = new int[n,m];
	    gridTmp = new int[n,m];

        List<List<int>> res = new List<List<int>>();
        Comb(0,n*m,3,new List<int>(), res);
        
        int areaCount = 0;
        
        foreach(List<int> li in res)
        {
            // init lists
            for(int i = 0; i < n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    gridTmp[i,j] = grid[i,j];
                    visited[i,j] = 0;
                }
            }
            
            // simulate wall add
            bool valid = true;
            foreach(int i in li)
            {
                int y = i / m;
                int x = i % m;
                
                if(grid[y,x]!=0)
                {
                    valid = false;
                    break;
                }
                
                gridTmp[y,x] = 1;
            }
            if(!valid)continue;
            
            // spead virus
            for(int i = 0; i < n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    if(visited[i,j]!=0) continue;
                    if(gridTmp[i,j]!=2) continue;
                    
                    Dfs(i,j);
                }
            }
            
            // count safe area
            int safe = 0;
            for(int i = 0; i < n;i++)
            {
                for(int j=0;j<m;j++)
                {
                    if(gridTmp[i,j]==0) safe++;
                }
            }
            if(areaCount < safe) areaCount = safe;
        }
        
        Console.WriteLine(areaCount);
	}
}