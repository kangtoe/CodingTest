using System;
using System.Collections.Generic;

class HelloWorld {
    
    static void GetLeaf(List<int>[] nodes, int here, List<int> res, int remove)
    {
        if(nodes[here].Count == 0)
        {
            res.Add(here);
            return;
        }
        
        if(nodes[here].Count == 1 && nodes[here][0] == remove)
        {
            res.Add(here);
            return;
        }
        
        for(int i = 0; i < nodes[here].Count; i++)
        {
            GetLeaf(nodes, nodes[here][i], res, remove);
        }
    }
    
	static void Main() {
		int n = int.Parse(Console.ReadLine());
		
		List<int>[] nodes = new List<int>[n];
		for(int i = 0; i < n; i++) nodes[i] = new List<int>();
		
		int root = -99;
		string[] str = Console.ReadLine().Split();
		for(int i = 0; i < n; i++)
		{
		    int child = i;
		    int parent = int.Parse(str[i]);
		    
		    if(parent == -1)
		    {
		        root = i;
		        continue;
		    }
		    nodes[parent].Add(child);
		}
		
		int remove = int.Parse(Console.ReadLine());

		List<int> allLeaf = new List<int>();
		GetLeaf(nodes, root, allLeaf, remove);
		
		List<int> removedLeaf = new List<int>();
		GetLeaf(nodes, remove, removedLeaf, remove);
		
		int count = 0;
		for(int i = 0; i < allLeaf.Count; i++)
		{
		    if(!removedLeaf.Contains(allLeaf[i])) count++;
		}
		
		Console.WriteLine(count);
	}
}
