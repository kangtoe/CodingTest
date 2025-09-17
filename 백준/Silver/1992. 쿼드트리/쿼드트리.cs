using System;
class HelloWorld {
    
    static int n;
    static int[,] grid;
    
    static string Dfs(int startY, int startX, int size)
    {
        if(size==1) return grid[startY,startX].ToString();
        
        int first = grid[startY, startX];
        for(int i = startY; i < startY + size; i++)
        {
            for(int j = startX; j < startX + size; j++)
            {
                if(grid[i,j]!=first)
                {
                    string str = "";
                    str += "(";
                    str += Dfs(startY,startX,size/2);
                    str += Dfs(startY,startX+size/2,size/2);
                    str += Dfs(startY+size/2,startX,size/2);
                    str += Dfs(startY+size/2,startX+size/2,size/2);
                    str += ")";
                    return str;
                }
            }
        }
        return first.ToString();
    }
    
	static void Main() {
		n = int.Parse(Console.ReadLine());
		grid = new int[n,n];
		
		for(int i = 0; i <n; i++)
		{
		    string str = Console.ReadLine();
		    for(int j = 0; j < n; j++)
		    {
		        grid[i,j] = str[j] - '0';
		    }
		}
		
		Console.WriteLine(Dfs(0,0,n));
	}
}