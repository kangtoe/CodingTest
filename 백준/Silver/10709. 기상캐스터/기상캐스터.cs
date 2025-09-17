using System;
class HelloWorld {
	static void Main() {
		int h,w;
		string[] hw = Console.ReadLine().Split();
		h = int.Parse(hw[0]);
		w = int.Parse(hw[1]);
		
		int[,] grid = new int[h,w];
		for(int row = 0; row < h; row++)
		{
		    string str = Console.ReadLine();
		    for(int col = 0; col < w; col++)
		    {
                if(str[col]=='c') grid[row,col] = 1;
                else grid[row,col] = 0;
		    }
		}
		
		int[,] ans = new int[h,w];
		for(int row = 0; row < h; row++)
		{
		    for(int col = 0; col < w; col++)
		    {
		        ans[row,col] = -1;
		    }
		}
		
		for(int row = 0; row < h; row++)
		{
		    for(int col = 0; col < w; col++)
		    {
		        if(grid[row,col]==1)
		        {
		            for(int i = col; i < w; i++)
		            {
		                ans[row,i] = i - col;
		            }
		        }
		    }
		}
		
		for(int row = 0; row < h; row++)
		{
		    string str = "";
		    for(int col = 0; col < w; col++)
		    {
		        str += ans[row,col];
		        if(col < w-1) str += " ";
		    }
		    Console.WriteLine(str);
		}
		
	}
}