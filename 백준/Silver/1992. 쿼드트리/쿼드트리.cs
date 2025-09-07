using System;
class HelloWorld {
    
    static string Quad(int y, int x, int size, int[,] grid)
    {
        //Console.WriteLine(y + " " + x + " " +size);
        if(size == 1) return grid[y,x].ToString();
        
        string str = "";
        int c = grid[y,x];
        for(int i = y; i < y + size; i++)
        {
            for(int j = x; j < x + size; j++)
            {
                int h = size/2;
                
                if(grid[i,j]!=c)
                {
                    str += "(";
                    str += Quad(y,x,h,grid);
                    str += Quad(y,x+h,h,grid);
                    str += Quad(y+h,x,h,grid);
                    str += Quad(y+h,x+h,h,grid);
                    str += ")";
                    return str;
                }
            }
        }
        
        return c.ToString();
    }
    
	static void Main() {
		int n = int.Parse(Console.ReadLine());
		
		int[,] grid = new int[n,n];
		for(int i = 0; i< n;i++)
		{
		    string str = Console.ReadLine();
		    for(int j = 0; j < n;j++)
		    {
		        grid[i,j] = str[j] - '0';
		    }
		}
		
		string ans = Quad(0,0,n,grid);
		Console.WriteLine(ans);
	}
}