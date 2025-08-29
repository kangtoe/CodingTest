using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        if(arr.Length == 1) return new int[]{-1};
        
        List<int> li = new List<int>();
        
        int minVal = int.MaxValue;
        foreach(int i in arr)
        {
            if(minVal > i) minVal = i;
            li.Add(i);
        }
        li.Remove(minVal); 
        
        return li.ToArray();
    }
}