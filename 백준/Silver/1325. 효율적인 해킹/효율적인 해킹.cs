using System;
using System.Collections.Generic;

class HelloWorld {
    
    static List<int>[] arr;
    static int[] visited;
    static int[] heckCount;
    
    static int Dfs(int here)
    {
        visited[here] = 1;
        
        int sum = 1;
        foreach(int i in arr[here])
        {
            if(visited[i]==1) continue; 
            sum += Dfs(i);
        }
        
        return sum;
    }
    
	static void Main() {
		string[] nm = Console.ReadLine().Split();
		int n = int.Parse(nm[0]);
		int m = int.Parse(nm[1]);
		
		
		arr = new List<int>[n];
		for(int i = 0; i < n; i++) arr[i] = new List<int>();
		for(int i = 0; i < m; i++)
		{
		    string[] tmp = Console.ReadLine().Split();
		    int a = int.Parse(tmp[0]);
		    int b = int.Parse(tmp[1]);
		    
		    arr[b-1].Add(a-1);
		}
		
		int maxCount = 0;
		visited = new int[n];
		heckCount = new int[n];
		for(int i = 0; i < n; i++)
		{
		    for(int j = 0; j < n; j++) visited[j] = 0;
            heckCount[i] = Dfs(i);
            if(maxCount < heckCount[i]) maxCount = heckCount[i];
		}
		
		List<int> ans = new List<int>();
		for(int i = 0; i < n; i++)
		{
		    if(heckCount[i] == maxCount) ans.Add(i+1);
		}
		
		Console.WriteLine(string.Join(" ", ans));
	}
}
