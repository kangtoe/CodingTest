using System;

public class Solution {
    
    int count = 0;    
    
    void Dfs(int curr, int idx, int[] numbers, int target)
    {
        if(idx == numbers.Length)
        {
            if(curr == target) count++;
            return;
        }
        
        Dfs(curr + numbers[idx], idx + 1, numbers, target);
        Dfs(curr - numbers[idx], idx + 1, numbers, target);
    }
    
    public int solution(int[] numbers, int target) {        
                
        Dfs(0,0,numbers,target);
        
        return count;
    }
}