using System;
using System.Collections.Generic;

public class Sol
{
    static void Main()
    {
        int count = 0;
        int  n= int.Parse(Console.ReadLine());
        
        for (int i = 0; i <n;i++)
        {
            List<char> stack = new List<char>();
            
            string str = Console.ReadLine();
            for(int j = 0; j < str.Length; j++)
            {
                char c = str[j];
                
                if(stack.Count == 0)
                {
                    stack.Add(c);
                    continue;
                }
                
                if(c == stack[stack.Count-1])
                {
                    stack.RemoveAt(stack.Count-1);
                    continue;
                }
                
                stack.Add(c);
            }
            if(stack.Count == 0) count ++;        
        }
        
        Console.WriteLine(count);
    }
}