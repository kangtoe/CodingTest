using System;

public class Solution {
    public int solution(int[,] sizes) {                                
        
        int col = 0;
        int row = 0;
        for(int i = 0; i < sizes.GetLength(0); i++)
        {            
            int big, small;
            if (sizes[i, 0] > sizes[i, 1])
            {
                big = sizes[i, 0];
                small = sizes[i, 1];
            }
            else
            {
                big = sizes[i, 1];
                small = sizes[i, 0];
            }
            
            if(col < big) col = big;
            if(row < small) row = small;
        }

        return col * row;
    }
}