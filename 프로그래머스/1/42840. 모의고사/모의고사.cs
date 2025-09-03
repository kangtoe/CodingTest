using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] one = new int[]{1, 2, 3, 4, 5};
        int[] two = new int[]{2, 1, 2, 3, 2, 4, 2, 5};
        int[] thr = new int[]{ 3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        
        int count1 = 0, count2 = 0, count3 = 0;
        
        for(int i = 0; i < answers.Length; i++)
        {
            if(answers[i] == one[i%one.Length]) count1++;
            if(answers[i] == two[i%two.Length]) count2++;
            if(answers[i] == thr[i%thr.Length]) count3++;
        }
        
        int[] counts = new int[]{count1,count2,count3};
        Array.Sort(counts);
        int max = counts[counts.Length-1];
        
        List<int> ans = new List<int>();
        if(max==count1) ans.Add(1);
        if(max==count2) ans.Add(2);
        if(max==count3) ans.Add(3);
        return ans.ToArray();
    }
}