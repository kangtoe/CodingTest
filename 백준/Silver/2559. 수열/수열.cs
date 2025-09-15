using System;
using System.Collections.Generic;

public class Sol
{
    static void Main()
    {
        string[] nk = Console.ReadLine().Split();
        int n = int.Parse(nk[0]);
        int k = int.Parse(nk[1]);
        
        int[] temps = new int[n];
        int[] sums = new int[n];
        
        string[] str = Console.ReadLine().Split();
        for(int i =0; i < n; i++)
        {
            temps[i] = int.Parse(str[i]);
            
            if(i == 0)
            {
                sums[i] = temps[i];
            }
            else
            {
                sums[i] = sums[i-1] + temps[i];
            }
        }
        
        int max = sums[k-1];
        for(int i = k; i < n; i++)
        {
            int part = sums[i] - sums[i-k];
            if(part > max) max = part;
        }
        
        Console.WriteLine(max);
    }
}