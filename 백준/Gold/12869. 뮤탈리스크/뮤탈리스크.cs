using System;
using System.Collections.Generic;
class HelloWorld {
    
	static void Main() {
        int[,] attacks = new int[6,3]{
            {9,3,1},
            {9,1,3},
            {3,9,1},
            {3,1,9},
            {1,9,3},
            {1,3,9}
        };
        
        int minDest = int.MaxValue;
        int[,,] visited = new int[61,61,61];
	    
		Queue<int> aq =  new Queue<int>();
		Queue<int> bq =  new Queue<int>();
		Queue<int> cq =  new Queue<int>();
		
		int n = int.Parse(Console.ReadLine());
		string[] starts = new string[3];
		string[] line = Console.ReadLine().Split();
		for(int i = 0; i < 3; i++)
		{
		    if(i<line.Length) starts[i] = line[i];
		    else starts[i] = "0";
		}
		
		int startA = int.Parse(starts[0]);
		int startB = int.Parse(starts[1]);
		int startC = int.Parse(starts[2]);
		
		aq.Enqueue(startA);
		bq.Enqueue(startB);
		cq.Enqueue(startC);
		visited[startA,startB,startC] = 1;
		
		while(aq.Count > 0)
		{
		    int a = aq.Dequeue();
		    int b = bq.Dequeue();
		    int c = cq.Dequeue();
		    
		    for(int i = 0; i< 6; i++)
		    {
		        int resA = a - attacks[i,0];
		        int resB = b - attacks[i,1];
		        int resC = c - attacks[i,2];
		        if(resA < 0) resA = 0;
		        if(resB < 0) resB = 0;
		        if(resC < 0) resC = 0;
		        
		        if(visited[resA,resB,resC]!=0) continue;
		        
		        visited[resA,resB,resC] = visited[a,b,c]+1;
		        
		        // destory all
		        if(resA <=0 && resB <=0 && resC <=0)
		        {
		            if(visited[a,b,c] < minDest) minDest = visited[a,b,c];
		            continue;
		        }
		        
        		aq.Enqueue(resA);
		        bq.Enqueue(resB);
		        cq.Enqueue(resC);
		    }
		}
		
		Console.WriteLine(minDest);
	}
}