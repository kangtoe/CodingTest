using System;
using System.Collections.Generic;

class HelloWorld {
    
    static int Clamp0(int i)
    {
        if(i<0) return 0;
        return i;
    }
    
    static int[,] attacks={
            {9,3,1},
            {9,1,3},
            {3,9,1},
            {3,1,9},
            {1,9,3},
            {1,3,9}
    };
    
	static void Main() {
		int n = int.Parse(Console.ReadLine());
		int a,b,c;
		string[] abc = Console.ReadLine().Split();
		
		int[,,] visited = new int[61,61,61];
		
		a = int.Parse(abc[0]);
		if(n>=2) b = int.Parse(abc[1]); else b = 0;
		if(n>=3) c = int.Parse(abc[2]); else c = 0;
		
		Queue<int> aq = new Queue<int>();
		Queue<int> bq = new Queue<int>();
		Queue<int> cq = new Queue<int>();
		aq.Enqueue(a);
		bq.Enqueue(b);
		cq.Enqueue(c);
		visited[a,b,c] = 1;
		
		while(aq.Count>0)
		{
		    a = aq.Dequeue();
		    b = bq.Dequeue();
		    c = cq.Dequeue();
		    
		    for(int i =0; i< 6; i++)
		    {
		        int na = Clamp0(a - attacks[i,0]);
		        int nb = Clamp0(b - attacks[i,1]);
		        int nc = Clamp0(c - attacks[i,2]);
		        
		        if(visited[na,nb,nc]!=0)continue;
		        
		        visited[na,nb,nc] = visited[a,b,c]+1;
        		aq.Enqueue(na);
		        bq.Enqueue(nb);
		        cq.Enqueue(nc);
		    }
		}
		
		Console.WriteLine(visited[0,0,0]-1);
	}
}
