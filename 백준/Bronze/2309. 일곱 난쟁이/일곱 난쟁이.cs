using System;
using System.Collections.Generic;
class HelloWorld {

	static void Comb(int n, int r, int start, List<int> curr, List<List<int>> res)
	{
		if(curr.Count == r)
		{
		    res.Add(new List<int>(curr));
			return;
		}

		for(int i = start; i < n; i++)
		{
			curr.Add(i);
			Comb(n,r,i+1,curr,res);
			curr.RemoveAt(curr.Count-1);
		}
	}

	static void Main()
	{
		int[] arr = new int[9];

		for(int i =0; i< 9; i++)
		{
			arr[i] = int.Parse(Console.ReadLine());
		}

		List<List<int>> res = new List<List<int>>();
		Comb(9,7,0,new List<int>(),res);
		
		List<int> ans = new List<int>();
		foreach(List<int> l in res)
		{
		    int sum =0;
		    foreach(int i in l)
		    {
		        sum += arr[i];
		    }
		    if(sum != 100) continue;
		    
		    foreach(int i in l)
		    {
		        ans.Add(arr[i]);
		    }
		    break;
		}
		
		ans.Sort();
		//Console.WriteLine("---");
		foreach(int i in ans)
		{
		    Console.WriteLine(i);
		}
	}
}
