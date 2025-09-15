using System;
using System.Collections.Generic;

public class Sol
{

    static void Main()
    {
        string[] nm = Console.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);
        
        Dictionary<string, int> dict = new Dictionary<string, int>();
        string[] poks = new string[n];
        for(int i = 0; i < n; i++)
        {
            poks[i] = Console.ReadLine();
            dict.Add(poks[i],i);
        }
        
        for(int i = 0; i < m; i++)
        {
            string q = Console.ReadLine();
            
            if('0' <= q[0] && q[0] <= '9')
            {
                int num = int.Parse(q);
                Console.WriteLine(poks[num-1]);
            }
            else
            {
                Console.WriteLine(dict[q]+1);
            }
        }
    }
}