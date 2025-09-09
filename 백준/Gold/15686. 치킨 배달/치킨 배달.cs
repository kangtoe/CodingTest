using System;
using System.Collections.Generic;

public class Collections {

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

	static int Abs(int i)
	{
		if(i<0)return -i;
		return i;
	}

	static int GetSum(List<int> li, List<List<int>> chicks, List<List<int>> homes)
	{
		int sum = 0;

		for(int i = 0; i < homes.Count; i++)
		{
			int ny = homes[i][0];
			int nx = homes[i][1];

            int minDist = int.MaxValue;
			foreach(int idx in li)
			{
				int y = chicks[idx][0];
				int x = chicks[idx][1];

				int dist = Abs(x - nx) + Abs(y - ny);
				if(dist < minDist) minDist = dist;
			}
			
			sum += minDist;
		}

		return sum;
	}

	static void Main()
	{
		string[] nm = Console.ReadLine().Split();
		int n = int.Parse(nm[0]);
		int m = int.Parse(nm[1]);

		int[,] grid = new int[n,n];
		List<List<int>> chicks = new List<List<int>>();
		List<List<int>> homes = new List<List<int>>();

		for(int i  = 0; i< n; i++)
		{
			string[] str = Console.ReadLine().Split();
			for(int j = 0; j< n; j++)
			{
				grid[i,j] = int.Parse(str[j]);
				if(grid[i,j] == 1) homes.Add(new List<int> {i,j});
				if(grid[i,j] == 2) chicks.Add(new List<int> {i,j});
			}
		}

		List<List<int>> res = new List<List<int>>();
		Comb(chicks.Count,m,0,new List<int>(), res);

		int minSum = int.MaxValue;
		foreach(List<int> li in res)
		{
			int sum = GetSum(li, chicks, homes);
			if(sum < minSum) minSum = sum;
		}

		Console.WriteLine(minSum);
	}
}