using System;
using System.Collections.Generic;

public class Sol
{
	static void Main()
	{
		int t = int.Parse(Console.ReadLine());
		for(int test = 0; test < t; test++)
		{
			Dictionary<string, int> cos = new Dictionary<string, int>();

			int n = int.Parse(Console.ReadLine());
			for(int i = 0; i < n; i++)
			{
				string[] str = Console.ReadLine().Split();

				if(!cos.ContainsKey(str[1]))cos.Add(str[1],1);
				else cos[str[1]]++;
			}

			int sum = 1;
			foreach(int i in cos.Values)
			{
                sum *= (i + 1);
			}

			Console.WriteLine(sum - 1);
		}

	}
}
