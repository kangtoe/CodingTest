using System;
using System.Collections.Generic;

public class Solution {
    
    int Col(int i)
    {
        if(i%2 == 0) return i/2;
        else return 3 * i + 1;
    }
    
    public int[] solution(int n) {        
        
        List<int> answer = new List<int>();
                
        int i = n;
        while(i != 1)
        {
            answer.Add(i);
            i = Col(i);
            
        }
        answer.Add(1);
        
        return answer.ToArray();
    }
}