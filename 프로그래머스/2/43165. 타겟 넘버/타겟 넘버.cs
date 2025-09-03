using System;
using System.Collections.Generic;

public class Solution {
    
    int count = 0;
    
    void calc(int[] numbers, int target, int val, int idx)
    {
        if(idx >= numbers.Length)
        {
            if (val == target) count++;
            return;
        }                                
        
        calc(numbers, target, val + numbers[idx], idx+1);
        calc(numbers, target, val - numbers[idx], idx+1);
    }
    
    public int solution(int[] numbers, int target) {        
        
        calc(numbers, target, 0, 0);
        
        return count;
    }
}