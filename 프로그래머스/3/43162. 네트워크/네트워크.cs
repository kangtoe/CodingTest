using System;

public class Solution {                    
    int Dfs(int[,] computers, int n, int x, int y)
    {
        if(computers[y,x] == 0) return 0;
        
        computers[y,x] = 0;        
        for(int i = 0; i < n; i++)
        {
            Dfs(computers, n, i, x);
        }
        
        return 1;
    }
    
    public int solution(int n, int[,] computers) {
        
        int cnt = 0;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {                                                             
                cnt += Dfs(computers, n, j, i);                
            }                        
        }
        
        return cnt;
    }
}