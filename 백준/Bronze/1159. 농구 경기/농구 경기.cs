using System;
using System.Collections.Generic;
class HelloWorld {
	static void Main() {
	    int n = int.Parse(Console.ReadLine());
		int[] alp = new int['z'-'a'+1];
		
		for(int i =0; i< n; i++)
		{
		    string name = Console.ReadLine();
		    alp[name[0] - 'a']++;
		}
		
		List<char> sel  = new List<char>();
		for(int i =0; i < alp.Length; i++)
		{
		    if(alp[i]>=5) sel.Add((char)('a'+i));
		}
		
		if(sel.Count==0)
		{
		    Console.WriteLine("PREDAJA");
		    return;
		}
		
		sel.Sort();
		Console.WriteLine(string.Join("", sel));
	}
}