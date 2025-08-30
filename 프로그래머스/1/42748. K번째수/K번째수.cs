using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        List<int> ans = new List<int>();
        for(int i =0; i < commands.GetLength(0); i++)
        {
            int s = commands[i,0];
            int e = commands[i,1];
            int idx = commands[i,2];
            
            List<int> numbers = new List<int>();
            for (int j = s-1; j < e; j++)
            {
                numbers.Add(array[j]);
            }
            numbers.Sort();
            ans.Add(numbers[idx-1]);
        }
        
        return ans.ToArray();
    }
}