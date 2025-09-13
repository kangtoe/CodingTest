using System;
using System.Collections.Generic;

public class Sol
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        
        string[] arrStr = Console.ReadLine().Split();
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(arrStr[i]);
        }
        
        Array.Sort(arr);
        
        int count = 0;
        
        int left = 0;
        int right = n-1;
        while(left < right)
        {
            int sum = arr[left] + arr[right];
            if(sum == m)
            {
                count++;
                left++;
                right--;
                continue;
            }
            
            if(sum > m) right--;
            else left++;
        }
        
        Console.WriteLine(count);
    }
}