using System;
using System.Collections.Generic;
class HelloWorld {
	static void Main() {
	    int a,b,c;
	    string[] abc = Console.ReadLine().Split();
	    
	    a = int.Parse(abc[0]);
	    b = int.Parse(abc[1]);
	    c = int.Parse(abc[2]);
	    
	    int[] park = new int[101];
	    for(int i =0; i < 3;i++)
	    {
	        string[] line = Console.ReadLine().Split();
	        int start = int.Parse(line[0]);
	        int end = int.Parse(line[1]);
	        
	        for(int idx = start; idx < end; idx++)
	        {
	            park[idx]++;
	        }
	    }
	    
	    int sum = 0;
	    for(int i =0; i< park.Length; i++)
	    {
	        if(park[i] == 1) sum += a;
	        if(park[i] == 2) sum += b*2;
	        if(park[i] == 3) sum += c*3;
	    }
	    
	    Console.WriteLine(sum);
	}
}